using System;

using F10Y.T0002;


namespace F10Y.L0026.T002
{
    [FunctionsMarker]
    public partial interface INetVersionSearchDescriptorOperator
    {
        public NetVersionSearchDescriptor From(string targetFrameworkMoniker)
        {
            var output = new NetVersionSearchDescriptor
            {
                TargetFrameworkMoniker = targetFrameworkMoniker
            };

            return output;
        }
    }
}
