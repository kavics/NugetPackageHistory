using Newtonsoft.Json;

namespace NugetPackageHistory;

public class Packages
{
    [JsonProperty("totalHits")]       public int TotalHits { get; set; }
    [JsonProperty("data")]            public List<LatestPackage> Items { get; set; } = new();
}

public class LatestPackage
{
    public class PackageType
    {
        [JsonProperty("name")]        public string? Name { get; set; }
    }

    public class VersionInfo
    {
        [JsonProperty("version")]     public string? Version { get; set; }
        [JsonProperty("downloads")]   public int Downloads { get; set; }
        [JsonProperty("@id")]         public string? Url { get; set; }
    }

    public class Vulnerability
    {
        // You can define properties for vulnerabilities here if needed
    }

    [JsonProperty("@id")]             public string? Url { get; set; }
    [JsonProperty("@type")]           public string? Type { get; set; }
    [JsonProperty("registration")]    public string? RegistrationUrl { get; set; }
    [JsonProperty("id")]              public string? Id { get; set; }
    [JsonProperty("version")]         public string? Version { get; set; }
    [JsonProperty("description")]     public string? Description { get; set; }
    [JsonProperty("summary")]         public string? Summary { get; set; }
    [JsonProperty("title")]           public string? Title { get; set; }
    [JsonProperty("iconUrl")]         public string? IconUrl { get; set; }
    [JsonProperty("licenseUrl")]      public string? LicenseUrl { get; set; }
    [JsonProperty("projectUrl")]      public string? ProjectUrl { get; set; }
    [JsonProperty("tags")]            public List<string> Tags { get; set; } = new();
    [JsonProperty("authors")]         public List<string> Authors { get; set; } = new();
    [JsonProperty("owners")]          public List<string> Owners { get; set; } = new();
    [JsonProperty("totalDownloads")]  public int TotalDownloads { get; set; }
    [JsonProperty("verified")]        public bool Verified { get; set; }
    [JsonProperty("packageTypes")]    public List<PackageType> PackageTypes { get; set; } = new();
    [JsonProperty("versions")]        public List<VersionInfo> Versions { get; set; } = new();
    [JsonProperty("vulnerabilities")] public List<Vulnerability> Vulnerabilities { get; set; } = new();
}
