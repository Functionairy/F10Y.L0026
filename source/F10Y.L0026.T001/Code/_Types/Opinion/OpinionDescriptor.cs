using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the opinion of an instances set by using an opinion value.
    /// </summary>
    [DataTypeMarker]
    public class OpinionDescriptor : IOpinionDescriptor,
        IEquatable<OpinionDescriptor>,
        IWith_Opinion
    {
        public string Opinion { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is OpinionDescriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(OpinionDescriptor other)
        {
            var output = true
                && this.Opinion == other.Opinion
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Opinion);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.OpinionDescriptorOperator.To_String(this);
            return output;
        }
    }
}
