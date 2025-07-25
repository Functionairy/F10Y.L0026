using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Descriptor for a catch-all library instance set.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetDescriptor_FoundationLibrary :
        IEquatable<InstanceSetDescriptor_FoundationLibrary>,
        IInstanceSetDescriptor,
        IInstanceSetDescriptor_FoundationLibrary,
        //
        IHas_InstanceSetTypeDescriptor,
        IWith_NetVersionDescriptor,
        IWith_OrganizationDescriptor
    {
        public IDescriptor Descriptor { get; set; }

        public IInstanceSetTypeDescriptor InstanceSetTypeDescriptor { get; }
            = Instances.InstanceSetTypeDescriptors.Foundation_Library;

        public IOrganizationDescriptor OrganizationDescriptor { get; set; }

        public INetVersionDescriptor NetVersionDescriptor { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetDescriptor_FoundationLibrary applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetDescriptor_FoundationLibrary other)
        {
            var descriptor = Object.Equals(this.Descriptor, other.Descriptor);
            var instanceSetType = Object.Equals(this.InstanceSetTypeDescriptor, other.InstanceSetTypeDescriptor);
            var organization = Object.Equals(this.OrganizationDescriptor, other.OrganizationDescriptor);
            var netVersion = Object.Equals(this.NetVersionDescriptor, other.NetVersionDescriptor);

            var output = true
                && descriptor
                && instanceSetType
                && organization
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
}
