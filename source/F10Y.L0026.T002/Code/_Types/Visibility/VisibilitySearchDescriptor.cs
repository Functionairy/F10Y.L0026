using System;

using F10Y.L0001.T000;
using F10Y.T0004;


namespace F10Y.L0026.T002
{
    [DataTypeMarker]
    public class VisibilitySearchDescriptor : IVisibilitySearchDescriptor,
        IWith_Visibility
    {
        public Visibility Visibility { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class VisibilitySearchDescriptor
        {
            public string Visibility { get; set; }
        }
    }
}
