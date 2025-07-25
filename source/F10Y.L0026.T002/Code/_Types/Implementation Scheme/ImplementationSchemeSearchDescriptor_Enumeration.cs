using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    using ImplementationScheme_ForDocumentation = ImplementationScheme;


    /// <summary>
    /// An implementation scheme based on the <see cref="ImplementationScheme_ForDocumentation"/> enumeration.
    /// </summary>
    [DataTypeMarker]
    public class ImplementationSchemeSearchDescriptor_Enumeration : IImplementationSchemeSearchDescriptor,
        IHas_ImplementationScheme
    {
        public ImplementationScheme ImplementationScheme { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class ImplementationSchemeSearchDescriptor_Enumeration
        {
            public string ImplementationScheme { get; set; }
        }
    }
}
