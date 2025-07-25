using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// An instance variety descriptor that allows an aggregate of instance variety descriptors.
    /// </summary>
    /// <remarks>
    /// No assumption is made, regarding the sub-instance variety descriptors at test time. (Could be ANY or ALL.)
    /// </remarks>
    [DataTypeMarker]
    public class InstanceVarietyDescriptor_Aggregate : For_EnumerableBase.EnumerableBase<IInstanceVarietyDescriptor>, IInstanceVarietyDescriptor,
        IEquatable<InstanceVarietyDescriptor_Aggregate>
    {
        public IInstanceVarietyDescriptor[] InstanceVarietyDescriptors { get; set; }

        protected override IInstanceVarietyDescriptor[] Values_ForEnumerable => this.InstanceVarietyDescriptors;


        public override bool Equals(object obj)
        {
            var output = obj is InstanceVarietyDescriptor_Aggregate applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceVarietyDescriptor_Aggregate other)
        {
            var output = true
                && Instances.ArrayOperator.Are_Equal(
                    this.InstanceVarietyDescriptors,
                    other.InstanceVarietyDescriptors);
            ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(this.InstanceVarietyDescriptors);
            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class InstanceVarietyDescriptor_Aggregate
        {
            public JsonSerializationObject[] InstanceVarietyDescriptors { get; set; }
        }
    }
}
