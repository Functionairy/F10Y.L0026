using System;


namespace F10Y.L0026.T002
{
    public class VisibilitySearchDescriptorOperator : IVisibilitySearchDescriptorOperator
    {
        #region Infrastructure

        public static IVisibilitySearchDescriptorOperator Instance { get; } = new VisibilitySearchDescriptorOperator();


        private VisibilitySearchDescriptorOperator()
        {
        }

        #endregion
    }
}
