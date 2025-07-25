using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Additions for a catch-all library instance set descriptor.
    /// </summary>
    [DataTypeMarker]
    public interface IInstanceSetDescriptor_CatchAllLibrary :
        IHas_NetVersionDescriptor,
        IHas_OrganizationDescriptor,
        IHas_VisibilityDescriptor
        //
        //IHasApplicabilityDescriptor, applicability is always ALL.
        //IHasDependencySetDescriptor, dependency set is always UNCONSTRAINED.
        //IHasDomainDescriptor, domain is always ALL.
        //IHasInstanceVarietyDescriptor, instance varieties is always ALL.
        //IHasOpinionDescriptor, opinions is always ALL.
    {
        // Empty.
    }
}