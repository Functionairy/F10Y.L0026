using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface INetVersionDescriptorOperator
    {
        public NetVersionDescriptor From(string targetFrameworkMoniker)
        {
            var output = new NetVersionDescriptor
            {
                TargetFrameworkMoniker = targetFrameworkMoniker
            };

            return output;
        }

        public string To_String(NetVersionDescriptor netVersionDescriptor)
        {
            var output = $".NET Version: {netVersionDescriptor.TargetFrameworkMoniker}";
            return output;
        }

        public string To_String(NetVersionDescriptor_Latest netVersionDescriptor)
        {
            var output = ".NET Version: LATEST";
            return output;
        }
    }
}
