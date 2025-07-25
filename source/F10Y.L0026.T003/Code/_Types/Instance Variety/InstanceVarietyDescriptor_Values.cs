using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// A structured instance variety descriptor for values, following the values ontology of:
    /// <list type="bullet">
    /// <item>Naming (absolute vs. contextual)</item>
    /// <item>Implementation (direct, vs. derived)</item>
    /// <item>Typing (system-typed vs. strongly-typed)</item>
    /// </list>
    /// </summary>
    [DataTypeMarker]
    public class InstanceVarietyDescriptor_Values : IInstanceVarietyDescriptor,
        IEquatable<InstanceVarietyDescriptor_Values>
    {
        public INamingSchemeDescriptor NamingScheme { get; set; }
        public IImplementationSchemeDescriptor ImplementationScheme { get; set; }
        public ITypingSchemeDescriptor TypingScheme { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceVarietyDescriptor_Values applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceVarietyDescriptor_Values other)
        {
            var namingScheme = Object.Equals(this.NamingScheme, other.NamingScheme);
            var implementationScheme = Object.Equals(this.ImplementationScheme, other.ImplementationScheme);
            var typingScheme = Object.Equals(this.TypingScheme, other.TypingScheme);

            var output = true
                && namingScheme
                && implementationScheme
                && typingScheme
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(
                Instances.ArrayOperator.From<object>(
                    this.NamingScheme,
                    this.ImplementationScheme,
                    this.TypingScheme
                    )
                );

            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class InstanceVarietyDescriptor_Values
        {
            public JsonSerializationObject NamingScheme { get; set; }

            public JsonSerializationObject ImplementationScheme { get; set; }

            public JsonSerializationObject TypingScheme { get; set; }
        }
    }
}
