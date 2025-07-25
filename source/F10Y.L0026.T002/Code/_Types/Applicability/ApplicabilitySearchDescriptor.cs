using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a search based on the applicability of an instances set by using an applicability value.
    /// </summary>
    [DataTypeMarker]
    public class ApplicabilitySearchDescriptor : IApplicabilitySearchDescriptor,
        IHas_Applicability
    {
        public string Applicability { get; set; }
    }
}
