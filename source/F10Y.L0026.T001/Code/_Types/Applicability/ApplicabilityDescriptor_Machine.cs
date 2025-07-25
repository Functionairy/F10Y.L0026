using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the applicability of an instances set as being applicable to a specific machine.
    /// </summary>
    [DataTypeMarker]
    public class ApplicabilityDescriptor_Machine : IApplicabilityDescriptor,
        IEquatable<ApplicabilityDescriptor_Machine>,
        IHas_Applicability
    {
        public string Machine_Name { get; set; }

        string IHas_Applicability.Applicability => this.Machine_Name;


        public override bool Equals(object obj)
        {
            var output = obj is ApplicabilityDescriptor_Machine applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(ApplicabilityDescriptor_Machine other)
        {
            var output = true
                && this.Machine_Name == other.Machine_Name
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Machine_Name);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.ApplicabilityDescriptorOperator.To_String(this);
            return output;
        }
    }
}
