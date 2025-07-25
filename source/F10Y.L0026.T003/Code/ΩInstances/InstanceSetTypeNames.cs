using System;


namespace F10Y.L0026.T003
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
