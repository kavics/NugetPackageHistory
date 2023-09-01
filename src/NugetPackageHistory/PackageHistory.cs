namespace NugetPackageHistory;

public class Release
{
    public string? Version { get; set; }
    public DateTime? Date { get; set; }
}
public class PackageHistory
{
    public string PackageId { get; set; }
    public List<Release> Releases { get; set; }
    public LatestPackage LatestPackage { get; set; }
    public PackageRegistration PackageRegistration { get; set; }

    public PackageHistory(LatestPackage latestPackage, PackageRegistration packageRegistration)
    {
        LatestPackage = latestPackage;
        PackageRegistration = packageRegistration;
        PackageId = latestPackage.Id ?? "unknown";
        Releases = packageRegistration.Items[0].Items
            .Select(x => new Release
            {
                Version = x.CatalogEntry?.Version,
                Date = x.CatalogEntry?.Published
            })
            .ToList();
    }
}

public class EcosystemHistory
{
    public string Id { get; set; }
    public List<PackageHistory> Packages { get; set; }

    public EcosystemHistory(string id, List<PackageHistory> packages)
    {
        Id = id;
        Packages = packages;
    }
}