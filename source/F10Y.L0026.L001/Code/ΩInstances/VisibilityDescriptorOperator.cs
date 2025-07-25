using System;


namespace F10Y.L0026.L001
{
    public class VisibilityDescriptorOperator : IVisibilityDescriptorOperator
    {
        #region Infrastructure

        public static IVisibilityDescriptorOperator Instance { get; } = new VisibilityDescriptorOperator();


        private VisibilityDescriptorOperator()
        {
        }

        #endregion
    }
}
