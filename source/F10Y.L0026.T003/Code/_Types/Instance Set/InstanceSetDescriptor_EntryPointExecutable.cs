using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Descriptor for an entry-point executable instance set.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetDescriptor_EntryPointExecutable :
        IEquatable<InstanceSetDescriptor_EntryPointExecutable>,
        IInstanceSetDescriptor,
        IInstanceSetDescriptor_EntryPointExecutable,
        //
        IHas_InstanceSetTypeDescriptor,
        IWith_OrganizationDescriptor,
        IWith_NetVersionDescriptor,
        IWith_VisibilityDescriptor
    {
        public IDescriptor Descriptor { get; set; }

        public IInstanceSetTypeDescriptor InstanceSetTypeDescriptor { get; }
            = Instances.InstanceSetTypeDescriptors.EntryPoint_Executable;

        public IOrganizationDescriptor OrganizationDescriptor { get; set; }

        public IVisibilityDescriptor VisibilityDescriptor { get; set; }

        public INetVersionDescriptor NetVersionDescriptor { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetDescriptor_EntryPointExecutable applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetDescriptor_EntryPointExecutable other)
        {
            var descriptor = Object.Equals(this.Descriptor, other.Descriptor);
            var instanceSetType = Object.Equals(this.InstanceSetTypeDescriptor, other.InstanceSetTypeDescriptor);
            var organization = Object.Equals(this.OrganizationDescriptor, other.OrganizationDescriptor);
            var visibility = Object.Equals(this.VisibilityDescriptor, other.VisibilityDescriptor);
            var netVersion = Object.Equals(this.NetVersionDescriptor, other.NetVersionDescriptor);

            var output = true
                && descriptor
                && instanceSetType
                && organization
                && visibility
                && netVersion
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(
                Instances.ArrayOperator.From<object>(
                    this.Descriptor,
                    this.InstanceSetTypeDescriptor,
                    this.OrganizationDescriptor,
                    this.VisibilityDescriptor,
                    this.NetVersionDescriptor)
                );

            return output;
        }

        public override string ToString()
        {
            var output = Instances.InstanceSetDescriptorOperator.To_String(this);
            return output;
        }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class InstanceSetDescriptor_EntryPointExecutable
        {
            public Descriptor Descriptor { get; set; }

            public JsonSerializationObject OrganizationDescriptor { get; set; }

            public JsonSerializationObject VisibilityDescriptor { get; set; }

            public JsonSerializationObject NetVersionDescriptor { get; set; }
        }
    }
}
