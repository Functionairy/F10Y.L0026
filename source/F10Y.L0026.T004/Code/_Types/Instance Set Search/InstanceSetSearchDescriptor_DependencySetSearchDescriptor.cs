using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// Allow searching for an instance set based on a dependency set search descriptor.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_DependencySetSearchDescriptor : IInstanceSetSearchDescriptor,
        IWith_Descriptor
    {
        public IDescriptor Descriptor { get; set; }

        public bool Value_IfMissingDescriptor { get; set; }

        public IDependencySetSearchDescriptor DependencySetSearchDescriptor { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="T004.InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor_DependencySetSearchDescriptor
        {
            public JsonSerializationObject Descriptor { get; set; }

            public bool Value_IfMissingDescriptor { get; set; }

            public JsonSerializationObject DependencySetSearchDescriptor { get; set; }
        }
    }
}
