using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// The general instance set search descriptor, matching the general instance set descriptor.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor : InstanceSetSearchDescriptorBase,
        IWith_Descriptor
    {
        public IDescriptorSearchDescriptor DescriptorSearchDescriptor { get; set; }

        public IInstanceSetTypeSearchDescriptor InstanceSetTypeSearchDescriptor { get; set; }

        public IInstanceVarietySearchDescriptor InstanceVarietySearchDescriptor { get; set; }

        public IOrganizationSearchDescriptor OrganizationSearchDescriptor { get; set; }

        public IVisibilitySearchDescriptor VisibilitySearchDescriptor { get; set; }

        public INetVersionSearchDescriptor NetVersionSearchDescriptor { get; set; }

        public IDependencySetSearchDescriptor DependencySetSearchDescriptor { get; set; }

        public IApplicabilitySearchDescriptor ApplicabilitySearchDescriptor { get; set; }

        public IDomainSearchDescriptor DomainSearchDescriptor { get; set; }

        public IOpinionSearchDescriptor OpinionSearchDescriptor { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="T004.InstanceSetSearchDescriptor"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor
        {
            public JsonSerializationObject Descriptor { get; set; }

            public JsonSerializationObject DescriptorSearchDescriptor { get; set; }

            public JsonSerializationObject InstanceSetTypeSearchDescriptor { get; set; }

            public JsonSerializationObject VarietySearchDescriptor { get; set; }

            public JsonSerializationObject OrganizationSearchDescriptor { get; set; }

            public JsonSerializationObject VisibilitySearchDescriptor { get; set; }

            public JsonSerializationObject NetVersionSearchDescriptor { get; set; }

            public JsonSerializationObject DependencySetSearchDescriptor { get; set; }

            public JsonSerializationObject ApplicabilitySearchDescriptor { get; set; }

            public JsonSerializationObject DomainSearchDescriptor { get; set; }

            public JsonSerializationObject OpinionSearchDescriptor { get; set; }
        }
    }
}
