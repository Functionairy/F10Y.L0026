using System;


namespace F10Y.L0026.T001
{
    public class DomainDescriptorOperator : IDomainDescriptorOperator
    {
        #region Infrastructure

        public static IDomainDescriptorOperator Instance { get; } = new DomainDescriptorOperator();


        private DomainDescriptorOperator()
        {
        }

        #endregion
    }
}
