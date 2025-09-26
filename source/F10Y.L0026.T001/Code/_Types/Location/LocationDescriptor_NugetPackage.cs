using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    [DataTypeMarker]
    public class LocationDescriptor_NugetPackage : ILocationDescriptor,
        IEquatable<LocationDescriptor_NugetPackage>,
        IWith_PackageName,
        IWith_Version_AsString
    {
        public string PackageName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use a string since Nuget packges can have crazy version names.
        /// </remarks>
        public string Version { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is LocationDescriptor_NugetPackage applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(LocationDescriptor_NugetPackage other)
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
            var output = Instances.LocationDescriptorOperator.To_String(this);
            return output;
        }
    }
}
