using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// A <em>code</em> visibility descriptor, which is probably going to be just public/private, but could be others in the future.
    /// </summary>
    /// <remarks>
    /// Visibility is one of the "ownership" descriptors of an instances set.
    /// <para><inheritdoc cref="Documentation_InstanceSet.OwnershipDescriptorRemarks_ForInstanceSet" path="/remarks"/></para>
    /// <para><inheritdoc cref="Documentation_Common.EmptyInterfaceAsPlaceholder" path="/remarks"/></para>
    /// </remarks>
    [DataTypeMarker]
    public interface IVisibilityDescriptor
    {
        // Empty.
    }
}