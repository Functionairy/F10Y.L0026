using System;

using F10Y.T0009;


namespace F10Y.L0026.T003
{
    [WithXMarker]
    public interface IWith_InstanceVarietyName :
        IHas_InstanceVarietyName
    {
        new string InstanceVariety_Name { get; set; }
    }
}
