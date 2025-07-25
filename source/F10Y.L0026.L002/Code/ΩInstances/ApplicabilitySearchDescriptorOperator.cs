using System;


namespace F10Y.L0026.L002
{
    public class ApplicabilitySearchDescriptorOperator : IApplicabilitySearchDescriptorOperator
    {
        #region Infrastructure

        public static IApplicabilitySearchDescriptorOperator Instance { get; } = new ApplicabilitySearchDescriptorOperator();


        private ApplicabilitySearchDescriptorOperator()
        {
        }

        #endregion
    }
}
