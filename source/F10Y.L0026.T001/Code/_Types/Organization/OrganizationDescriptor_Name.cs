using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the organization of an object.
    /// </summary>
    [DataTypeMarker]
    public class OrganizationDescriptor_Name : IOrganizationDescriptor,
        IEquatable<OrganizationDescriptor_Name>,
        IWith_OrganizationName
    {
        public string Organization_Name { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is OrganizationDescriptor_Name applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(OrganizationDescriptor_Name other)
        {
            var output = true
                && this.Organization_Name == other.Organization_Name
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Organization_Name);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.OrganizationDescriptorOperator.To_String(this);
            return output;
        }
    }
}
