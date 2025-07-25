using System;

using F10Y.T0003;


namespace F10Y.L0026.L005
{
    [ValuesMarker]
    public partial interface ITexts
    {
        /// <summary>
        /// <para><value>Absolute</value></para>
        /// </summary>
        public const string Absolute_Constant = "Absolute";

        /// <inheritdoc cref="Absolute_Constant"/>
        public string Absolute => Absolute_Constant;

        /// <summary>
        /// <para><value>Contextual</value></para>
        /// </summary>
        public const string Contextual_Constant = "Contextual";

        /// <inheritdoc cref="Contextual_Constant"/>
        public string Contextual => Contextual_Constant;

        /// <summary>
        /// <para><value>Decorated</value></para>
        /// </summary>
        public const string Decorated_Constant = "Decorated";

        /// <inheritdoc cref="Decorated_Constant"/>
        public string Decorated => Decorated_Constant;

        /// <summary>
        /// <para><value>Derived</value></para>
        /// </summary>
        public const string Derived_Constant = "Derived";

        /// <inheritdoc cref="Derived_Constant"/>
        public string Derived => Derived_Constant;

        /// <summary>
        /// <para><value>Direct</value></para>
        /// </summary>
        public const string Direct_Constant = "Direct";

        /// <inheritdoc cref="Direct_Constant"/>
        public string Direct => Direct_Constant;

        /// <summary>
        /// <para><value>Unadorned</value></para>
        /// </summary>
        public const string Unadorned_Constant = "Unadorned";

        /// <inheritdoc cref="Unadorned_Constant"/>
        public string Unadorned => Unadorned_Constant;
    }
}
