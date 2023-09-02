using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NugetPackageHistory;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddTransient<NugetPackageHistoryService>();

using IHost host = builder.Build();

var historyService = host.Services.GetRequiredService<NugetPackageHistoryService>();
var history = await historyService.GetEcosystemHistory("sensenet");
Console.WriteLine("======================================================================================================");
Console.WriteLine("==                                          PACKAGES                                                ==");
Console.WriteLine("======================================================================================================");
foreach (var package in history.Packages)
{
    Console.WriteLine($"{package.PackageId}");
    foreach (var release in package.Releases)
    {
        Console.WriteLine($"  {release.Date:yyyy-MM-dd}\t{release.Version}");
    }
}

Console.WriteLine();
Console.WriteLine("======================================================================================================");
Console.WriteLine("==                                          TIMELINE                                                ==");
Console.WriteLine("======================================================================================================");
var lastDate = DateTime.MinValue;
foreach (var release in history.GetTimeLine())
{
    if (lastDate != DateTime.MinValue && (release.Date ?? DateTime.MinValue).Date != lastDate.Date)
        Console.WriteLine();
    lastDate = release.Date ?? DateTime.MinValue;
    Console.WriteLine($"{release.Date:yyyy-MM-dd HH:mm}\t{release.Id,-50}\t{release.Version}");
}
