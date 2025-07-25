using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a search of the dependencies of an instances set by using a dependency search descriptor.
    /// <para>Any logic is assumed for matching within dependency sets.</para>
    /// </summary>
    [DataTypeMarker]
    public class DependencySetSearchDescriptor_DependencySearchDescriptor : IDependencySetSearchDescriptor
    {
        public IDependencySearchDescriptor DependencySearchDescriptor { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class DependencySetSearchDescriptor_DependencySearchDescriptor
        {
            public JsonSerializationObject DependencySearchDescriptor { get; set; }
        }
    }
}
