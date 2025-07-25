using System;


namespace F10Y.L0026.L002
{
    public class NetVersionSearchDescriptorOperator : INetVersionSearchDescriptorOperator
    {
        #region Infrastructure

        public static INetVersionSearchDescriptorOperator Instance { get; } = new NetVersionSearchDescriptorOperator();


        private NetVersionSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
