using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0026.L003
{
    [ValuesMarker]
    public partial interface IInstanceSetTypeNames :
        T003.IInstanceSetTypeNames
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T003.IInstanceSetTypeNames _T003 => T003.InstanceSetTypeNames.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
