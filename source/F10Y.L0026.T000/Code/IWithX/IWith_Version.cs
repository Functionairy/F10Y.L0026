using System;

using F10Y.T0009;


namespace F10Y.L0026.T000.N001
{
    /// <summary>
    /// A <see cref="string"/>-based version property.
    /// </summary>
    [WithXMarker]
    public interface IWith_Version :
        IHas_Version
    {
        new string Version { get; set; }
    }
}
