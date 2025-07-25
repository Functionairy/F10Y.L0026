using System;

using F10Y.T0009;


namespace F10Y.L0026.T003
{
    [WithXMarker]
    public interface IWith_InstanceSetTypeDescriptor :
        IHas_InstanceSetTypeDescriptor
    {
        new IInstanceSetTypeDescriptor InstanceSetTypeDescriptor { get; set; }
    }
}
