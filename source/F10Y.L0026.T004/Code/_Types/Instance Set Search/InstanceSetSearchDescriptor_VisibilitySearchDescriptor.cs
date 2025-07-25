using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// Allow searching for an instance set based on visibility search descriptor.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_VisibilitySearchDescriptor : IInstanceSetSearchDescriptor,
        IWith_Descriptor
    {
        public IDescriptor Descriptor { get; set; }

        public bool Value_IfMissingDescriptor { get; set; }

        public IVisibilitySearchDescriptor VisibilitySearchDescriptor { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="T004.InstanceSetSearchDescriptor_VisibilitySearchDescriptor"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor_VisibilitySearchDescriptor
        {
            public JsonSerializationObject Descriptor { get; set; }

            public bool Value_IfMissingDescriptor { get; set; }

            public JsonSerializationObject VisibilitySearchDescriptor { get; set; }
        }
    }
}
