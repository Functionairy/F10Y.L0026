using System;

using F10Y.T0009;


namespace F10Y.L0026.T000.N000
{
    /// <inheritdoc cref="IHas_Version"/>
    [WithXMarker]
    public interface IWith_Version :
        IHas_Version
    {
        new Version Version { get; set; }
    }
}


namespace F10Y.L0026.T000.N001
{
    /// <inheritdoc cref="IHas_Version"/>
    [WithXMarker]
    public interface IWith_Version :
        IHas_Version
    {
        new string Version { get; set; }
    }
}