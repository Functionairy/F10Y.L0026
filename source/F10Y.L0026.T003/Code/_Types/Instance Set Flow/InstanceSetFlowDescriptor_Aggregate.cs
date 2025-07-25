using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_Aggregate : For_EnumerableBase.EnumerableBase<IInstanceSetFlowDescriptor>, IInstanceSetFlowDescriptor,
        IEquatable<InstanceSetFlowDescriptor_Aggregate>
    {
        public IInstanceSetFlowDescriptor[] Descriptors { get; set; }

        protected override IInstanceSetFlowDescriptor[] Values_ForEnumerable => this.Descriptors;


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetFlowDescriptor_Aggregate applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetFlowDescriptor_Aggregate other)
        {
            var output = true
                && Instances.ArrayOperator.Are_Equal(
                    this.Descriptors,
                    other.Descriptors);
            ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(this.Descriptors);
            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class InstanceSetFlowDescriptor_Aggregate
        {
            public JsonSerializationObject[] Descriptors { get; set; }
        }
    }
}
