using System;


namespace F10Y.L0026.L002
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
