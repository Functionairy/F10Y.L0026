using System;


namespace F10Y.L0026.L003
{
    public class InstanceSetTypeNames : IInstanceSetTypeNames
    {
        #region Infrastructure

        public static IInstanceSetTypeNames Instance { get; } = new InstanceSetTypeNames();


        private InstanceSetTypeNames()
        {
        }

        #endregion
    }
}
