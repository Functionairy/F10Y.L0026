using System;

using F10Y.T0003;


namespace F10Y.L0026.L003
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers
    {
        #region Instance Set Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetDescriptor, InstanceSetDescriptor> For_InstanceSetDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetDescriptor, InstanceSetDescriptor>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetDescriptor, InstanceSetDescriptor_CatchAllLibrary> For_InstanceSetDescriptor_CatchAllLibrary =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetDescriptor, InstanceSetDescriptor_CatchAllLibrary>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetDescriptor, InstanceSetDescriptor_EntryPointExecutable> For_InstanceSetDescriptor_EntryPointExecutable =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetDescriptor, InstanceSetDescriptor_EntryPointExecutable>.Instance;

        #endregion

        #region Instance Set Flow Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Aggregate> For_InstanceSetFlowDescriptor_Aggregate =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Aggregate>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Contribute> For_InstanceSetFlowDescriptor_Contribute =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Contribute>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Deprecate> For_InstanceSetFlowDescriptor_Deprecate =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Deprecate>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Librarate> For_InstanceSetFlowDescriptor_Librarate =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Librarate>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_NetVersion_Change> For_InstanceSetFlowDescriptor_NetVersion_Change =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_NetVersion_Change>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_NetVersion_Choose> For_InstanceSetFlowDescriptor_NetVersion_Choose =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_NetVersion_Choose>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Port> For_InstanceSetFlowDescriptor_Port =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Port>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Publicize> For_InstanceSetFlowDescriptor_Publicize =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlowDescriptor, InstanceSetFlowDescriptor_Publicize>.Instance;

        #endregion

        #region Instance Set Location Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetLocationDescriptor, InstanceSetLocationDescriptor> For_InstanceSetLocationDescriptor =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetLocationDescriptor, InstanceSetLocationDescriptor>.Instance;

        #endregion

        #region Instance Set Type Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetTypeDescriptor, InstanceSetTypeDescriptor_Name> For_InstanceSetTypeDescriptor_Name =>
           For_TypeSpecifiers.TypeSpecifier<IInstanceSetTypeDescriptor, InstanceSetTypeDescriptor_Name>.Instance;

        #endregion

        #region Instance Variety Descriptors

        public For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_Aggregate> For_InstanceVarietyDescriptor_Aggregate =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_Aggregate>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_All> For_InstanceVarietyDescriptor_All =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_All>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_Name> For_InstanceVarietyDescriptor_Name =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_Name>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_Name_Set> For_InstanceVarietyDescriptor_Name_Set =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_Name_Set>.Instance;

        public For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_Values> For_InstanceVarietyDescriptor_Values =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceVarietyDescriptor, InstanceVarietyDescriptor_Values>.Instance;

        #endregion
    }
}
