using System;

using F10Y.T0003;


namespace F10Y.L0026.T001
{
    [ValuesMarker]
    public partial interface INetVersionDescriptors
    {
        /// <inheritdoc cref="NetVersionDescriptor_Latest.Instance"/>
        public NetVersionDescriptor_Latest LATEST => NetVersionDescriptor_Latest.Instance;
    }
}
