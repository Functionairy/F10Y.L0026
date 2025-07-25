using System;


namespace F10Y.L0026.L001
{
    public class ImplementationSchemeDescriptorOperator : IImplementationSchemeDescriptorOperator
    {
        #region Infrastructure

        public static IImplementationSchemeDescriptorOperator Instance { get; } = new ImplementationSchemeDescriptorOperator();


        private ImplementationSchemeDescriptorOperator()
        {
        }

        #endregion
    }
}
