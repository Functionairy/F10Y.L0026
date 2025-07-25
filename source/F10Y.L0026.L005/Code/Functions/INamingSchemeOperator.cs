using System;

using F10Y.T0002;


namespace F10Y.L0026.L005
{
    [FunctionsMarker]
    public partial interface INamingSchemeOperator
    {
        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(NamingScheme)" path="/remarks"/>
        public NamingScheme From_String_Standard(string namingScheme)
        {
            var output = namingScheme switch
            {
                ITexts.Absolute_Constant => NamingScheme.Absolute,
                ITexts.Contextual_Constant => NamingScheme.Contextual,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<NamingScheme>(namingScheme)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public NamingScheme From_String(string namingScheme)
        {
            var output = this.From_String_Standard(namingScheme);
            return output;
        }

        /// <summary>
        /// Converts a visibility to its standard string representation.
        /// </summary>
        /// <remarks>
        /// The standard strings are:
        /// <list type="bullet">
        /// <item><inheritdoc cref="ITexts.Absolute" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.Contextual" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(NamingScheme namingScheme)
        {
            var output = namingScheme switch
            {
                NamingScheme.Absolute => Instances.Texts.Absolute,
                NamingScheme.Contextual => Instances.Texts.Contextual,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(namingScheme)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(NamingScheme)"/> as the default.
        /// </summary>
        public string To_String(NamingScheme namingScheme)
        {
            var output = this.To_String_Standard(namingScheme);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out NamingScheme namingScheme)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.Absolute_Constant:
                    namingScheme = NamingScheme.Absolute;
                    break;

                case ITexts.Contextual_Constant:
                    namingScheme = NamingScheme.Contextual;
                    break;

                default:
                    namingScheme = default;
                    output = false;
                    break;
            }

            return output;
        }
    }
}
