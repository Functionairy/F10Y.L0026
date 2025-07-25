using System;


namespace F10Y.L0026.L002
{
    public class OpinionSearchDescriptorOperator : IOpinionSearchDescriptorOperator
    {
        #region Infrastructure

        public static IOpinionSearchDescriptorOperator Instance { get; } = new OpinionSearchDescriptorOperator();


        private OpinionSearchDescriptorOperator()
        {
        }

        #endregion
    }
}
