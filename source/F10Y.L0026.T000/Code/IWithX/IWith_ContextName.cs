using System;

using F10Y.T0009;


namespace F10Y.L0026.T000
{
    [WithXMarker]
    public interface IWith_ContextName :
        IHas_ContextName
    {
        new string Context_Name { get; set; }
    }
}
