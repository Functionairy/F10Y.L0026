using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a search of domains of an instance set by using a domain value.
    /// </summary>
    [DataTypeMarker]
    public class DomainSearchDescriptor : IDomainSearchDescriptor,
        IWith_Domain
    {
        public string Domain { get; set; }
    }
}
