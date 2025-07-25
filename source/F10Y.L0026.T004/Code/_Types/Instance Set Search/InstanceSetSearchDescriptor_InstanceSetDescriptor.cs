using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// The general instance set search descriptor, build around a general instance set descriptor instance.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_InstanceSetDescriptor : InstanceSetSearchDescriptorBase
    {
        public InstanceSetDescriptor InstanceSetDescriptor { get; set; }
    }
}
