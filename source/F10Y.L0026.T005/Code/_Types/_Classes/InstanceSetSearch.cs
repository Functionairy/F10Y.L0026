using System;
using System.Threading.Tasks;

using F10Y.T0004;


namespace F10Y.L0026.T005.Synchronous
{
    /// <summary>
    /// Represents an instance set search.
    /// </summary>
    [UtilityTypeMarker]
    public class InstanceSetSearch : IInstanceSetSearch,
        IWith_Descriptor,
        For_WithPredicate.Synchronous.IWith_Predicate<IInstanceSetDescriptor>
    {
        public IDescriptor Descriptor { get; set; }

        public Func<IInstanceSetDescriptor, bool> Predicate { get; set; }
    }
}


namespace F10Y.L0026.T005.Asynchronous
{
    /// <inheritdoc cref="Synchronous.IInstanceSetSearch"/>
    [UtilityTypeMarker]
    public class InstanceSetSearch : IInstanceSetSearch,
        IWith_Descriptor,
        For_WithPredicate.Asynchronous.IWith_Predicate<IInstanceSetDescriptor>
    {
        public IDescriptor Descriptor { get; set; }

        public Func<IInstanceSetDescriptor, Task<bool>> Predicate { get; set; }
    }
}
