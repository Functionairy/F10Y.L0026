using System;


namespace F10Y.L0026.L004
{
    public class DescriptorTextOperationHandlerSuites : IDescriptorTextOperationHandlerSuites
    {
        #region Infrastructure

        public static IDescriptorTextOperationHandlerSuites Instance { get; } = new DescriptorTextOperationHandlerSuites();


        private DescriptorTextOperationHandlerSuites()
        {
        }

        #endregion
    }
}
