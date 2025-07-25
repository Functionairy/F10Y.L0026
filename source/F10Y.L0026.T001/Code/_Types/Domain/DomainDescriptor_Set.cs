using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the domain of an instance set by using a set of domain values.
    /// The set can be interpretted as ordered or unordered, which is useful for synonym domains.
    /// <para>
    /// For example, to describe the ".NET" or "Visual Studio" domains, you could:
    /// have: [".NET", "Visual Studio"].
    /// </para>
    /// </summary>
    [DataTypeMarker]
    public class DomainDescriptor_Set : IDomainDescriptor,
        IEquatable<DomainDescriptor_Set>,
        IWith_Domains
    {
        public string[] Domains { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DomainDescriptor_Set applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DomainDescriptor_Set other)
        {
            var output = true
                && Instances.ArrayOperator.Are_Equal(
                    this.Domains,
                    other.Domains);
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(this.Domains);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.DomainDescriptorOperator.To_String(this);
            return output;
        }
    }
}
