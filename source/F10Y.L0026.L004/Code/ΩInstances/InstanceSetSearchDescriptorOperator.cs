using System;


namespace F10Y.L0026.L004
{
    public class InstanceSetSearchDescriptorOperator : IInstanceSetSearchDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceSetSearchDescriptorOperator Instance { get; } = new InstanceSetSearchDescriptorOperator();


        private InstanceSetSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
