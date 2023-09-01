using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Net;

namespace NugetPackageHistory;

public class NugetPackageHistoryService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger<NugetPackageHistoryService> _logger;

    public NugetPackageHistoryService(IHttpClientFactory httpClientFactory, ILogger<NugetPackageHistoryService> logger)
    {
        _httpClientFactory = httpClientFactory;
        _logger = logger;
    }

    public async Task<EcosystemHistory> GetEcosystemHistory(string id)
    {
        var packages = new List<PackageHistory>();
        foreach (var latestPackage in await GetLatestPackages(id))
        {
            var registration = await GetPackageRegistration(latestPackage);
            packages.Add(new PackageHistory(latestPackage, registration));
        }
        return new EcosystemHistory(id, packages);
    }


    public async Task<List<LatestPackage>> GetLatestPackages(string id)
    {
        var url = "https://azuresearch-usnc.nuget.org/query?" +
                  $"q={id}.&" +
                  "skip=0&" +
                  "take=100&" +
                  "prerelease=true&" +
                  //"supportedFramework=net5.0&" +
                  "semVerLevel=2.0.0"; ;

        using HttpClient httpClient = _httpClientFactory.CreateClient();
        var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        var packages = JsonConvert.DeserializeObject<Packages>(jsonResponse);

        return packages?.Items ?? new();
    }


    public async Task<PackageRegistration> GetPackageRegistration(LatestPackage package)
    {
        // https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json
        var url = $"https://api.nuget.org/v3/registration5-gz-semver2/{package.Id?.ToLowerInvariant()}/index.json";

        using var httpClient = _httpClientFactory.CreateClient();

        await using var response = await httpClient.GetStreamAsync(url);
        await using GZipStream gzipStream = new GZipStream(response, CompressionMode.Decompress);
        using StreamReader sr = new StreamReader(gzipStream);
        var jsonResponse = await sr.ReadToEndAsync();

        var result = JsonConvert.DeserializeObject<PackageRegistration>(jsonResponse);
        return result ?? new();
    }
}