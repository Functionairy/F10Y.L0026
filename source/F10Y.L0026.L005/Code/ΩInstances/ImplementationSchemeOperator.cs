using System;


namespace F10Y.L0026.L005
{
    public class ImplementationSchemeOperator : IImplementationSchemeOperator
    {
        #region Infrastructure

        public static IImplementationSchemeOperator Instance { get; } = new ImplementationSchemeOperator();


        private ImplementationSchemeOperator()
        {
        }

        #endregion
    }
}
