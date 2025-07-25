using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// A instance set type descriptor, which describes the type of the instance set.
    /// </summary>
    /// <remarks>
    /// An instance set, in addition to all its facet descriptors (applicability, instance variety, etc.) might itself be intrinsically of a type.
    /// For example, the instance set might be a foundation instance set for a particular .NET version, or it might be an entry-point executable.
    /// </remarks>
    /// <inheritdoc cref="F10Y.Y0000.Documentation.EmptyInterfaceAsPlaceholder" path="/remarks"/>
    [DataTypeMarker]
    public interface IInstanceSetTypeDescriptor
    {
        // Empty.
    }
}
