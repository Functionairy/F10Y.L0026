using System;

using F10Y.T0003;


namespace F10Y.L0026.T003
{
    [ValuesMarker]
    public partial interface IInstanceSetTypeDescriptors
    {
        /// <inheritdoc cref="IInstanceSetTypeNames.CatchAll_Library"/>
        public InstanceSetTypeDescriptor_Name CatchAll_Library => Instances.InstanceSetTypeDescriptorOperator.From_Name(
            Instances.InstanceSetTypeNames.CatchAll_Library);

        /// <inheritdoc cref="IInstanceSetTypeNames.EntryPoint_Executable"/>
        public InstanceSetTypeDescriptor_Name EntryPoint_Executable => Instances.InstanceSetTypeDescriptorOperator.From_Name(
            Instances.InstanceSetTypeNames.EntryPoint_Executable);

        /// <inheritdoc cref="IInstanceSetTypeNames.Foundation_Library"/>
        public InstanceSetTypeDescriptor_Name Foundation_Library => Instances.InstanceSetTypeDescriptorOperator.From_Name(
            Instances.InstanceSetTypeNames.Foundation_Library);
    }
}
