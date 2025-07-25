using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    [DataTypeMarker]
    public class LocationDescriptor_Aggregate : For_EnumerableBase.EnumerableBase<ILocationDescriptor>, ILocationDescriptor,
        IEquatable<LocationDescriptor_Aggregate>
    {
        public ILocationDescriptor[] LocationDescriptors { get; set; }

        protected override ILocationDescriptor[] Values_ForEnumerable => this.LocationDescriptors;


        public override bool Equals(object obj)
        {
            var output = obj is LocationDescriptor_Aggregate applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(LocationDescriptor_Aggregate other)
        {
            var output = true
                && Instances.ArrayOperator.Are_Equal(
                    this.LocationDescriptors,
                    other.LocationDescriptors);
            ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(this.LocationDescriptors);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.LocationDescriptorOperator.To_String(this);
            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class LocationDescriptor_Aggregate
        {
            public JsonSerializationObject[] LocationDescriptors { get; set; }
        }
    }
}
