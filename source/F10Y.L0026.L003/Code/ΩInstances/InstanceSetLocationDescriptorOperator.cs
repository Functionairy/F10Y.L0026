using System;


namespace F10Y.L0026.L003
{
    public class InstanceSetLocationDescriptorOperator : IInstanceSetLocationDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceSetLocationDescriptorOperator Instance { get; } = new InstanceSetLocationDescriptorOperator();


        private InstanceSetLocationDescriptorOperator()
        {
        }

        #endregion
    }
}
