using System;

using F10Y.T0009;


namespace F10Y.L0026.T003
{
    [WithXMarker]
    public interface IWith_InstanceVarietyNames :
        IHas_InstanceVarietyNames
    {
        new string[] InstanceVariety_Names { get; set; }
    }
}
