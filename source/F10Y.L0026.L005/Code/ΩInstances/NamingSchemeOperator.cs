using System;


namespace F10Y.L0026.L005
{
    public class NamingSchemeOperator : INamingSchemeOperator
    {
        #region Infrastructure

        public static INamingSchemeOperator Instance { get; } = new NamingSchemeOperator();


        private NamingSchemeOperator()
        {
        }

        #endregion
    }
}
