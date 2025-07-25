using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a .NET version search using a target framework moniker.
    /// </summary>
    [DataTypeMarker]
    public class NetVersionSearchDescriptor : INetVersionSearchDescriptor,
        IWith_TargetFrameworkMoniker
    {
        public string TargetFrameworkMoniker { get; set; }
    }
}
