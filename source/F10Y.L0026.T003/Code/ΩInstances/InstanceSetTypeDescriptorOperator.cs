using System;


namespace F10Y.L0026.T003
{
    public class InstanceSetTypeDescriptorOperator : IInstanceSetTypeDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceSetTypeDescriptorOperator Instance { get; } = new InstanceSetTypeDescriptorOperator();


        private InstanceSetTypeDescriptorOperator()
        {
        }

        #endregion
    }
}
