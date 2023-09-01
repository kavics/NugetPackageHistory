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
/*
{
   "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json",
   "@type": [
      "catalog:CatalogRoot",
      "PackageRegistration",
      "catalog:Permalink"
   ],
   "commitId": "f7743747-a4dc-4f91-a401-5f6353a25686",
   "commitTimeStamp": "2023-06-13T14:51:00.8216288+00:00",
   "count": 1,
   "items": [
      {
         "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json#page/7.6.0/7.7.37",
         "@type": "catalog:CatalogPage",
         "commitId": "f7743747-a4dc-4f91-a401-5f6353a25686",
         "commitTimeStamp": "2023-06-13T14:51:00.8216288+00:00",
         "count": 36,
         "items": [
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.6.0.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.3.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.3.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.02.21.16.00.19/sensenet.contentrepository.7.6.0.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.0/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.0/sensenet.contentrepository.7.6.0.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2019-02-21T15:55:34.833+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.6.0"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.0/sensenet.contentrepository.7.6.0.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.6.1.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.3.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.3.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.06.24.08.49.32/sensenet.contentrepository.7.6.1.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.1/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.1/sensenet.contentrepository.7.6.1.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2019-06-24T08:45:11.75+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.6.1"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.1/sensenet.contentrepository.7.6.1.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.6.2.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.3.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.3.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.07.16.09.13.37/sensenet.contentrepository.7.6.2.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.2/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.2/sensenet.contentrepository.7.6.2.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2019-07-16T09:09:01.07+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.6.2"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.2/sensenet.contentrepository.7.6.2.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.6.3.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.3.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.3.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.08.06.12.38.14/sensenet.contentrepository.7.6.3.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.3/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.3/sensenet.contentrepository.7.6.3.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2019-08-06T12:33:38.177+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.6.3"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.3/sensenet.contentrepository.7.6.3.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.6.4.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.3.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.3.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.09.11.09.53.34/sensenet.contentrepository.7.6.4.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.4/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.4/sensenet.contentrepository.7.6.4.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2019-09-11T09:49:22.73+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.6.4"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.6.4/sensenet.contentrepository.7.6.4.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.1.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.3.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.10.10.13.09.02/sensenet.contentrepository.7.7.1.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.1/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.1/sensenet.contentrepository.7.7.1.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2019-10-10T13:07:26+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.1"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.1/sensenet.contentrepository.7.7.1.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.2.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.3.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.11.06.10.38.40/sensenet.contentrepository.7.7.2.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.2/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.2/sensenet.contentrepository.7.7.2.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2019-11-06T10:31:11.34+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.2"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.2/sensenet.contentrepository.7.7.2.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.4.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.3.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2019.12.04.08.35.45/sensenet.contentrepository.7.7.4.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.4/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.4/sensenet.contentrepository.7.7.4.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2019-12-04T08:33:11.867+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.4"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.4/sensenet.contentrepository.7.7.4.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.5.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.3.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.01.09.09.54.49/sensenet.contentrepository.7.7.5.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.5/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.5/sensenet.contentrepository.7.7.5.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-01-09T09:52:39.583+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.5"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.5/sensenet.contentrepository.7.7.5.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.7.json",
               "@type": "Package",
               "commitId": "ebcac6d6-1af6-45a5-a0b1-c9ca6d98d0b6",
               "commitTimeStamp": "2020-02-08T03:52:52.5255261+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.3.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.02.04.13.44.30/sensenet.contentrepository.7.7.7.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.7/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.7/sensenet.contentrepository.7.7.7.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-02-04T13:41:59.28+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.7"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.7/sensenet.contentrepository.7.7.7.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.8.json",
               "@type": "Package",
               "commitId": "6b29269f-a815-4a70-b7b3-4068abc630a3",
               "commitTimeStamp": "2020-03-03T10:52:46.1914207+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.3.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.03.03.10.52.24/sensenet.contentrepository.7.7.8.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.8/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.8/sensenet.contentrepository.7.7.8.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-03-03T10:50:01.387+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.8"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.8/sensenet.contentrepository.7.7.8.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.9.json",
               "@type": "Package",
               "commitId": "13784823-6fde-45f0-94b2-895b7ab75aa0",
               "commitTimeStamp": "2020-04-01T13:42:10.1235755+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.3.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.04.01.13.41.57/sensenet.contentrepository.7.7.9.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.9/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.9/sensenet.contentrepository.7.7.9.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-04-01T13:38:48.98+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.9"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.9/sensenet.contentrepository.7.7.9.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.10.json",
               "@type": "Package",
               "commitId": "5615f0a2-f3ab-4ff3-ad40-3614ff567652",
               "commitTimeStamp": "2020-05-04T11:41:00.8873953+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.3.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.8, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.05.04.11.40.26/sensenet.contentrepository.7.7.10.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.10/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.10/sensenet.contentrepository.7.7.10.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-05-04T11:37:40.793+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.10"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.10/sensenet.contentrepository.7.7.10.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.11.json",
               "@type": "Package",
               "commitId": "a9860df5-966f-457c-a9d9-aa3fb2016fef",
               "commitTimeStamp": "2020-06-02T07:41:23.0636081+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.9, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.02.07.40.57/sensenet.contentrepository.7.7.11.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.11/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.11/sensenet.contentrepository.7.7.11.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-06-02T07:38:16.177+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.11"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.11/sensenet.contentrepository.7.7.11.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.12.json",
               "@type": "Package",
               "commitId": "a56b6aef-e716-4d0e-84b5-e210dd2bb7a7",
               "commitTimeStamp": "2020-06-25T11:14:11.8519654+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.9, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.06.25.11.14.01/sensenet.contentrepository.7.7.12.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.12/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.12/sensenet.contentrepository.7.7.12.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-06-25T11:10:26.963+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.12"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.12/sensenet.contentrepository.7.7.12.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.13.json",
               "@type": "Package",
               "commitId": "75333187-1843-4cb2-b646-7b00caff2c79",
               "commitTimeStamp": "2020-07-28T08:49:00.2980044+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.10, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.07.28.08.48.44/sensenet.contentrepository.7.7.13.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.13/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.13/sensenet.contentrepository.7.7.13.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-07-28T08:46:17.223+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.13"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.13/sensenet.contentrepository.7.7.13.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.14.json",
               "@type": "Package",
               "commitId": "d51efbcf-b553-4a46-9dcc-9d89b7e1728d",
               "commitTimeStamp": "2020-08-24T14:01:44.7002381+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.11, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.08.24.14.01.24/sensenet.contentrepository.7.7.14.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.14/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.14/sensenet.contentrepository.7.7.14.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-08-24T13:59:06.987+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.14"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.14/sensenet.contentrepository.7.7.14.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.15.json",
               "@type": "Package",
               "commitId": "ecd0e029-ebc6-4cc5-8b9d-b8f94ff1771a",
               "commitTimeStamp": "2020-09-09T13:59:42.5851785+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.12, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.09.13.59.05/sensenet.contentrepository.7.7.15.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.15/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.15/sensenet.contentrepository.7.7.15.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-09-09T13:56:49.703+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.15"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.15/sensenet.contentrepository.7.7.15.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.16.json",
               "@type": "Package",
               "commitId": "39a8c28e-0a5e-41f7-9385-c696ef5eea65",
               "commitTimeStamp": "2020-09-29T09:56:48.1650023+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.13, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.09.29.09.56.09/sensenet.contentrepository.7.7.16.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.16/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.16/sensenet.contentrepository.7.7.16.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-09-29T09:53:15.237+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.16"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.16/sensenet.contentrepository.7.7.16.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.17.json",
               "@type": "Package",
               "commitId": "060dd9f7-97ab-4d08-ac7c-439b50b343cd",
               "commitTimeStamp": "2020-10-22T08:22:12.2408209+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.14, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.10.22.08.19.06/sensenet.contentrepository.7.7.17.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.17/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.17/sensenet.contentrepository.7.7.17.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-10-22T08:16:51.357+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.17"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.17/sensenet.contentrepository.7.7.17.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.18.json",
               "@type": "Package",
               "commitId": "9dc113e2-96b5-4dcd-a002-ce25170a9bee",
               "commitTimeStamp": "2020-11-20T07:55:22.0871994+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.15, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.11.20.07.54.44/sensenet.contentrepository.7.7.18.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.18/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.18/sensenet.contentrepository.7.7.18.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-11-20T07:53:08.99+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.18"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.18/sensenet.contentrepository.7.7.18.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.20.json",
               "@type": "Package",
               "commitId": "7a696917-5542-4d24-8ba1-de522cf58788",
               "commitTimeStamp": "2020-12-14T10:32:02.8261272+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.16, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2020.12.14.10.31.31/sensenet.contentrepository.7.7.20.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.20/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.20/sensenet.contentrepository.7.7.20.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2020-12-14T10:29:19.46+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.20"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.20/sensenet.contentrepository.7.7.20.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.21.json",
               "@type": "Package",
               "commitId": "97ad3824-e3a7-4994-85a5-0c1da75386a8",
               "commitTimeStamp": "2021-01-25T12:38:44.7136027+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.17, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.01.25.12.38.22/sensenet.contentrepository.7.7.21.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.21/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.21/sensenet.contentrepository.7.7.21.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2021-01-25T12:35:54.94+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.21"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.21/sensenet.contentrepository.7.7.21.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.22.json",
               "@type": "Package",
               "commitId": "96a78518-fcae-46ce-a3d6-3c10b755fd8b",
               "commitTimeStamp": "2021-05-17T13:26:19.7764421+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.18, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.28/sensenet.contentrepository.7.7.22.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.22/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.22/sensenet.contentrepository.7.7.22.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2021-05-17T13:23:22.51+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.22"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.22/sensenet.contentrepository.7.7.22.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.23.json",
               "@type": "Package",
               "commitId": "fe81b03f-eedd-4694-8a77-532b42e6da62",
               "commitTimeStamp": "2021-05-17T13:26:48.5738248+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.19, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.12/sensenet.contentrepository.7.7.23.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.23/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.23/sensenet.contentrepository.7.7.23.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2021-05-17T13:23:32.463+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.23"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.23/sensenet.contentrepository.7.7.23.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.24.json",
               "@type": "Package",
               "commitId": "96a78518-fcae-46ce-a3d6-3c10b755fd8b",
               "commitTimeStamp": "2021-05-17T13:26:19.7764421+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.20, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.25.50/sensenet.contentrepository.7.7.24.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.24/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.24/sensenet.contentrepository.7.7.24.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2021-05-17T13:23:44.427+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.24"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.24/sensenet.contentrepository.7.7.24.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.25.json",
               "@type": "Package",
               "commitId": "635cb93f-2a55-4909-ac7e-aa803dd4b168",
               "commitTimeStamp": "2021-05-17T13:27:16.9806418+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.21, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.05.17.13.26.35/sensenet.contentrepository.7.7.25.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.25/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.25/sensenet.contentrepository.7.7.25.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2021-05-17T13:23:55.237+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.25"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.25/sensenet.contentrepository.7.7.25.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.26.json",
               "@type": "Package",
               "commitId": "0c2702dd-1e4b-4639-843d-d4be71264ee6",
               "commitTimeStamp": "2021-06-14T07:36:47.33227+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.22, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/sensenet.preview",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Preview",
                              "range": "[7.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.preview/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/sensenet.taskmanagement.core",
                              "@type": "PackageDependency",
                              "id": "SenseNet.TaskManagement.Core",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.taskmanagement.core/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.06.14.07.36.16/sensenet.contentrepository.7.7.26.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.26/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.26/sensenet.contentrepository.7.7.26.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2021-06-14T07:34:14.497+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.26"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.26/sensenet.contentrepository.7.7.26.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.27.json",
               "@type": "Package",
               "commitId": "f79a458d-0069-4602-911f-ca537cbe76c8",
               "commitTimeStamp": "2021-07-20T08:42:33.5009879+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.23, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.07.20.08.41.40/sensenet.contentrepository.7.7.27.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.27/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.27/sensenet.contentrepository.7.7.27.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2021-07-20T08:38:48.017+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.27"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.27/sensenet.contentrepository.7.7.27.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.28.json",
               "@type": "Package",
               "commitId": "00912766-2185-4637-91fb-6e8d8528140a",
               "commitTimeStamp": "2021-08-25T13:25:04.7018856+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.8, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.24, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2021.08.25.13.24.31/sensenet.contentrepository.7.7.28.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.28/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.28/sensenet.contentrepository.7.7.28.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2021-08-25T13:22:22.05+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.28"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.28/sensenet.contentrepository.7.7.28.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.31.json",
               "@type": "Package",
               "commitId": "361e3f5f-6469-44ae-8fc6-3b917ba55ae9",
               "commitTimeStamp": "2022-01-26T13:04:34.9896293+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.9, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.26, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/microsoft.aspnetcore.http.abstractions",
                              "@type": "PackageDependency",
                              "id": "Microsoft.AspNetCore.Http.Abstractions",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.aspnetcore.http.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/microsoft.extensions.caching.memory",
                              "@type": "PackageDependency",
                              "id": "Microsoft.Extensions.Caching.Memory",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.extensions.caching.memory/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.01.26.13.03.49/sensenet.contentrepository.7.7.31.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.31/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.31/sensenet.contentrepository.7.7.31.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2022-01-26T13:01:25.363+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.31"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.31/sensenet.contentrepository.7.7.31.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.32.json",
               "@type": "Package",
               "commitId": "7239c666-e606-4ae8-b37f-4482a77d135d",
               "commitTimeStamp": "2022-04-22T12:14:43.5522999+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.10, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.27, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/mailkit",
                              "@type": "PackageDependency",
                              "id": "MailKit",
                              "range": "[3.1.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/mailkit/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/microsoft.aspnetcore.http.abstractions",
                              "@type": "PackageDependency",
                              "id": "Microsoft.AspNetCore.Http.Abstractions",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.aspnetcore.http.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/microsoft.extensions.caching.memory",
                              "@type": "PackageDependency",
                              "id": "Microsoft.Extensions.Caching.Memory",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.extensions.caching.memory/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[11.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.04.22.12.12.47/sensenet.contentrepository.7.7.32.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.32/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.32/sensenet.contentrepository.7.7.32.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2022-04-22T12:07:58.817+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.32"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.32/sensenet.contentrepository.7.7.32.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.33.json",
               "@type": "Package",
               "commitId": "04262cf9-3b8a-4067-9d9b-74bf4ee0e71b",
               "commitTimeStamp": "2022-08-23T08:31:08.4262402+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.6, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.12, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.28, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/mailkit",
                              "@type": "PackageDependency",
                              "id": "MailKit",
                              "range": "[3.1.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/mailkit/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/microsoft.aspnetcore.http.abstractions",
                              "@type": "PackageDependency",
                              "id": "Microsoft.AspNetCore.Http.Abstractions",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.aspnetcore.http.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/microsoft.extensions.caching.memory",
                              "@type": "PackageDependency",
                              "id": "Microsoft.Extensions.Caching.Memory",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.extensions.caching.memory/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[13.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.4, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.7, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[4.5.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2022.08.23.08.30.07/sensenet.contentrepository.7.7.33.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[4.5.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.33/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.33/sensenet.contentrepository.7.7.33.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2022-08-23T08:27:18.94+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.33"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.33/sensenet.contentrepository.7.7.33.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.35.json",
               "@type": "Package",
               "commitId": "06626c0a-a7d5-4d38-8c04-4a2b4db0d35c",
               "commitTimeStamp": "2023-01-11T16:59:07.5275553+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,aniko,lajos,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.9, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.9, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.14, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.30, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/mailkit",
                              "@type": "PackageDependency",
                              "id": "MailKit",
                              "range": "[3.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/mailkit/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/microsoft.aspnetcore.http.abstractions",
                              "@type": "PackageDependency",
                              "id": "Microsoft.AspNetCore.Http.Abstractions",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.aspnetcore.http.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.7.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/microsoft.extensions.caching.memory",
                              "@type": "PackageDependency",
                              "id": "Microsoft.Extensions.Caching.Memory",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.extensions.caching.memory/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[13.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.1.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.9, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/net6.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[6.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": "net6.0"
                     },
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.9, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.9, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.14, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.30, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/mailkit",
                              "@type": "PackageDependency",
                              "id": "MailKit",
                              "range": "[3.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/mailkit/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/microsoft.aspnetcore.http.abstractions",
                              "@type": "PackageDependency",
                              "id": "Microsoft.AspNetCore.Http.Abstractions",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.aspnetcore.http.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.7.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/microsoft.extensions.caching.memory",
                              "@type": "PackageDependency",
                              "id": "Microsoft.Extensions.Caching.Memory",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.extensions.caching.memory/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[13.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.1.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.1.5, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.9, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.01.11.16.57.59/sensenet.contentrepository.7.7.35.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[6.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.35/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.35/sensenet.contentrepository.7.7.35.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2023-01-11T16:55:16.107+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.35"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.35/sensenet.contentrepository.7.7.35.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.36.json",
               "@type": "Package",
               "commitId": "fc6bff2c-12e1-454c-a728-606fda9f96e9",
               "commitTimeStamp": "2023-03-27T17:01:41.2921252+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,joe,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.10, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.10, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.15, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.31, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/mailkit",
                              "@type": "PackageDependency",
                              "id": "MailKit",
                              "range": "[3.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/mailkit/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/microsoft.aspnetcore.http.abstractions",
                              "@type": "PackageDependency",
                              "id": "Microsoft.AspNetCore.Http.Abstractions",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.aspnetcore.http.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.7.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/microsoft.extensions.caching.memory",
                              "@type": "PackageDependency",
                              "id": "Microsoft.Extensions.Caching.Memory",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.extensions.caching.memory/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[13.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.1.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.11, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/net6.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[6.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": "net6.0"
                     },
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.10, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.10, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.15, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.31, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/mailkit",
                              "@type": "PackageDependency",
                              "id": "MailKit",
                              "range": "[3.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/mailkit/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/microsoft.aspnetcore.http.abstractions",
                              "@type": "PackageDependency",
                              "id": "Microsoft.AspNetCore.Http.Abstractions",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.aspnetcore.http.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.7.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/microsoft.extensions.caching.memory",
                              "@type": "PackageDependency",
                              "id": "Microsoft.Extensions.Caching.Memory",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.extensions.caching.memory/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/newtonsoft.json",
                              "@type": "PackageDependency",
                              "id": "Newtonsoft.Json",
                              "range": "[13.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/newtonsoft.json/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.1.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.11, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/system.configuration.configurationmanager",
                              "@type": "PackageDependency",
                              "id": "System.Configuration.ConfigurationManager",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.configuration.configurationmanager/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.03.27.17.00.22/sensenet.contentrepository.7.7.36.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[6.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.36/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.36/sensenet.contentrepository.7.7.36.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2023-03-27T16:57:57.2+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.36"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.36/sensenet.contentrepository.7.7.36.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            },
            {
               "@id": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/7.7.37.json",
               "@type": "Package",
               "commitId": "f7743747-a4dc-4f91-a401-5f6353a25686",
               "commitTimeStamp": "2023-06-13T14:51:00.8216288+00:00",
               "catalogEntry": {
                  "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json",
                  "@type": "PackageDetails",
                  "authors": "kavics,joe,tusmester",
                  "dependencyGroups": [
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.10, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.11, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.15, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.32, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/googleauthenticator",
                              "@type": "PackageDependency",
                              "id": "GoogleAuthenticator",
                              "range": "[3.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/googleauthenticator/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/mailkit",
                              "@type": "PackageDependency",
                              "id": "MailKit",
                              "range": "[3.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/mailkit/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/microsoft.aspnetcore.http.abstractions",
                              "@type": "PackageDependency",
                              "id": "Microsoft.AspNetCore.Http.Abstractions",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.aspnetcore.http.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.7.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/microsoft.extensions.caching.memory",
                              "@type": "PackageDependency",
                              "id": "Microsoft.Extensions.Caching.Memory",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.extensions.caching.memory/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.1.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.11, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/skiasharp.nativeassets.linux",
                              "@type": "PackageDependency",
                              "id": "SkiaSharp.NativeAssets.Linux",
                              "range": "[2.88.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/skiasharp.nativeassets.linux/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/net6.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[7.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": "net6.0"
                     },
                     {
                        "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0",
                        "@type": "PackageDependencyGroup",
                        "dependencies": [
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/sensenet.abstractions",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Abstractions",
                              "range": "[1.0.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/sensenet.blobstorage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.BlobStorage",
                              "range": "[7.6.10, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.blobstorage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/sensenet.common",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Common",
                              "range": "[7.5.11, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.common/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/sensenet.search",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Search",
                              "range": "[2.4.15, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.search/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/sensenet.storage",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Storage",
                              "range": "[7.7.32, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.storage/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/googleauthenticator",
                              "@type": "PackageDependency",
                              "id": "GoogleAuthenticator",
                              "range": "[3.1.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/googleauthenticator/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/mailkit",
                              "@type": "PackageDependency",
                              "id": "MailKit",
                              "range": "[3.4.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/mailkit/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/microsoft.aspnetcore.http.abstractions",
                              "@type": "PackageDependency",
                              "id": "Microsoft.AspNetCore.Http.Abstractions",
                              "range": "[2.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.aspnetcore.http.abstractions/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/microsoft.csharp",
                              "@type": "PackageDependency",
                              "id": "Microsoft.CSharp",
                              "range": "[4.7.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.csharp/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/microsoft.extensions.caching.memory",
                              "@type": "PackageDependency",
                              "id": "Microsoft.Extensions.Caching.Memory",
                              "range": "[6.0.1, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/microsoft.extensions.caching.memory/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/nito.asyncex.coordination",
                              "@type": "PackageDependency",
                              "id": "Nito.AsyncEx.Coordination",
                              "range": "[5.1.2, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/nito.asyncex.coordination/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/sensenet.security",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Security",
                              "range": "[4.2.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.security/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/sensenet.tools",
                              "@type": "PackageDependency",
                              "id": "SenseNet.Tools",
                              "range": "[3.2.11, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.tools/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/skiasharp.nativeassets.linux",
                              "@type": "PackageDependency",
                              "id": "SkiaSharp.NativeAssets.Linux",
                              "range": "[2.88.3, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/skiasharp.nativeassets.linux/index.json"
                           },
                           {
                              "@id": "https://api.nuget.org/v3/catalog0/data/2023.06.13.14.49.56/sensenet.contentrepository.7.7.37.json#dependencygroup/.netstandard2.0/system.drawing.common",
                              "@type": "PackageDependency",
                              "id": "System.Drawing.Common",
                              "range": "[7.0.0, )",
                              "registration": "https://api.nuget.org/v3/registration5-gz-semver2/system.drawing.common/index.json"
                           }
                        ],
                        "targetFramework": ".NETStandard2.0"
                     }
                  ],
                  "description": "Content Repository layer for the sensenet platform.",
                  "iconUrl": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.37/icon",
                  "id": "SenseNet.ContentRepository",
                  "language": "",
                  "licenseExpression": "",
                  "licenseUrl": "https://github.com/SenseNet/sensenet/blob/master/LICENSE",
                  "listed": true,
                  "minClientVersion": "",
                  "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.37/sensenet.contentrepository.7.7.37.nupkg",
                  "projectUrl": "https://github.com/SenseNet/sensenet",
                  "published": "2023-06-13T14:34:48.103+00:00",
                  "requireLicenseAcceptance": false,
                  "summary": "",
                  "tags": [
                     "sensenet",
                     "csp",
                     "content",
                     "repository",
                     "storage"
                  ],
                  "title": "",
                  "version": "7.7.37"
               },
               "packageContent": "https://api.nuget.org/v3-flatcontainer/sensenet.contentrepository/7.7.37/sensenet.contentrepository.7.7.37.nupkg",
               "registration": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json"
            }
         ],
         "parent": "https://api.nuget.org/v3/registration5-gz-semver2/sensenet.contentrepository/index.json",
         "lower": "7.6.0",
         "upper": "7.7.37"
      }
   ],
   "@context": {
      "@vocab": "http://schema.nuget.org/schema#",
      "catalog": "http://schema.nuget.org/catalog#",
      "xsd": "http://www.w3.org/2001/XMLSchema#",
      "items": {
         "@id": "catalog:item",
         "@container": "@set"
      },
      "commitTimeStamp": {
         "@id": "catalog:commitTimeStamp",
         "@type": "xsd:dateTime"
      },
      "commitId": {
         "@id": "catalog:commitId"
      },
      "count": {
         "@id": "catalog:count"
      },
      "parent": {
         "@id": "catalog:parent",
         "@type": "@id"
      },
      "tags": {
         "@id": "tag",
         "@container": "@set"
      },
      "reasons": {
         "@container": "@set"
      },
      "packageTargetFrameworks": {
         "@id": "packageTargetFramework",
         "@container": "@set"
      },
      "dependencyGroups": {
         "@id": "dependencyGroup",
         "@container": "@set"
      },
      "dependencies": {
         "@id": "dependency",
         "@container": "@set"
      },
      "packageContent": {
         "@type": "@id"
      },
      "published": {
         "@type": "xsd:dateTime"
      },
      "registration": {
         "@type": "@id"
      }
   }
}
*/