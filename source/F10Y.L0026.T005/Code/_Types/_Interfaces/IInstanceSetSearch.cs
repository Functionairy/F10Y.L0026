using System;

using F10Y.T0004;


namespace F10Y.L0026.T005
{
    /// <summary>
    /// Represents an instance set search.
    /// </summary>
    /// <remarks>
    /// Provide an interface (and not just the class <see cref="InstanceSetFlow"/>) to allow future growth to include extra details beyond what a base class can provide.
    /// </remarks>
    [UtilityTypeMarker]
    public interface IInstanceSetSearch :
        IHas_Descriptor
    {
        // Empty.
    }
}

namespace F10Y.L0026.T005.Synchronous
{
    /// <inheritdoc cref="IInstanceSetSearch"/>
    [UtilityTypeMarker]
    public interface IInstanceSetSearch :
        T005.IInstanceSetSearch,
        For_HasPredicate.Synchronous.IHas_Predicate<IInstanceSetDescriptor>
    {
        // Empty.
    }
}


namespace F10Y.L0026.T005.Asynchronous
{
    /// <inheritdoc cref="IInstanceSetSearch"/>
    [UtilityTypeMarker]
    public interface IInstanceSetSearch :
        T005.IInstanceSetSearch,
        For_HasPredicate.Asynchronous.IHas_Predicate<IInstanceSetDescriptor>
    {
        // Empty.
    }
}
