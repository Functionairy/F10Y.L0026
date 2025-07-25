using System;


namespace F10Y.L0026.L005
{
    public class TypingSchemeOperator : ITypingSchemeOperator
    {
        #region Infrastructure

        public static ITypingSchemeOperator Instance { get; } = new TypingSchemeOperator();


        private TypingSchemeOperator()
        {
        }

        #endregion
    }
}
