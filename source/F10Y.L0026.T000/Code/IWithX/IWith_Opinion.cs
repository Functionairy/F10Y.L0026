using System;

using F10Y.T0009;


namespace F10Y.L0026.T000
{
    [WithXMarker]
    public interface IWith_Opinion :
        IHas_Opinion
    {
        new string Opinion { get; set; }
    }
}
