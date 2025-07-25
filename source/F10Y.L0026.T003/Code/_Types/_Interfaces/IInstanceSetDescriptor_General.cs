using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Additions for a general instance set descriptor.
    /// </summary>
    [DataTypeMarker]
    public interface IInstanceSetDescriptor_General :
        IHas_ApplicabilityDescriptor,
        IHas_DependencySetDescriptor,
        IHas_DomainDescriptor,
        IHas_InstanceVarietyDescriptor,
        IHas_OpinionDescriptor,
        IHas_OrganizationDescriptor,
        IHas_NetVersionDescriptor,
        IHas_VisibilityDescriptor
    {
        /// <summary>
        /// Describes the varieties of a instances within the set.
        /// </summary>
        new IInstanceVarietyDescriptor InstanceVarietyDescriptor { get; }

        /// <summary>
        /// Describes the organzation to which the instances set belongs.
        /// </summary>
        new IOrganizationDescriptor OrganizationDescriptor { get; }

        /// <summary>
        /// Describes the visibility of the instances set.
        /// </summary>
        new IVisibilityDescriptor VisibilityDescriptor { get; }

        /// <summary>
        /// Describes the .NET version of the instances set.
        /// </summary>
        new INetVersionDescriptor NetVersionDescriptor { get; }

        /// <summary>
        /// Describes the dependencies set of the instance set.
        /// </summary>
        new IDependencySetDescriptor DependencySetDescriptor { get; }

        /// <summary>
        /// Describes the applicability of the instance set.
        /// </summary>
        new IApplicabilityDescriptor ApplicabilityDescriptor { get; }

        /// <summary>
        /// Describes the domain of the instance set.
        /// </summary>
        new IDomainDescriptor DomainDescriptor { get; }

        /// <summary>
        /// Describes the opinion of the instance set.
        /// </summary>
        new IOpinionDescriptor OpinionDescriptor { get; }
    }
}