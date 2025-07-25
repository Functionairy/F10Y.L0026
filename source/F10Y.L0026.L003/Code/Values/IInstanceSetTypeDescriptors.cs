using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0026.L003
{
    [ValuesMarker]
    public partial interface IInstanceSetTypeDescriptors :
        T003.IInstanceSetTypeDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T003.IInstanceSetTypeDescriptors _T003 => T003.InstanceSetTypeDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
