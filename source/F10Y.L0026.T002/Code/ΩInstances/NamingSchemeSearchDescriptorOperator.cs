using System;


namespace F10Y.L0026.T002
{
    public class NamingSchemeSearchDescriptorOperator : INamingSchemeSearchDescriptorOperator
    {
        #region Infrastructure

        public static INamingSchemeSearchDescriptorOperator Instance { get; } = new NamingSchemeSearchDescriptorOperator();


        private NamingSchemeSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
