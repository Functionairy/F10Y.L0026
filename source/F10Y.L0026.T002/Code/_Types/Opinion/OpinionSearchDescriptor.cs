using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes an opinion-based search of an instances set by using an opinion value.
    /// </summary>
    [DataTypeMarker]
    public class OpinionSearchDescriptor : IOpinionSearchDescriptor,
        IWith_Opinion
    {
        public string Opinion { get; set; }
    }
}
