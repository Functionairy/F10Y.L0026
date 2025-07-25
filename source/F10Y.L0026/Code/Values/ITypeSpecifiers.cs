using System;

using F10Y.T0003;


namespace F10Y.L0026
{
    [ValuesMarker]
    public partial interface ITypeSpecifiers
    {
        #region Instance Set Flow

        public For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlow, InstanceSetFlow> For_InstanceSetFlow =>
            For_TypeSpecifiers.TypeSpecifier<IInstanceSetFlow, InstanceSetFlow>.Instance;

        #endregion
    }
}
