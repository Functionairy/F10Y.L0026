using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0026.L000
{
    [ValuesMarker]
    public partial interface ITexts :
        L0001.ITexts
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0001.ITexts _L0001 => L0001.Texts.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>LATEST</value></para>
        /// </summary>
        public string LATEST => "LATEST";

        /// <summary>
        /// <para><value>(alphabetical order)</value></para>
        /// </summary>
        public string Order_Alphabetical_Parenthetical => "(alphabetical order)";

        /// <summary>
        /// <para><value>(in order)</value></para>
        /// </summary>
        public string Order_In_Parenthetical => "(in order)";

        /// <summary>
        /// <para><value>UNCONSTRAINED</value></para>
        /// </summary>
        public string UNCONSTRAINED => "UNCONSTRAINED";
    }
}
