using System;


namespace F10Y.L0026.T001
{
    public class NetVersionDescriptorOperator : INetVersionDescriptorOperator
    {
        #region Infrastructure

        public static INetVersionDescriptorOperator Instance { get; } = new NetVersionDescriptorOperator();


        private NetVersionDescriptorOperator()
        {
        }

        #endregion
    }
}
