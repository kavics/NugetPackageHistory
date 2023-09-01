using Newtonsoft.Json;

namespace NugetPackageHistory;

public class PackageDependency
{
    [JsonProperty("@id")] public string? Url { get; set; }
    [JsonProperty("@type")] public string? Type { get; set; }
    [JsonProperty("id")] public string? Id { get; set; }
    [JsonProperty("range")] public string? Range { get; set; }
    [JsonProperty("registration")] public string? Registration { get; set; }
}

public class PackageDependencyGroup
{
    [JsonProperty("@id")] public string? Url { get; set; }
    [JsonProperty("@type")] public string? Type { get; set; }
    [JsonProperty("dependencies")] public List<PackageDependency> Dependencies { get; set; } = new();
    [JsonProperty("targetFramework")] public string? TargetFramework { get; set; }
}

public class PackageDetails
{
    [JsonProperty("@id")] public string? Url { get; set; }
    [JsonProperty("@type")] public string? Type { get; set; }
    //[JsonProperty("authors")] public List<string> Authors { get; set; } = new();
    [JsonProperty("authors")] public string? Authors { get; set; }
    [JsonProperty("dependencyGroups")] public List<PackageDependencyGroup> DependencyGroups { get; set; } = new();
    [JsonProperty("description")] public string? Description { get; set; }
    [JsonProperty("iconUrl")] public string? IconUrl { get; set; }
    [JsonProperty("id")] public string? Id { get; set; }
    [JsonProperty("language")] public string? Language { get; set; }
    [JsonProperty("licenseExpression")] public string? LicenseExpression { get; set; }
    [JsonProperty("licenseUrl")] public string? LicenseUrl { get; set; }
    [JsonProperty("listed")] public bool Listed { get; set; }
    [JsonProperty("minClientVersion")] public string? MinClientVersion { get; set; }
    [JsonProperty("packageContent")] public string? PackageContent { get; set; }
    [JsonProperty("projectUrl")] public string? ProjectUrl { get; set; }
    [JsonProperty("published")] public DateTime? Published { get; set; }
    [JsonProperty("requireLicenseAcceptance")] public bool RequireLicenseAcceptance { get; set; }
    [JsonProperty("summary")] public string? Summary { get; set; }
    [JsonProperty("tags")] public List<string> Tags { get; set; } = new();
    [JsonProperty("title")] public string? Title { get; set; }
    [JsonProperty("version")] public string? Version { get; set; }
}

public class Package
{
    [JsonProperty("@id")] public string? Url { get; set; }
    [JsonProperty("@type")] public string? Type { get; set; }
    [JsonProperty("commitId")] public string? CommitId { get; set; }
    [JsonProperty("commitTimeStamp")] public DateTime? CommitTimeStamp { get; set; }
    [JsonProperty("catalogEntry")] public PackageDetails? CatalogEntry { get; set; }
    [JsonProperty("packageContent")] public string? PackageContent { get; set; }
    [JsonProperty("registration")] public string? Registration { get; set; }
}

public class CatalogPage
{
    [JsonProperty("@id")] public string? Url { get; set; }
    [JsonProperty("@type")] public string? Type { get; set; }
    [JsonProperty("commitId")] public string? CommitId { get; set; }
    [JsonProperty("commitTimeStamp")] public DateTime? CommitTimeStamp { get; set; }
    [JsonProperty("count")] public int Count { get; set; }
    [JsonProperty("items")] public List<Package> Items { get; set; } = new();
    [JsonProperty("parent")] public string? Parent { get; set; }
    [JsonProperty("lower")] public string? Lower { get; set; }
    [JsonProperty("upper")] public string? Upper { get; set; }
}

public class PackageRegistration
{
    [JsonProperty("@id")] public string? Url { get; set; }
    [JsonProperty("@type")] public List<string> Type { get; set; } = new();
    [JsonProperty("commitId")] public string? CommitId { get; set; }
    [JsonProperty("commitTimeStamp")] public DateTime? CommitTimeStamp { get; set; }
    [JsonProperty("count")] public int Count { get; set; }
    [JsonProperty("items")] public List<CatalogPage> Items { get; set; } = new();
    [JsonProperty("@context")] public object? Context { get; set; } = new();
}
