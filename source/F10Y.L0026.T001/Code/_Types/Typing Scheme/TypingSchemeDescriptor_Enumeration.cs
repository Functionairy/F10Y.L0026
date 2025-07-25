using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    using TypingSchem_ForDocumentation = TypingScheme;


    /// <summary>
    /// A typing scheme based on the <see cref="TypingSchem_ForDocumentation"/> enumeration.
    /// </summary>
    [DataTypeMarker]
    public class TypingSchemeDescriptor_Enumeration : ITypingSchemeDescriptor,
        IEquatable<TypingSchemeDescriptor_Enumeration>,
        IWith_TypingScheme
    {
        public TypingScheme TypingScheme { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is TypingSchemeDescriptor_Enumeration applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(TypingSchemeDescriptor_Enumeration other)
        {
            var output = true
                && this.TypingScheme == other.TypingScheme
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.TypingScheme);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.TypingSchemeDescriptorOperator.To_String(this);
            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class TypingSchemeDescriptor_Enumeration
        {
            public string TypingScheme { get; set; }
        }
    }
}
