using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// Allow searching for an instance set based on opinion search descriptor.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_NetVersionSearchDescriptor : IInstanceSetSearchDescriptor,
        IWith_Descriptor
    {
        public IDescriptor Descriptor { get; set; }

        public bool Value_IfMissingDescriptor { get; set; }

        public INetVersionSearchDescriptor NetVersionSearchDescriptor { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="T004.InstanceSetSearchDescriptor_NetVersionSearchDescriptor"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor_NetVersionSearchDescriptor
        {
            public JsonSerializationObject Descriptor { get; set; }

            public bool Value_IfMissingDescriptor { get; set; }

            public JsonSerializationObject NetVersionSearchDescriptor { get; set; }
        }
    }
}
