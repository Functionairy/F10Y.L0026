using System;

using F10Y.T0003;


namespace F10Y.L0026.L001
{
    [ValuesMarker]
    public partial interface IPredicateProviderSuites
    {
        #region Organization Descriptor

        public For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationDescriptor> For_OrganizationDescriptor => new()
        {
            Type = Instances.TypeOperator.Get_Type<OrganizationDescriptor_Name>(),
            Get_PredicateProvider_Synchronous = Instances.TypeOperator.Get_Operator_WithInputTypeVerified(
                Instances.OrganizationDescriptorOperator.Get_PredicateFor,
                Instances.TypeSpecifiers.For_OrganizationDescriptor),
            //Predicate_Asynchronous = ,
        };

        #endregion
    }
}
