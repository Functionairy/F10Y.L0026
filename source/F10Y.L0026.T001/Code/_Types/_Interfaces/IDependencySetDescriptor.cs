using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the dependency set (projects and NuGet pacakges) of an instances set.
    /// </summary>
    /// <remarks>
    /// Generally depenencies will be thought of as "allowed dependencies" and there will be multiple dependencies in a dependencies set.
    /// <para><inheritdoc cref="Documentation_InstanceSet.PhysicalDescriptorRemarks_ForInstanceSet" path="/remarks"/></para>
    /// <para><inheritdoc cref="Documentation_Common.EmptyInterfaceAsPlaceholder" path="/remarks"/></para>
    /// </remarks>
    [DataTypeMarker]
    public interface IDependencySetDescriptor
    {
        // Empty.
    }
}
