using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// An empty interface for instance set descriptors.
    /// </summary>
    /// <inheritdoc cref="Documentation_Common.EmptyInterfaceAsPlaceholder" path="/remarks"/>
    [DataTypeMarker]
    public interface IInstanceSetSearchDescriptor :
        IHas_Descriptor
    {
        // Empty.
    }


    namespace N001
    {
        /// <inheritdoc cref="T004.IInstanceSetSearchDescriptor" path="/summary"/>
        /// <remarks>
        /// <inheritdoc cref="T004.IInstanceSetSearchDescriptor" path="/remarks"/>
        /// <para>
        /// This related type for <see cref="T004.IInstanceSetSearchDescriptor"/> lacks a descriptor (<see cref="IDescriptor"/>),
        /// to allow for the descriptor to provided while converting the search descriptor to an instance set search.
        /// </para>
        /// </remarks>
        [DataTypeMarker]
        public interface IInstanceSetSearchDescriptor
        {
            // Empty.
        }
    }
}
