using System;


namespace F10Y.L0026.L001
{
    public class ApplicabilityDescriptorOperator : IApplicabilityDescriptorOperator
    {
        #region Infrastructure

        public static IApplicabilityDescriptorOperator Instance { get; } = new ApplicabilityDescriptorOperator();


        private ApplicabilityDescriptorOperator()
        {
        }

        #endregion
    }
}
