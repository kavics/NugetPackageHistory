namespace NugetPackageHistory;

public class Release
{
    public string? Id => PackageDetails.Id;
    public string? Version => PackageDetails.Version;
    public DateTime? Date => PackageDetails.Published;
    public PackageDetails PackageDetails { get; }

    public Release(PackageDetails packageDetails)
    {
        PackageDetails = packageDetails;
    }
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
            .Select(x => new Release(x.CatalogEntry ?? new PackageDetails()))
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

    public IEnumerable<Release> GetTimeLine()
    {
        return Packages.SelectMany(p => p.Releases).OrderBy(r => r.Date);
    }
}