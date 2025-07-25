using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    [DataTypeMarker]
    public class LocationDescriptor_ProjectFile : ILocationDescriptor,
        IEquatable<LocationDescriptor_ProjectFile>,
        IWith_ProjectFilePath
    {
        public string ProjectFilePath { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is LocationDescriptor_ProjectFile applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(LocationDescriptor_ProjectFile other)
        {
            var output = true
                && this.ProjectFilePath == other.ProjectFilePath
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.ProjectFilePath);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.LocationDescriptorOperator.To_String(this);
            return output;
        }
    }
}
