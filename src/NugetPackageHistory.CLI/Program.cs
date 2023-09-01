//using Newtonsoft.Json;

/*

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

*/
/*
var url = "https://azuresearch-usnc.nuget.org/query?" +
          "q=sensenet.&" +
          "skip=0&" +
          "take=26&" +
          "prerelease=true&" +
          "supportedFramework=net5.0&" +
          "semVerLevel=2.0.0"; // Replace with your URL

try
{
    using (HttpClient httpClient = new HttpClient())
    {
        var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        dynamic json = JsonConvert.DeserializeObject(jsonResponse) ?? "null";

        Console.WriteLine(json);
    }
}
catch (HttpRequestException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
*/

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NugetPackageHistory;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddTransient<NugetPackageHistoryService>();

using IHost host = builder.Build();

var historyService = host.Services.GetRequiredService<NugetPackageHistoryService>();
var history = await historyService.GetEcosystemHistory("sensenet");
foreach (var package in history.Packages)
{
    Console.WriteLine($"{package.PackageId}");
    foreach (var release in package.Releases)
    {
        Console.WriteLine($"  {release.Date:yyyy-MM-dd}\t{release.Version}");
    }
}
