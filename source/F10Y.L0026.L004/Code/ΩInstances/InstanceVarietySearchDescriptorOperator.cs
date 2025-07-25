using System;


namespace F10Y.L0026.L004
{
    public class InstanceVarietySearchDescriptorOperator : IInstanceVarietySearchDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceVarietySearchDescriptorOperator Instance { get; } = new InstanceVarietySearchDescriptorOperator();


        private InstanceVarietySearchDescriptorOperator()
        {
        }

        #endregion
    }
}
