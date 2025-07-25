using System;

using F10Y.T0002;


namespace F10Y.L0026.L005
{
    [FunctionsMarker]
    public partial interface IImplementationSchemeOperator
    {
        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(ImplementationScheme)" path="/remarks"/>
        public ImplementationScheme From_String_Standard(string visibility)
        {
            var output = visibility switch
            {
                ITexts.Derived_Constant => ImplementationScheme.Derived,
                ITexts.Direct_Constant => ImplementationScheme.Direct,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<ImplementationScheme>(visibility)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public ImplementationScheme From_String(string visibility)
        {
            var output = this.From_String_Standard(visibility);
            return output;
        }

        /// <summary>
        /// Converts a visibility to its standard string representation.
        /// </summary>
        /// <remarks>
        /// The standard strings are:
        /// <list type="bullet">
        /// <item><inheritdoc cref="ITexts.Derived" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.Direct" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(ImplementationScheme visibility)
        {
            var output = visibility switch
            {
                ImplementationScheme.Derived => Instances.Texts.Derived,
                ImplementationScheme.Direct => Instances.Texts.Direct,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(visibility)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(ImplementationScheme)"/> as the default.
        /// </summary>
        public string To_String(ImplementationScheme visibility)
        {
            var output = this.To_String_Standard(visibility);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out ImplementationScheme visibility)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.Derived_Constant:
                    visibility = ImplementationScheme.Derived;
                    break;

                case ITexts.Direct_Constant:
                    visibility = ImplementationScheme.Direct;
                    break;

                default:
                    visibility = default;
                    output = false;
                    break;
            }

            return output;
        }
    }
}
