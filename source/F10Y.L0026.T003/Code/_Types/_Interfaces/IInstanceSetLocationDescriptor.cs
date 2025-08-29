using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// A instance set location descriptor, which pairs a location descriptor with an instance set descriptor.
    /// </summary>
    [DataTypeMarker]
    public interface IInstanceSetLocationDescriptor :
        IHas_InstanceSetDescriptor,
        IHas_LastModified,
        IHas_LocationDescriptor
    {
        /// <summary>
        /// Code location descriptor, for projects and NuGet packages.
        /// </summary>
        // New to allow overwrite of documentation comment, storage behavior of property will be decided by implementers.
        new ILocationDescriptor LocationDescriptor { get; }
    }
}
