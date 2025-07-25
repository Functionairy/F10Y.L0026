using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the applicability of an instances set by using an applicability value.
    /// </summary>
    [DataTypeMarker]
    public class ApplicabilityDescriptor : IApplicabilityDescriptor,
        IEquatable<ApplicabilityDescriptor>,
        IHas_Applicability
    {
        public string Applicability { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is ApplicabilityDescriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(ApplicabilityDescriptor other)
        {
            var output = true
                && this.Applicability == other.Applicability
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Applicability);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.ApplicabilityDescriptorOperator.To_String(this);
            return output;
        }
    }
}
