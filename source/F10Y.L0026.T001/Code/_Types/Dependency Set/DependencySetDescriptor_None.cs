using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Indicates that no dependencies are allowed for an instances set.
    /// </summary>
    [DataTypeMarker]
    public class DependencySetDescriptor_None : IDependencySetDescriptor
    {
        #region Static

        public static DependencySetDescriptor_None Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private DependencySetDescriptor_None()
        {
            // Do nothing.
        }

        public override string ToString()
        {
            var output = Instances.DependencySetDescriptorOperator.To_String(this);
            return output;
        }
    }
}