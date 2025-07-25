using System;


namespace F10Y.L0026.T003
{
    public class InstanceSetFlowDescriptorOperator : IInstanceSetFlowDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceSetFlowDescriptorOperator Instance { get; } = new InstanceSetFlowDescriptorOperator();


        private InstanceSetFlowDescriptorOperator()
        {
        }

        #endregion
    }
}
