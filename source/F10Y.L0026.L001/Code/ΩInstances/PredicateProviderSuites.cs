using System;


namespace F10Y.L0026.L001
{
    public class PredicateProviderSuites : IPredicateProviderSuites
    {
        #region Infrastructure

        public static IPredicateProviderSuites Instance { get; } = new PredicateProviderSuites();


        private PredicateProviderSuites()
        {
        }

        #endregion
    }
}
