using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// Descriptor for a catch-all library instance set.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetDescriptor_CatchAllLibrary :
        IEquatable<InstanceSetDescriptor_CatchAllLibrary>,
        IInstanceSetDescriptor,
        IInstanceSetDescriptor_CatchAllLibrary,
        //
        IWith_Descriptor,
        IHas_InstanceSetTypeDescriptor,
        IWith_NetVersionDescriptor,
        IWith_OrganizationDescriptor,
        IWith_VisibilityDescriptor
    {
        public IDescriptor Descriptor { get; set; }

        public IInstanceSetTypeDescriptor InstanceSetTypeDescriptor { get; }
            = Instances.InstanceSetTypeDescriptors.CatchAll_Library;

        public IOrganizationDescriptor OrganizationDescriptor { get; set; }

        public IVisibilityDescriptor VisibilityDescriptor { get; set; }

        public INetVersionDescriptor NetVersionDescriptor { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetDescriptor_CatchAllLibrary applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetDescriptor_CatchAllLibrary other)
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
        public class InstanceSetDescriptor_CatchAllLibrary
        {
            public Descriptor Descriptor { get; set; }

            public JsonSerializationObject OrganizationDescriptor { get; set; }

            public JsonSerializationObject VisibilityDescriptor { get; set; }

            public JsonSerializationObject NetVersionDescriptor { get; set; }
        }
    }
}
