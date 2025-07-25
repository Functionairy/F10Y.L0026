using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the .NET version target framework moniker of an object by using a target framework moniker.
    /// </summary>
    [DataTypeMarker]
    public class NetVersionDescriptor : INetVersionDescriptor,
        IEquatable<NetVersionDescriptor>,
        IWith_TargetFrameworkMoniker
    {
        public string TargetFrameworkMoniker { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is NetVersionDescriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(NetVersionDescriptor other)
        {
            var output = true
                && this.TargetFrameworkMoniker == other.TargetFrameworkMoniker
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.TargetFrameworkMoniker);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.NetVersionDescriptorOperator.To_String(this);
            return output;
        }
    }
}
