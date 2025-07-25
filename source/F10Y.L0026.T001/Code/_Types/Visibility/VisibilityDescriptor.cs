using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the visiblity (public or private) of an object.
    /// </summary>
    [DataTypeMarker]
    public class VisibilityDescriptor : IVisibilityDescriptor,
        IEquatable<VisibilityDescriptor>,
        IWith_Visibility
    {
        public Visibility Visibility { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is VisibilityDescriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(VisibilityDescriptor other)
        {
            var output = true
                && this.Visibility == other.Visibility
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Visibility);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.VisibilityDescriptorOperator.To_String(this);
            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class VisibilityDescriptor
        {
            public string Visibility { get; set; }
        }
    }
}
