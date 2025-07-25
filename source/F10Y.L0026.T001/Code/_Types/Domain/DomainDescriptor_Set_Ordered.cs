using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the domain of an instance set by using an ordered set of domain values.
    /// The order can be seen to establish a hierarchy.
    /// <para>
    /// For example, to describe the ".NET Visual Studio Project XML file node names" domain, you could:
    /// have: [".NET Visual Studio Project XML File", "XML Node Names"].
    /// </para>
    /// </summary>
    [DataTypeMarker]
    public class DomainDescriptor_Set_Ordered : IDomainDescriptor,
        IEquatable<DomainDescriptor_Set_Ordered>,
        IWith_Domains
    {
        public string[] Domains { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DomainDescriptor_Set_Ordered applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DomainDescriptor_Set_Ordered other)
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
