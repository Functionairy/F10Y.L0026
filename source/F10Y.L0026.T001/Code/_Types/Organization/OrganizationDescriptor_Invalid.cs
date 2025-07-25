using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// The unrecognized organization descriptor type.
    /// </summary>
    /// <remarks>
    /// Allows testing for unrecognized organization descriptor types.
    /// </remarks>
    [DataTypeMarker]
    public class OrganizationDescriptor_Invalid : IOrganizationDescriptor
    {
        #region Static

        public static OrganizationDescriptor_Invalid Instance { get; } = new();

        #endregion


        /// <summary>
        /// Singleton.
        /// </summary>
        private OrganizationDescriptor_Invalid()
        {
            // Do nothing.
        }

        public override string ToString()
        {
            var output = Instances.OrganizationDescriptorOperator.To_String(this);
            return output;
        }
    }
}
