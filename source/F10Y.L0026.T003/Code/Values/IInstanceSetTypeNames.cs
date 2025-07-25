using System;

using F10Y.T0003;


namespace F10Y.L0026.T003
{
    [ValuesMarker]
    public partial interface IInstanceSetTypeNames
    {
        /// <summary>
        /// <para><value>Catch-All Library</value></para>
        /// </summary>
        public string CatchAll_Library => "Catch-All Library";

        /// <summary>
        /// <para><value>Entry-Point Executable</value></para>
        /// </summary>
        public string EntryPoint_Executable => "Entry-Point Executable";

        /// <summary>
        /// <para><value>Foundation Library</value></para>
        /// </summary>
        public string Foundation_Library => "Foundation Library";
    }
}
