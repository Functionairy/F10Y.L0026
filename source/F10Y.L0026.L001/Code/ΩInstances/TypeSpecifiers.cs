using System;


namespace F10Y.L0026.L001
{
    public class TypeSpecifiers : ITypeSpecifiers
    {
        #region Infrastructure

        public static ITypeSpecifiers Instance { get; } = new TypeSpecifiers();


        private TypeSpecifiers()
        {
        }

        #endregion
    }
}
