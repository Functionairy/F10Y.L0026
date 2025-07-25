using System;


namespace F10Y.L0026.T001
{
    public class NamingSchemeDescriptorOperator : INamingSchemeDescriptorOperator
    {
        #region Infrastructure

        public static INamingSchemeDescriptorOperator Instance { get; } = new NamingSchemeDescriptorOperator();


        private NamingSchemeDescriptorOperator()
        {
        }

        #endregion
    }
}
