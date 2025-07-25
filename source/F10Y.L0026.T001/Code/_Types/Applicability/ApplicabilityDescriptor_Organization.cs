using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the applicability of an instances as being applicable to a specific organization.
    /// </summary>
    [DataTypeMarker]
    public class ApplicabilityDescriptor_Organization : IApplicabilityDescriptor,
        IEquatable<ApplicabilityDescriptor_Organization>,
        IHas_Applicability
    {
        public string Organization_Name { get; set; }

        string IHas_Applicability.Applicability => this.Organization_Name;


        public override bool Equals(object obj)
        {
            var output = obj is ApplicabilityDescriptor_Organization applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(ApplicabilityDescriptor_Organization other)
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
            var output = Instances.ApplicabilityDescriptorOperator.To_String(this);
            return output;
        }
    }
}
