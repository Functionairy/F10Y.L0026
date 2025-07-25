using System;


namespace F10Y.L0026.L005
{
    public static class Instances
    {
        public static L0001.ISwitchOperator SwitchOperator => L0001.SwitchOperator.Instance;
        public static ITexts Texts => L005.Texts.Instance;
    }
}