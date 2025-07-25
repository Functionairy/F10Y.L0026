using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    using TypingScheme_ForDocumentation = TypingScheme;


    /// <summary>
    /// A typing scheme based on the <see cref="TypingScheme_ForDocumentation"/> enumeration.
    /// </summary>
    [DataTypeMarker]
    public class TypingSchemeSearchDescriptor_Enumeration : ITypingSchemeSearchDescriptor,
        IWith_TypingScheme
    {
        public TypingScheme TypingScheme { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class TypingSchemeSearchDescriptor_Enumeration
        {
            public string TypingScheme { get; set; }
        }
    }
}
