using System;


namespace F10Y.L0026.L003
{
    public class InstanceVarietyDescriptorOperator : IInstanceVarietyDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceVarietyDescriptorOperator Instance { get; } = new InstanceVarietyDescriptorOperator();


        private InstanceVarietyDescriptorOperator()
        {
        }

        #endregion
    }
}
