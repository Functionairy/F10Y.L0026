using System;


namespace F10Y.L0026.T001
{
    public class NetVersionDescriptors : INetVersionDescriptors
    {
        #region Infrastructure

        public static INetVersionDescriptors Instance { get; } = new NetVersionDescriptors();


        private NetVersionDescriptors()
        {
        }

        #endregion
    }
}
