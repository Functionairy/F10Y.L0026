using System;

using F10Y.T0002;


namespace F10Y.L0026.T002
{
    [FunctionsMarker]
    public partial interface IApplicabilitySearchDescriptorOperator
    {
        public ApplicabilitySearchDescriptor From(string applicability)
        {
            var output = new ApplicabilitySearchDescriptor
            {
                Applicability = applicability
            };

            return output;
        }
    }
}
