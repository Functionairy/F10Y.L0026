using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes just the name of a dependency (whether the dependency is a project or package, or somethine else, is left unspecified).
    /// </summary>
    [DataTypeMarker]
    public class DependencyDescriptor_Name : IDependencyDescriptor,
        IEquatable<DependencyDescriptor_Name>,
        IWith_Name
    {
        public string Name { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DependencyDescriptor_Name applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DependencyDescriptor_Name other)
        {
            var output = true
                && this.Name == other.Name
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Name);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.DependencyDescriptorOperator.To_String(this);
            return output;
        }
    }
}
