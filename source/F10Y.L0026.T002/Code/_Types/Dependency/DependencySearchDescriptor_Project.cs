using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes the project file path dependency of a project.
    /// </summary>
    [DataTypeMarker]
    public class DependencySearchDescriptor_Project : IDependencySearchDescriptor,
        IWith_ProjectFilePath
    {
        public string ProjectFilePath { get; set; }
    }
}
