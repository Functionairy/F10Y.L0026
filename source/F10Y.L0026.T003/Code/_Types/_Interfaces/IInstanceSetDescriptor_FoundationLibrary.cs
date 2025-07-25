using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Additions for a catch-all library instance set descriptor.
    /// </summary>
    [DataTypeMarker]
    public interface IInstanceSetDescriptor_FoundationLibrary :
        IHas_NetVersionDescriptor,
        IHas_OrganizationDescriptor
        //
        //IHasApplicabilityDescriptor, applicability is always ALL.
        //IHasDependencySetDescriptor, dependency set is always FOUNDATION LIBRARIES ONLY.
        //IHasDomainDescriptor, domain is always ALL.
        //IHasInstanceVarietyDescriptor, instance varieties is always ALL.
        //IHasOpinionDescriptor, opinions is always ALL.
        //IHasVisibilityDescriptor, visibility is always PUBLIC.
    {
        // Empty.
    }
}