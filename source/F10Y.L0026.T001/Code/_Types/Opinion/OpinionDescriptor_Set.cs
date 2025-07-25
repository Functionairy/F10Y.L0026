using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the opinion of an instances set by using a set of opinion value.
    /// </summary>
    [DataTypeMarker]
    public class OpinionDescriptor_Set : IOpinionDescriptor,
        IEquatable<OpinionDescriptor_Set>,
        IWith_Opinions
    {
        public string[] Opinions { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is OpinionDescriptor_Set applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(OpinionDescriptor_Set other)
        {
            var output = true
                && Instances.ArrayOperator.Are_Equal(
                    this.Opinions,
                    other.Opinions)
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(this.Opinions);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.OpinionDescriptorOperator.To_String(this);
            return output;
        }
    }
}
