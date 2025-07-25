using System;

using F10Y.T0004;


namespace F10Y.L0026.T005
{
    /// <summary>
    /// Represents a flow from a source to a destination instance set.
    /// </summary>
    /// <remarks>
    /// Provide an interface (and not just the class <see cref="InstanceSetFlow"/>) to allow future growth to include extra details beyond what a base class can provide.
    /// </remarks>
    [DataTypeMarker]
    public interface IInstanceSetFlow
    {
        IInstanceSetDescriptor Source { get; }
        IInstanceSetDescriptor Destination { get; }
        IInstanceSetFlowDescriptor Flow { get; }
    }
}
