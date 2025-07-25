using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0003;


namespace F10Y.L0026.L001
{
    [ValuesMarker]
    public partial interface IPredicateProviderSuiteSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IPredicateProviderSuites _PredicateProviderOperationHandlerSuites => Instances.PredicateProviderSuites;

#pragma warning restore IDE1006 // Naming Styles


        #region Organization Descriptors

        public For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationDescriptor>[] For_OrganizationDescriptors => new[]
        {
            _PredicateProviderOperationHandlerSuites.For_OrganizationDescriptor,
        };

        private static readonly Lazy<Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationDescriptor>>> For_OrganizationDescriptors_ByType_Lazy = new(() =>
            Instances.PredicateProviderSuiteSets.For_OrganizationDescriptors
                .ToDictionary(x => x.Type)
        );

        public Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationDescriptor>> For_OrganizationDescriptors_ByType => For_OrganizationDescriptors_ByType_Lazy.Value;

        #endregion
    }
}
