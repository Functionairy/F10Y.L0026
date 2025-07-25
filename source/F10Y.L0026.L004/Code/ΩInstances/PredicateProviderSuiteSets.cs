using System;


namespace F10Y.L0026.L004
{
    public class PredicateProviderSuiteSets : IPredicateProviderSuiteSets
    {
        #region Infrastructure

        public static IPredicateProviderSuiteSets Instance { get; } = new PredicateProviderSuiteSets();


        private PredicateProviderSuiteSets()
        {
        }

        #endregion
    }
}
