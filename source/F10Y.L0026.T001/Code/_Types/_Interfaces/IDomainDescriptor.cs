using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the domain of an instance set.
    /// </summary>
    /// <remarks>
    /// Domain can be all, a specific value (like Octokit), or a set of values.
    /// <para>
    /// Applicability is one of the "arbitary" descriptors of an instances set.
    /// </para>
    /// <para><inheritdoc cref="Documentation_InstanceSet.ArbitraryDescriptorRemarks_ForInstanceSet" path="/remarks"/></para>
    /// <para><inheritdoc cref="Documentation_Common.EmptyInterfaceAsPlaceholder" path="/remarks"/></para>
    /// </remarks>
    [DataTypeMarker]
    public interface IDomainDescriptor
    {
        // Empty.
    }
}
