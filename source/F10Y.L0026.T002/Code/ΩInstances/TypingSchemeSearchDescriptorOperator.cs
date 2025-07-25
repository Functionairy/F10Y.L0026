using System;


namespace F10Y.L0026.T002
{
    public class TypingSchemeSearchDescriptorOperator : ITypingSchemeSearchDescriptorOperator
    {
        #region Infrastructure

        public static ITypingSchemeSearchDescriptorOperator Instance { get; } = new TypingSchemeSearchDescriptorOperator();


        private TypingSchemeSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
