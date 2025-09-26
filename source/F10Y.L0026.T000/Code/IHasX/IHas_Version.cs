using System;

using F10Y.T0009;


namespace F10Y.L0026.T000.N000
{
    /// <summary>
    /// A <see cref="System.Version"/>-based version property.
    /// </summary>
    /// <remarks>
    /// For a <see cref="string"/>-based version property, see <see cref="N001.IHas_Version"/>.
    /// </remarks>
    [HasXMarker]
    public interface IHas_Version
    {
        Version Version { get; }
    }
}

namespace F10Y.L0026.T000.N001
{
    /// <summary>
    /// A <see cref="string"/>-based version property.
    /// </summary>
    /// <remarks>
    /// For a <see cref="Version"/>-based version property, see <see cref="N000.IHas_Version"/>.
    /// </remarks>
    [HasXMarker]
    public interface IHas_Version
    {
        string Version { get; }
    }
}
