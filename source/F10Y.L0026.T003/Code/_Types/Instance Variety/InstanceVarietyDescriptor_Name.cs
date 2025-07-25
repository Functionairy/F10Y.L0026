using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// An instance variety name.
    /// </summary>
    /// <remarks>
    /// This type is solely name based.
    /// For example, the IHasX instance variety has no internal structure (it's just the name, IHasX).
    /// While the Values instance variety has the internal structure or raw./refined, fundamental/derived, system-typed/strongly-typed.
    /// This means the Values instance variety would be better represented by a whole separate instance variety descriptor type, where the "name" from this type would just be the name of that separate instance variety descriptor type.
    /// </remarks>
    [DataTypeMarker]
    public class InstanceVarietyDescriptor_Name : IInstanceVarietyDescriptor,
        IEquatable<InstanceVarietyDescriptor_Name>,
        IWith_InstanceVarietyName
    {
        public string InstanceVariety_Name { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceVarietyDescriptor_Name applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceVarietyDescriptor_Name other)
        {
            var output = true
                && this.InstanceVariety_Name == other.InstanceVariety_Name
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.InstanceVariety_Name);
            return output;
        }
    }
}
