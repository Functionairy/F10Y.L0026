using System;


namespace F10Y.L0026.L004
{
    public class InstanceSetTypeSearchDescriptorOperator : IInstanceSetTypeSearchDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceSetTypeSearchDescriptorOperator Instance { get; } = new InstanceSetTypeSearchDescriptorOperator();


        private InstanceSetTypeSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
