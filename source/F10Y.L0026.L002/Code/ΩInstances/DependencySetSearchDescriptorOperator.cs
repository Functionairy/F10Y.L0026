using System;


namespace F10Y.L0026.L002
{
    public class DependencySetSearchDescriptorOperator : IDependencySetSearchDescriptorOperator
    {
        #region Infrastructure

        public static IDependencySetSearchDescriptorOperator Instance { get; } = new DependencySetSearchDescriptorOperator();


        private DependencySetSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
