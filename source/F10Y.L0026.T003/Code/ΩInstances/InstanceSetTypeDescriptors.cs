using System;


namespace F10Y.L0026.T003
{
    public class InstanceSetTypeDescriptors : IInstanceSetTypeDescriptors
    {
        #region Infrastructure

        public static IInstanceSetTypeDescriptors Instance { get; } = new InstanceSetTypeDescriptors();


        private InstanceSetTypeDescriptors()
        {
        }

        #endregion
    }
}
