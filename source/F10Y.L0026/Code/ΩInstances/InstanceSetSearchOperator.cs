using System;


namespace F10Y.L0026
{
    public class InstanceSetSearchOperator : IInstanceSetSearchOperator
    {
        #region Infrastructure

        public static IInstanceSetSearchOperator Instance { get; } = new InstanceSetSearchOperator();


        private InstanceSetSearchOperator()
        {
        }

        #endregion
    }
}
