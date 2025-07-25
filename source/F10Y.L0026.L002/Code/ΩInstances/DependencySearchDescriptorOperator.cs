using System;


namespace F10Y.L0026.L002
{
    public class DependencySearchDescriptorOperator : IDependencySearchDescriptorOperator
    {
        #region Infrastructure

        public static IDependencySearchDescriptorOperator Instance { get; } = new DependencySearchDescriptorOperator();


        private DependencySearchDescriptorOperator()
        {
        }

        #endregion
    }
}
