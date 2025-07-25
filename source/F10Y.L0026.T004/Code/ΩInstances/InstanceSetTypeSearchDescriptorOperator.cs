using System;


namespace F10Y.L0026.T004
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
