using System;


namespace F10Y.L0026.T002
{
    public class DomainSearchDescriptorOperator : IDomainSearchDescriptorOperator
    {
        #region Infrastructure

        public static IDomainSearchDescriptorOperator Instance { get; } = new DomainSearchDescriptorOperator();


        private DomainSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
