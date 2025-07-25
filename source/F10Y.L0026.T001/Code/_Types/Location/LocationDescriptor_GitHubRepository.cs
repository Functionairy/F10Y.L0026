using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    [DataTypeMarker]
    public class LocationDescriptor_GitHubRepository : ILocationDescriptor,
        IEquatable<LocationDescriptor_GitHubRepository>,
        IWith_RepositoryUrl
    {
        public string RepositoryUrl { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is LocationDescriptor_GitHubRepository applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(LocationDescriptor_GitHubRepository other)
        {
            var output = true
                && this.RepositoryUrl == other.RepositoryUrl
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.RepositoryUrl);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.LocationDescriptorOperator.To_String(this);
            return output;
        }
    }
}
