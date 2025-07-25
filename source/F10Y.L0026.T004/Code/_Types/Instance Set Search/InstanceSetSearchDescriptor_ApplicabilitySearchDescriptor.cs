using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// Allow searching for an instance set based on domain search descriptor.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor : IInstanceSetSearchDescriptor,
        IWith_Descriptor
    {
        public IDescriptor Descriptor { get; set; }

        public bool Value_IfMissingDescriptor { get; set; }

        public IApplicabilitySearchDescriptor ApplicabilitySearchDescriptor { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="T004.InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor
        {
            public JsonSerializationObject Descriptor { get; set; }

            public bool Value_IfMissingDescriptor { get; set; }

            public JsonSerializationObject ApplicabilitySearchDescriptor { get; set; }
        }
    }
}
