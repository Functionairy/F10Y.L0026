using System;

using F10Y.T0002;


namespace F10Y.L0026.T002
{
    [FunctionsMarker]
    public partial interface ITypingSchemeSearchDescriptorOperator
    {
        public TypingSchemeSearchDescriptor_Enumeration From(TypingScheme typingScheme)
        {
            var output = new TypingSchemeSearchDescriptor_Enumeration
            {
                TypingScheme = typingScheme,
            };

            return output;
        }
    }
}
