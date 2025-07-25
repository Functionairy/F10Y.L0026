using System;


namespace F10Y.L0026.T003
{
    public class InstanceSetDescriptorOperator : IInstanceSetDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceSetDescriptorOperator Instance { get; } = new InstanceSetDescriptorOperator();


        private InstanceSetDescriptorOperator()
        {
        }

        #endregion
    }
}
