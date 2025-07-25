using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    [DataTypeMarker]
    public class InstanceSetTypeDescriptor_Name : IInstanceSetTypeDescriptor,
        IEquatable<InstanceSetTypeDescriptor_Name>,
        IWith_InstanceSetTypeName
    {
        public string InstanceSetType_Name { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetTypeDescriptor_Name applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetTypeDescriptor_Name other)
        {
            var output = true
                && this.InstanceSetType_Name == other.InstanceSetType_Name
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.InstanceSetType_Name);
            return output;
        }
    }
}
