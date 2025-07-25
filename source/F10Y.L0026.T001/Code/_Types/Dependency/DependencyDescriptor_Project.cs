using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the project file path dependency of a project.
    /// </summary>
    [DataTypeMarker]
    public class DependencyDescriptor_Project : IDependencyDescriptor,
        IEquatable<DependencyDescriptor_Project>,
        IWith_ProjectFilePath
    {
        public string ProjectFilePath { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DependencyDescriptor_Project applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DependencyDescriptor_Project other)
        {
            var output = true
                && this.ProjectFilePath == other.ProjectFilePath
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.ProjectFilePath);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.DependencyDescriptorOperator.To_String(this);
            return output;
        }
    }
}
