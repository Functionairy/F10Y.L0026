using System;

using F10Y.T0009;


namespace F10Y.L0026.T003
{
    [WithXMarker]
    public interface IWith_InstanceSetDescriptor :
        IHas_InstanceSetDescriptor
    {
        /// <inheritdoc cref="IInstanceSetDescriptor"/>
        new IInstanceSetDescriptor InstanceSetDescriptor { get; set; }
    }
}
