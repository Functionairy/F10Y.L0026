using System;

using F10Y.T0009;


namespace F10Y.L0026.T000
{
    [WithXMarker]
    public interface IWith_PackageName :
        IHas_PackageName
    {
        new string PackageName { get; set; }
    }
}
