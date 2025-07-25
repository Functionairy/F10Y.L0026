using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface ITypingSchemeDescriptorOperator
    {
        public TypingSchemeDescriptor_Enumeration From(TypingScheme typingScheme)
        {
            var output = new TypingSchemeDescriptor_Enumeration
            {
                TypingScheme = typingScheme
            };

            return output;
        }

        public string To_String(TypingSchemeDescriptor_Enumeration typingSchemeDescriptor)
        {
            var typingScheme = Instances.EnumerationOperator.Get_StringRepresentation(typingSchemeDescriptor.TypingScheme);

            var output = $"Typing scheme: {typingScheme}";
            return output;
        }
    }
}
