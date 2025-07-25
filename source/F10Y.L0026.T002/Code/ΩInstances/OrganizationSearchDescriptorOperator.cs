using System;


namespace F10Y.L0026.T002
{
    public class OrganizationSearchDescriptorOperator : IOrganizationSearchDescriptorOperator
    {
        #region Infrastructure

        public static IOrganizationSearchDescriptorOperator Instance { get; } = new OrganizationSearchDescriptorOperator();


        private OrganizationSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
