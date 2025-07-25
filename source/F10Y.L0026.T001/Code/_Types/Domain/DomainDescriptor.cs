using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the domain of an instance set by using a domain value.
    /// </summary>
    [DataTypeMarker]
    public class DomainDescriptor : IDomainDescriptor,
        IEquatable<DomainDescriptor>,
        IWith_Domain
    {
        public string Domain { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DomainDescriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DomainDescriptor other)
        {
            var output = true
                && this.Domain == other.Domain
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Domain);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.DomainDescriptorOperator.To_String(this);
            return output;
        }
    }
}
