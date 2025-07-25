using System;


namespace F10Y.L0026.L004
{
    public class DescriptorTextOperationHandlerSuiteSets : IDescriptorTextOperationHandlerSuiteSets
    {
        #region Infrastructure

        public static IDescriptorTextOperationHandlerSuiteSets Instance { get; } = new DescriptorTextOperationHandlerSuiteSets();


        private DescriptorTextOperationHandlerSuiteSets()
        {
        }

        #endregion
    }
}
