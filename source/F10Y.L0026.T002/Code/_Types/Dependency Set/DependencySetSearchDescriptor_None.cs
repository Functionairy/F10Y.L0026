using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Indicates a search for dependency sets where no dependencies are allowed.
    /// </summary>
    [DataTypeMarker]
    public class DependencySetSearchDescriptor_None : IDependencySetSearchDescriptor
    {
        #region Static

        public static DependencySetSearchDescriptor_None Instance { get; } = new();

        #endregion
    }
}