using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0026.L003
{
    [ValuesMarker]
    public partial interface ITexts :
        L000.ITexts
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L000.ITexts _L000 => L000.Texts.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>DEPRECATE</value></para>
        /// </summary>
        public string DEPRECATE => "DEPRECATE";

        /// <summary>
        /// <para><value>LIBRARATE</value></para>
        /// </summary>
        public string LIBRARATE => "LIBRARATE";

        /// <summary>
        /// <para><value>PORT</value></para>
        /// </summary>
        public string PORT => "PORT";

        /// <summary>
        /// <para><value>PUBLICIZE</value></para>
        /// </summary>
        public string PUBLICIZE => "PUBLICIZE";
    }
}
