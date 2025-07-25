using System;


namespace F10Y.L0026.L001
{
    public class DependencySetDescriptorOperator : IDependencySetDescriptorOperator
    {
        #region Infrastructure

        public static IDependencySetDescriptorOperator Instance { get; } = new DependencySetDescriptorOperator();


        private DependencySetDescriptorOperator()
        {
        }

        #endregion
    }
}
