using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the dependencies of an instances set by using a set of dependency descriptors.
    /// </summary>
    [DataTypeMarker]
    public class DependencySetDescriptor : IDependencySetDescriptor,
        IEquatable<DependencySetDescriptor>
    {
        public IDependencyDescriptor[] DependencyDescriptors { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DependencySetDescriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DependencySetDescriptor other)
        {
            var output = true
                && Instances.ArrayOperator.Are_Equal(
                    this.DependencyDescriptors,
                    other.DependencyDescriptors)
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(this.DependencyDescriptors);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.DependencySetDescriptorOperator.To_String(this);
            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class DependencySetDescriptor
        {
            public JsonSerializationObject[] DependencyDescriptors { get; set; }
        }
    }
}
