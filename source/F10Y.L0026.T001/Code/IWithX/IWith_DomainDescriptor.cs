using System;

using F10Y.T0009;


namespace F10Y.L0026.T001
{
    [WithXMarker]
    public interface IWith_DomainDescriptor :
        IHas_DomainDescriptor
    {
        new IDomainDescriptor DomainDescriptor { get; set; }
    }
}
