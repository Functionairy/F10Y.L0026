using System;


namespace F10Y.L0026.T002
{
    public class ImplementationSchemeSearchDescriptorOperator : IImplementationSchemeSearchDescriptorOperator
    {
        #region Infrastructure

        public static IImplementationSchemeSearchDescriptorOperator Instance { get; } = new ImplementationSchemeSearchDescriptorOperator();


        private ImplementationSchemeSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
