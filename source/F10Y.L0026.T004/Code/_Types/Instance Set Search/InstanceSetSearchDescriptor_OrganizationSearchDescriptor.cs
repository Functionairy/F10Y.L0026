using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// Allow searching for an instance set based on organization search descriptor.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_OrganizationSearchDescriptor : IInstanceSetSearchDescriptor,
        IWith_Descriptor
    {
        public IDescriptor Descriptor { get; set; }

        public bool Value_IfMissingDescriptor { get; set; }

        public IOrganizationSearchDescriptor OrganizationSearchDescriptor { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="T004.InstanceSetSearchDescriptor_OrganizationSearchDescriptor"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor_OrganizationSearchDescriptor
        {
            public JsonSerializationObject Descriptor { get; set; }

            public bool Value_IfMissingDescriptor { get; set; }

            public JsonSerializationObject OrganizationSearchDescriptor { get; set; }
        }
    }
}
