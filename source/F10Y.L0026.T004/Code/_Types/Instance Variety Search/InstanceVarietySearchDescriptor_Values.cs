using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// A structured instance variety search descriptor for values, following the values ontology of:
    /// <list type="bullet">
    /// <item>Naming (absolute vs. contextual)</item>
    /// <item>Implementation (direct, vs. derived)</item>
    /// <item>Typing (system-typed vs. strongly-typed)</item>
    /// </list>
    /// </summary>
    [DataTypeMarker]
    public class InstanceVarietySearchDescriptor_Values : IInstanceVarietySearchDescriptor
    {
        public INamingSchemeSearchDescriptor NamingScheme { get; set; }
        public IImplementationSchemeSearchDescriptor ImplementationScheme { get; set; }
        public ITypingSchemeSearchDescriptor TypingScheme { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class InstanceVarietySearchDescriptor_Values
        {
            public JsonSerializationObject NamingScheme { get; set; }

            public JsonSerializationObject ImplementationScheme { get; set; }

            public JsonSerializationObject TypingScheme { get; set; }
        }
    }
}
