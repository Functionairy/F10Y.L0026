using System;


namespace F10Y.L0026.L001
{
    public class DependencyDescriptorOperator : IDependencyDescriptorOperator
    {
        #region Infrastructure

        public static IDependencyDescriptorOperator Instance { get; } = new DependencyDescriptorOperator();


        private DependencyDescriptorOperator()
        {
        }

        #endregion
    }
}
