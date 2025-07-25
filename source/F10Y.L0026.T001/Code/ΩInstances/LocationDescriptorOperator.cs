using System;


namespace F10Y.L0026.T001
{
    public class LocationDescriptorOperator : ILocationDescriptorOperator
    {
        #region Infrastructure

        public static ILocationDescriptorOperator Instance { get; } = new LocationDescriptorOperator();


        private LocationDescriptorOperator()
        {
        }

        #endregion
    }
}
