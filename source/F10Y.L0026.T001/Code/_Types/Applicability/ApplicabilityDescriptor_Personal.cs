using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the applicability of an instances as being applicable to a specific person.
    /// </summary>
    [DataTypeMarker]
    public class ApplicabilityDescriptor_Personal : IApplicabilityDescriptor,
        IEquatable<ApplicabilityDescriptor_Personal>,
        IHas_Applicability
    {
        public string Person_Name { get; set; }

        string IHas_Applicability.Applicability => this.Person_Name;


        public override bool Equals(object obj)
        {
            var output = obj is ApplicabilityDescriptor_Personal applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(ApplicabilityDescriptor_Personal other)
        {
            var output = true
                && this.Person_Name == other.Person_Name
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Person_Name);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.ApplicabilityDescriptorOperator.To_String(this);
            return output;
        }
    }
}
