using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// A naming scheme based on the <see cref="NamingScheme"/> enumeration.
    /// </summary>
    [DataTypeMarker]
    public class NamingSchemeDescriptor_Enumeration : INamingSchemeDescriptor,
        IEquatable<NamingSchemeDescriptor_Enumeration>,
        IWith_NamingScheme
    {
        public NamingScheme NamingScheme { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is NamingSchemeDescriptor_Enumeration applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(NamingSchemeDescriptor_Enumeration other)
        {
            var output = true
                && this.NamingScheme == other.NamingScheme
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.NamingScheme);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.NamingSchemeDescriptorOperator.To_String(this);
            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class NamingSchemeDescriptor_Enumeration
        {
            public string NamingScheme { get; set; }
        }
    }
}
