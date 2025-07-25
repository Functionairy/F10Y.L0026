using System;

using F10Y.T0003;


namespace F10Y.L0026.L004
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers
    {
        #region Instance Set Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor> For_InstanceSetSearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_Aggregate> For_InstanceSetSearchDescriptor_Aggregate =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_Aggregate>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, N001_InstanceSetSearchDescriptor_Aggregate> For_InstanceSetSearchDescriptor_Aggregate_N001 =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, N001_InstanceSetSearchDescriptor_Aggregate>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, N002_InstanceSetSearchDescriptor_Aggregate> For_InstanceSetSearchDescriptor_Aggregate_N002 =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, N002_InstanceSetSearchDescriptor_Aggregate>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor> For_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_DependencySetSearchDescriptor> For_InstanceSetSearchDescriptor_DependencySetSearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_DependencySetSearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_DomainSearchDescriptor> For_InstanceSetSearchDescriptor_DomainSearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_DomainSearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_InstanceSetDescriptor> For_InstanceSetSearchDescriptor_InstanceSetDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_InstanceSetDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor> For_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor> For_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_NetVersionSearchDescriptor> For_InstanceSetSearchDescriptor_NetVersionSearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_NetVersionSearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_OpinionSearchDescriptor> For_InstanceSetSearchDescriptor_OpinionSearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_OpinionSearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_OrganizationName> For_InstanceSetSearchDescriptor_OrganizationName =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_OrganizationName>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_OrganizationSearchDescriptor> For_InstanceSetSearchDescriptor_OrganizationSearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_OrganizationSearchDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_VisibilitySearchDescriptor> For_InstanceSetSearchDescriptor_VisibilitySearchDescriptor =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetSearchDescriptor, InstanceSetSearchDescriptor_VisibilitySearchDescriptor>.Instance;

        #endregion

        #region Instance Set Type Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetTypeSearchDescriptor, InstanceSetTypeSearchDescriptor_Name> For_InstanceSetTypeSearchDescriptor_Name =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetTypeSearchDescriptor, InstanceSetTypeSearchDescriptor_Name>.Instance;

        #endregion

        #region Instance Variety Search Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IInstanceVarietySearchDescriptor, InstanceVarietySearchDescriptor_Name> For_InstanceVarietySearchDescriptor_Name =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceVarietySearchDescriptor, InstanceVarietySearchDescriptor_Name>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceVarietySearchDescriptor, InstanceVarietySearchDescriptor_Values> For_InstanceVarietySearchDescriptor_Values =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceVarietySearchDescriptor, InstanceVarietySearchDescriptor_Values>.Instance;

        #endregion
    }
}
