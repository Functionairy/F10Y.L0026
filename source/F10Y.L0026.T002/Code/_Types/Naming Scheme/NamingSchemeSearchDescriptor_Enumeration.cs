using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// A naming scheme search based on the <see cref="NamingScheme"/> enumeration.
    /// </summary>
    [DataTypeMarker]
    public class NamingSchemeSearchDescriptor_Enumeration : INamingSchemeSearchDescriptor,
        IWith_NamingScheme
    {
        public NamingScheme NamingScheme { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class NamingSchemeSearchDescriptor_Enumeration
        {
            public string NamingScheme { get; set; }
        }
    }
}
