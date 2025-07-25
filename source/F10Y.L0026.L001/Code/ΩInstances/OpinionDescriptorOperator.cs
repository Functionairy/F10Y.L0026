using System;


namespace F10Y.L0026.L001
{
    public class OpinionDescriptorOperator : IOpinionDescriptorOperator
    {
        #region Infrastructure

        public static IOpinionDescriptorOperator Instance { get; } = new OpinionDescriptorOperator();


        private OpinionDescriptorOperator()
        {
        }

        #endregion
    }
}
