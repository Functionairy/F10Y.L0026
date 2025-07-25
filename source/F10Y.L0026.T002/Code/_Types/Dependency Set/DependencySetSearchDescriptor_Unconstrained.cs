using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Indicates that the allowed dependencies set of an instances set is unconstrained.
    /// </summary>
    [DataTypeMarker]
    public class DependencySetSearchDescriptor_Unconstrained : IDependencySetSearchDescriptor
    {
        #region Static

        public static DependencySetSearchDescriptor_Unconstrained Instance { get; } = new();

        #endregion
    }
}
