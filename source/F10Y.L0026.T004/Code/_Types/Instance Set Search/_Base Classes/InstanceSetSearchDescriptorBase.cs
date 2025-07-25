using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// There will be lots of sub-types, one per type of search (values, etc.).
    /// </summary>
    [DataTypeMarker]
    public abstract class InstanceSetSearchDescriptorBase : IInstanceSetSearchDescriptor,
        IWith_Descriptor
    {
        /// <summary>
        /// Descriptor for the search descriptor, not the instance sets being searched for.
        /// </summary>
        public IDescriptor Descriptor { get; set; }
    }
}
