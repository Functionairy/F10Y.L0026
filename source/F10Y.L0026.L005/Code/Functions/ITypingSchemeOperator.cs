using System;

using F10Y.T0002;


namespace F10Y.L0026.L005
{
    [FunctionsMarker]
    public partial interface ITypingSchemeOperator
    {
        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(TypingScheme)" path="/remarks"/>
        public TypingScheme From_String_Standard(string namingScheme)
        {
            var output = namingScheme switch
            {
                ITexts.Decorated_Constant => TypingScheme.Decorated,
                ITexts.Unadorned_Constant => TypingScheme.Unadorned,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<NamingScheme>(namingScheme)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public TypingScheme From_String(string namingScheme)
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
        /// <item><inheritdoc cref="ITexts.Decorated" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.Unadorned" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(TypingScheme namingScheme)
        {
            var output = namingScheme switch
            {
                TypingScheme.Decorated => Instances.Texts.Decorated,
                TypingScheme.Unadorned => Instances.Texts.Unadorned,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(namingScheme)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(TypingScheme)"/> as the default.
        /// </summary>
        public string To_String(TypingScheme namingScheme)
        {
            var output = this.To_String_Standard(namingScheme);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out TypingScheme namingScheme)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.Decorated_Constant:
                    namingScheme = TypingScheme.Decorated;
                    break;

                case ITexts.Unadorned_Constant:
                    namingScheme = TypingScheme.Unadorned;
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
