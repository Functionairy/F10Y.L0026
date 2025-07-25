using System;


namespace F10Y.L0026.T001
{
    public class TypingSchemeDescriptorOperator : ITypingSchemeDescriptorOperator
    {
        #region Infrastructure

        public static ITypingSchemeDescriptorOperator Instance { get; } = new TypingSchemeDescriptorOperator();


        private TypingSchemeDescriptorOperator()
        {
        }

        #endregion
    }
}
