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

    private string urlForLatestPackages = "https://azuresearch-usnc.nuget.org/query?" +
              "q=sensenet.&" +
              "skip=0&" +
              "take=100&" +
              "prerelease=true&" +
              //"supportedFramework=net5.0&" +
              "semVerLevel=2.0.0";

    public async Task<List<LatestPackage>> GetLatestPackages()
    {
        var url = urlForLatestPackages;

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

        using HttpClient httpClient = _httpClientFactory.CreateClient();

        string? jsonResponse = null;
        //using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
        using (var response = await httpClient.GetStreamAsync(url))
        using (GZipStream gzipStream = new GZipStream(response, CompressionMode.Decompress))
        using (StreamReader sr = new StreamReader(gzipStream))
        {
            jsonResponse = await sr.ReadToEndAsync();
        }
        var result = JsonConvert.DeserializeObject<PackageRegistration>(jsonResponse);

        return result ?? new();
    }
}