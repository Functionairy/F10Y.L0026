using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    using ImplementationScheme_ForDocumentation = ImplementationScheme;


    /// <summary>
    /// An implementation scheme based on the <see cref="ImplementationScheme_ForDocumentation"/> enumeration.
    /// </summary>
    [DataTypeMarker]
    public class ImplementationSchemeDescriptor_Enumeration : IImplementationSchemeDescriptor,
        IEquatable<ImplementationSchemeDescriptor_Enumeration>,
        IHas_ImplementationScheme
    {
        public ImplementationScheme ImplementationScheme { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is ImplementationSchemeDescriptor_Enumeration applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(ImplementationSchemeDescriptor_Enumeration other)
        {
            var output = true
                && this.ImplementationScheme == other.ImplementationScheme
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.ImplementationScheme);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.ImplementationSchemeDescriptorOperator.To_String(this);
            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class ImplementationSchemeDescriptor_Enumeration
        {
            public string ImplementationScheme { get; set; }
        }
    }
}
