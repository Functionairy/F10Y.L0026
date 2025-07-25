using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a search for a NuGet package dependency of an instance set.
    /// </summary>
    [DataTypeMarker]
    public class DependencySearchDescriptor_NuGetPackage : IDependencySearchDescriptor, /* IEquatable<DependencyDescriptor_NugetPackage>,*/
        IWith_PackageName,
        IWith_Version_AsString
    {
        public string PackageName { get; set; }
        public string Version { get; set; }
    }
}
