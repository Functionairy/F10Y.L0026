using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// Allow searching for an instance set based on organization name.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_OrganizationName : IInstanceSetSearchDescriptor
    {
        public IDescriptor Descriptor { get; set; }

        public bool Value_IfMissingDescriptor { get; set; }

        public string Organization_Name { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor_OrganizationName
        {
            public Descriptor Descriptor { get; set; }

            public bool Value_IfMissingDescriptor { get; set; }

            public string Organization_Name { get; set; }
        }
    }
}
