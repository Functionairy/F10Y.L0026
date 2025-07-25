using System;


namespace F10Y.L0026.L002
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
