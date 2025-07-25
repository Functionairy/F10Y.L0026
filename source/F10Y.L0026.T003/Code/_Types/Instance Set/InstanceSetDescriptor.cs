using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// A general instance set descriptor.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetDescriptor : IInstanceSetDescriptor,
        IEquatable<InstanceSetDescriptor>,
        IInstanceSetDescriptor_General,
        //
        IWith_ApplicabilityDescriptor,
        IWith_DependencySetDescriptor,
        IWith_Descriptor,
        IWith_DomainDescriptor,
        IWith_InstanceSetTypeDescriptor,
        IWith_InstanceVarietyDescriptor,
        IWith_NetVersionDescriptor,
        IWith_OpinionDescriptor,
        IWith_OrganizationDescriptor,
        IWith_VisibilityDescriptor
    {
        public IDescriptor Descriptor { get; set; }

        public IInstanceSetTypeDescriptor InstanceSetTypeDescriptor { get; set; }

        public IInstanceVarietyDescriptor InstanceVarietyDescriptor { get; set; }

        public IOrganizationDescriptor OrganizationDescriptor { get; set; }

        public IVisibilityDescriptor VisibilityDescriptor { get; set; }

        public INetVersionDescriptor NetVersionDescriptor { get; set; }

        public IDependencySetDescriptor DependencySetDescriptor { get; set; }

        public IApplicabilityDescriptor ApplicabilityDescriptor { get; set; }

        public IDomainDescriptor DomainDescriptor { get; set; }

        public IOpinionDescriptor OpinionDescriptor { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetDescriptor applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetDescriptor other)
        {
            var descriptor = Object.Equals(this.Descriptor, other.Descriptor);
            var instanceSetType = Object.Equals(this.InstanceSetTypeDescriptor, other.InstanceSetTypeDescriptor);
            var instanceVariety = Object.Equals(this.InstanceVarietyDescriptor, other.InstanceVarietyDescriptor);
            var organization = Object.Equals(this.OrganizationDescriptor, other.OrganizationDescriptor);
            var visibility = Object.Equals(this.VisibilityDescriptor, other.VisibilityDescriptor);
            var netVersion = Object.Equals(this.NetVersionDescriptor, other.NetVersionDescriptor);
            var dependencySet = Object.Equals(this.DependencySetDescriptor, other.DependencySetDescriptor);
            var applicability = Object.Equals(this.ApplicabilityDescriptor, other.ApplicabilityDescriptor);
            var domain = Object.Equals(this.DomainDescriptor, other.DomainDescriptor);
            var opinion = Object.Equals(this.OpinionDescriptor, other.OpinionDescriptor);

            var output = true
                && descriptor
                && instanceSetType
                && instanceVariety
                && organization
                && visibility
                && netVersion
                && dependencySet
                && applicability
                && domain
                && opinion
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode_OfArray(
                Instances.ArrayOperator.From<object>(
                    this.Descriptor,
                    this.InstanceSetTypeDescriptor,
                    this.InstanceVarietyDescriptor,
                    this.OrganizationDescriptor,
                    this.VisibilityDescriptor,
                    this.NetVersionDescriptor,
                    this.DependencySetDescriptor,
                    this.ApplicabilityDescriptor,
                    this.DomainDescriptor,
                    this.OpinionDescriptor)
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
        /// <summary>
        /// Serialization type for <see cref="T003.InstanceSetDescriptor"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetDescriptor
        {
            public JsonSerializationObject Descriptor { get; set; }

            public JsonSerializationObject InstanceSetTypeDescriptor { get; set; }

            public JsonSerializationObject VarietyDescriptor { get; set; }

            public JsonSerializationObject OrganizationDescriptor { get; set; }

            public JsonSerializationObject VisibilityDescriptor { get; set; }

            public JsonSerializationObject NetVersionDescriptor { get; set; }

            public JsonSerializationObject DependencySetDescriptor { get; set; }

            public JsonSerializationObject ApplicabilityDescriptor { get; set; }

            public JsonSerializationObject DomainDescriptor { get; set; }

            public JsonSerializationObject OpinionDescriptor { get; set; }
        }
    }
}
