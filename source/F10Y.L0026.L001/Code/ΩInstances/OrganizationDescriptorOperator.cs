using System;


namespace F10Y.L0026.L001
{
    public class OrganizationDescriptorOperator : IOrganizationDescriptorOperator
    {
        #region Infrastructure

        public static IOrganizationDescriptorOperator Instance { get; } = new OrganizationDescriptorOperator();


        private OrganizationDescriptorOperator()
        {
        }

        #endregion
    }
}


namespace F10Y.L0026.L001.Retained
{
    public class OrganizationDescriptorOperator : IOrganizationDescriptorOperator
    {
        #region Infrastructure

        public static IOrganizationDescriptorOperator Instance { get; } = new OrganizationDescriptorOperator();


        private OrganizationDescriptorOperator()
        {
        }

        #endregion
    }
}