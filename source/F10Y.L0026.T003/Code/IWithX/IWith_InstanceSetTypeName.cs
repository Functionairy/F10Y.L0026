using System;

using F10Y.T0009;


namespace F10Y.L0026.T003
{
    [WithXMarker]
    public interface IWith_InstanceSetTypeName :
        IHas_InstanceSetTypeName
    {
        new string InstanceSetType_Name { get; set; }
    }
}
