using System;


namespace F10Y.L0026
{
    public class InstanceSetFlowOperator : IInstanceSetFlowOperator
    {
        #region Infrastructure

        public static IInstanceSetFlowOperator Instance { get; } = new InstanceSetFlowOperator();


        private InstanceSetFlowOperator()
        {
        }

        #endregion
    }
}
