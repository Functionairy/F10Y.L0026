using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Indicates that an instances set uses the latest version of .NET (as opposed to a specific version).
    /// </summary>
    /// <remarks>
    /// Implements <see cref="IHas_TargetFrameworkMoniker"/> and returns <see cref="L0008.Z000.ITargetFrameworkMonikers.LATEST"/>.
    /// </remarks>
    [DataTypeMarker]
    public class NetVersionDescriptor_Latest : INetVersionDescriptor,
        IHas_TargetFrameworkMoniker
    {
        #region Static

        public static NetVersionDescriptor_Latest Instance { get; } = new();

        #endregion


        string IHas_TargetFrameworkMoniker.TargetFrameworkMoniker =>
            Instances.TargetFrameworkMonikers.LATEST;


        /// <summary>
        /// Singleton.
        /// </summary>
        private NetVersionDescriptor_Latest()
        {
            // Do nothing.
        }

        public override string ToString()
        {
            var output = Instances.NetVersionDescriptorOperator.To_String(this);
            return output;
        }
    }
}
