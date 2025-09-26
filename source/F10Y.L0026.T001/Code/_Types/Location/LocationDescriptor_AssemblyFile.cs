using System;

using F10Y.L0026.T000;
using F10Y.T0004;


namespace F10Y.L0026.T001
{
    [DataTypeMarker]
    public class LocationDescriptor_AssemblyFile: ILocationDescriptor,
        IEquatable<LocationDescriptor_AssemblyFile>,
        IWith_AssemblyFilePath
    {
        public string AssemblyFilePath { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is LocationDescriptor_AssemblyFile applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(LocationDescriptor_AssemblyFile other)
        {
            var output = true
                && this.AssemblyFilePath == other.AssemblyFilePath
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.AssemblyFilePath);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.LocationDescriptorOperator.To_String(this);
            return output;
        }
    }
}
