using System;


namespace F10Y.L0026.L000
{
    public static class Instances
    {
        public static L0000.IArrayOperator ArrayOperator => L0000.ArrayOperator.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0062.L001.IJsonOperator JsonOperator => L0062.L001.JsonOperator.Instance;
        public static L0000.INullOperator NullOperator => L0000.NullOperator.Instance;
        public static L0001.L002.IResultOperator ResultOperator => L0001.L002.ResultOperator.Instance;
        public static L0001.ITexts Texts => L0001.Texts.Instance;
        public static L0000.ITypeOperator TypeOperator => L0000.TypeOperator.Instance;
    }
}