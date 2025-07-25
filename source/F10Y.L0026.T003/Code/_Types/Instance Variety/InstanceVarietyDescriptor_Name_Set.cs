using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// A set of instance variety names.
    /// </summary>
    /// <remarks>
    /// This type is solely name based.
    /// For example, the IHasX instance variety has no internal structure (it's just the name, IHasX).
    /// While the Values instance variety has the internal structure or raw./refined, fundamental/derived, system-typed/strongly-typed.
    /// This means the Values instance variety would be better represented by a whole separate instance variety descriptor type, where the "name" from this type would just be the name of that separate instance variety descriptor type.
    /// </remarks>
    [DataTypeMarker]
    public class InstanceVarietyDescriptor_Name_Set : IInstanceVarietyDescriptor,
        IEquatable<InstanceVarietyDescriptor_Name_Set>,
        IWith_InstanceVarietyNames
    {
        public string[] InstanceVariety_Names { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceVarietyDescriptor_Name_Set applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceVarietyDescriptor_Name_Set other)
        {
            var output = true
                && Instances.ArrayOperator.Are_Equal(
                    this.InstanceVariety_Names,
                    other.InstanceVariety_Names);
            ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(this.InstanceVariety_Names);
            return output;
        }
    }
}
