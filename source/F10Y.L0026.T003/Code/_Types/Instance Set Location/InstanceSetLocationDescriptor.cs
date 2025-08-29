using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <inheritdoc cref="IInstanceSetLocationDescriptor"/>
    [DataTypeMarker]
    public class InstanceSetLocationDescriptor :
        IEquatable<InstanceSetLocationDescriptor>,
        IInstanceSetLocationDescriptor,
        IWith_InstanceSetDescriptor,
        IWith_LastModified,
        IWith_LocationDescriptor
    {
        public IInstanceSetDescriptor InstanceSetDescriptor { get; set; }

        public ILocationDescriptor LocationDescriptor { get; set; }

        public DateTime LastModified { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetLocationDescriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetLocationDescriptor other)
        {
            var instanceSetDescriptor = Object.Equals(this.InstanceSetDescriptor, other.InstanceSetDescriptor);
            var locationDescriptor = Object.Equals(this.LocationDescriptor, other.LocationDescriptor);

            var output = true
                && instanceSetDescriptor
                && locationDescriptor
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(
                Instances.ArrayOperator.From<object>(
                    this.InstanceSetDescriptor,
                    this.LocationDescriptor
                    )
                );

            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class InstanceSetLocationDescriptor
        {
            public JsonSerializationObject InstanceSetDescriptor { get; set; }

            public JsonSerializationObject LocationDescriptor { get; set; }
        }
    }
}
