using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes just the name of a dependency (whether the dependency is a project or package, or somethine else, is left unspecified).
    /// </summary>
    [DataTypeMarker]
    public class DependencySearchDescriptor_Name : IDependencySearchDescriptor,
        IWith_Name
    {
        public string Name { get; set; }
    }
}
