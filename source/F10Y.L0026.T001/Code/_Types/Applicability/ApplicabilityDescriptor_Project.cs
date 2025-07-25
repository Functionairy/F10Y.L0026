using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the applicability of an instances as being applicable to a specific project.
    /// </summary>
    [DataTypeMarker]
    public class ApplicabilityDescriptor_Project : IApplicabilityDescriptor,
        IEquatable<ApplicabilityDescriptor_Project>,
        IHas_Applicability
    {
        public string Project_Name { get; set; }

        string IHas_Applicability.Applicability => this.Project_Name;


        public override bool Equals(object obj)
        {
            var output = obj is ApplicabilityDescriptor_Project applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(ApplicabilityDescriptor_Project other)
        {
            var output = true
                && this.Project_Name == other.Project_Name
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Project_Name);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.ApplicabilityDescriptorOperator.To_String(this);
            return output;
        }
    }
}
