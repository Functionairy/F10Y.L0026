using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the NuGet package dependency of a project.
    /// </summary>
    [DataTypeMarker]
    public class DependencyDescriptor_NuGetPackage : IDependencyDescriptor,
        IEquatable<DependencyDescriptor_NuGetPackage>,
        IWith_PackageName,
        IWith_Version_AsString
    {
        public string PackageName { get; set; }
        public string Version { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DependencyDescriptor_NuGetPackage applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DependencyDescriptor_NuGetPackage other)
        {
            var output = true
                && this.PackageName == other.PackageName
                && this.Version == other.Version
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(
                this.PackageName,
                this.Version);

            return output;
        }

        public override string ToString()
        {
            var output = Instances.DependencyDescriptorOperator.To_String(this);
            return output;
        }
    }
}
