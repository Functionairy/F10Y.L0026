using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L003
{
    [FunctionsMarker]
    public partial interface IInstanceSetDescriptorOperator :
        T003.IInstanceSetDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T003.IInstanceSetDescriptorOperator _T003 => T003.InstanceSetDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetDescriptors_ByTypeName;


        /// <summary>
        /// Using the various IHasX interfaces implemented by <see cref="InstanceSetDescriptor"/> (for example, <see cref="IHas_ApplicabilityDescriptor"/>),
        /// create a general instance set descriptor from any type that implements <see cref="IInstanceSetDescriptor"/>.
        /// </summary>
        public InstanceSetDescriptor From(
            IInstanceSetDescriptor instanceSetDescriptor_Other,
            IDescriptor descriptor)
        {
            var output = new InstanceSetDescriptor()
            {
                Descriptor = descriptor,
            };

            Instances.TypeOperator.If_TypeIs<IHas_ApplicabilityDescriptor>(
                instanceSetDescriptor_Other,
                has_ApplicabilityDescriptor =>
                {
                    output.ApplicabilityDescriptor = has_ApplicabilityDescriptor.ApplicabilityDescriptor;
                });

            Instances.TypeOperator.If_TypeIs<IHas_DependencySetDescriptor>(
                instanceSetDescriptor_Other,
                has_DependencySetDescriptor =>
                {
                    output.DependencySetDescriptor = has_DependencySetDescriptor.DependencySetDescriptor;
                });

            Instances.TypeOperator.If_TypeIs<IHas_DomainDescriptor>(
                instanceSetDescriptor_Other,
                has_DomainDescriptor =>
                {
                    output.DomainDescriptor = has_DomainDescriptor.DomainDescriptor;
                });

            Instances.TypeOperator.If_TypeIs<IHas_InstanceSetTypeDescriptor>(
                instanceSetDescriptor_Other,
                has_InstanceSetTypeDescriptor =>
                {
                    output.InstanceSetTypeDescriptor = has_InstanceSetTypeDescriptor.InstanceSetTypeDescriptor;
                });

            Instances.TypeOperator.If_TypeIs<IHas_InstanceVarietyDescriptor>(
                instanceSetDescriptor_Other,
                has_InstanceVarietyDescriptor =>
                {
                    output.InstanceVarietyDescriptor = has_InstanceVarietyDescriptor.InstanceVarietyDescriptor;
                });

            Instances.TypeOperator.If_TypeIs<IHas_NetVersionDescriptor>(
                instanceSetDescriptor_Other,
                has_NetVersionDescriptor =>
                {
                    output.NetVersionDescriptor = has_NetVersionDescriptor.NetVersionDescriptor;
                });

            Instances.TypeOperator.If_TypeIs<IHas_OpinionDescriptor>(
                instanceSetDescriptor_Other,
                has_OpinionDescriptor =>
                {
                    output.OpinionDescriptor = has_OpinionDescriptor.OpinionDescriptor;
                });

            Instances.TypeOperator.If_TypeIs<IHas_OrganizationDescriptor>(
                instanceSetDescriptor_Other,
                has_OrganizationDescriptor =>
                {
                    output.OrganizationDescriptor = has_OrganizationDescriptor.OrganizationDescriptor;
                });

            Instances.TypeOperator.If_TypeIs<IHas_VisibilityDescriptor>(
                instanceSetDescriptor_Other,
                has_VisibilityDescriptor =>
                {
                    output.VisibilityDescriptor = has_VisibilityDescriptor.VisibilityDescriptor;
                });

            return output;
        }

        /// <inheritdoc cref="From(IInstanceSetDescriptor, IDescriptor)"/>
        public InstanceSetDescriptor From(IInstanceSetDescriptor instanceSetDescriptor_Other)
        {
            var output = this.From(
                instanceSetDescriptor_Other,
                instanceSetDescriptor_Other.Descriptor);

            return output;
        }

        public InstanceSetDescriptor From_SerializationType(Serialization_InstanceSetDescriptor instanceSetDescriptor)
        {
            var applicabilityDescriptor = Instances.ApplicabilityDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.ApplicabilityDescriptor);
            var dependencySetDescriptor = Instances.DependencySetDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.DependencySetDescriptor);
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.Descriptor);
            var domainDescriptor = Instances.DomainDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.DomainDescriptor);
            var instanceSetTypeDescriptor = Instances.InstanceSetTypeDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.InstanceSetTypeDescriptor);
            var netVersionDescriptor = Instances.NetVersionDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.NetVersionDescriptor);
            var opinionDescriptor = Instances.OpinionDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.OpinionDescriptor);
            var organizationDescriptor = Instances.OrganizationDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.OrganizationDescriptor);
            var varietyDescriptor = Instances.InstanceVarietyDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.VarietyDescriptor);
            var visibilityDescriptor = Instances.VisibilityDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.VisibilityDescriptor);

            var output = new InstanceSetDescriptor
            {
                Descriptor = descriptor,

                InstanceSetTypeDescriptor = instanceSetTypeDescriptor,

                InstanceVarietyDescriptor = varietyDescriptor,
                OrganizationDescriptor = organizationDescriptor,
                VisibilityDescriptor = visibilityDescriptor,

                NetVersionDescriptor = netVersionDescriptor,
                DependencySetDescriptor = dependencySetDescriptor,

                ApplicabilityDescriptor = applicabilityDescriptor,
                DomainDescriptor = domainDescriptor,
                OpinionDescriptor = opinionDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetDescriptor To_SerializationType(InstanceSetDescriptor instanceSetDescriptor)
        {
            var applicabilityDescriptor = Instances.ApplicabilityDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.ApplicabilityDescriptor);
            var dependencySetDescriptor = Instances.DependencySetDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.DependencySetDescriptor);
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.Descriptor);
            var domainDescriptor = Instances.DomainDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.DomainDescriptor);
            var instanceSetTypeDescriptor = Instances.InstanceSetTypeDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.InstanceSetTypeDescriptor);
            var netVersionDescriptor = Instances.NetVersionDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.NetVersionDescriptor);
            var opinionDescriptor = Instances.OpinionDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.OpinionDescriptor);
            var organizationDescriptor = Instances.OrganizationDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.OrganizationDescriptor);
            var varietyDescriptor = Instances.InstanceVarietyDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.InstanceVarietyDescriptor);
            var visibilityDescriptor = Instances.VisibilityDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.VisibilityDescriptor);

            var output = new Serialization_InstanceSetDescriptor
            {
                Descriptor = descriptor,

                InstanceSetTypeDescriptor = instanceSetTypeDescriptor,

                VarietyDescriptor = varietyDescriptor,
                OrganizationDescriptor = organizationDescriptor,
                VisibilityDescriptor = visibilityDescriptor,

                NetVersionDescriptor = netVersionDescriptor,
                DependencySetDescriptor = dependencySetDescriptor,

                ApplicabilityDescriptor = applicabilityDescriptor,
                DomainDescriptor = domainDescriptor,
                OpinionDescriptor = opinionDescriptor,
            };

            return output;
        }

        public InstanceSetDescriptor_CatchAllLibrary From_SerializationType(Serialization_InstanceSetDescriptor_CatchAllLibrary instanceSetDescriptor)
        {
            var descriptor = instanceSetDescriptor.Descriptor;
            var netVersionDescriptor = Instances.NetVersionDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.NetVersionDescriptor);
            var organizationDescriptor = Instances.OrganizationDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.OrganizationDescriptor);
            var visibilityDescriptor = Instances.VisibilityDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.VisibilityDescriptor);

            var output = new InstanceSetDescriptor_CatchAllLibrary
            {
                Descriptor = descriptor,

                NetVersionDescriptor = netVersionDescriptor,
                OrganizationDescriptor = organizationDescriptor,
                VisibilityDescriptor = visibilityDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetDescriptor_CatchAllLibrary To_SerializationType(InstanceSetDescriptor_CatchAllLibrary instanceSetDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_Descriptor(instanceSetDescriptor.Descriptor);
            var netVersionDescriptor = Instances.NetVersionDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.NetVersionDescriptor);
            var organizationDescriptor = Instances.OrganizationDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.OrganizationDescriptor);
            var visibilityDescriptor = Instances.VisibilityDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.VisibilityDescriptor);

            var output = new Serialization_InstanceSetDescriptor_CatchAllLibrary
            {
                Descriptor = descriptor,

                NetVersionDescriptor = netVersionDescriptor,
                OrganizationDescriptor = organizationDescriptor,
                VisibilityDescriptor = visibilityDescriptor,
            };

            return output;
        }

        public InstanceSetDescriptor_EntryPointExecutable From_SerializationType(Serialization_InstanceSetDescriptor_EntryPointExecutable instanceSetDescriptor)
        {
            var descriptor = instanceSetDescriptor.Descriptor;
            var netVersionDescriptor = Instances.NetVersionDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.NetVersionDescriptor);
            var organizationDescriptor = Instances.OrganizationDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.OrganizationDescriptor);
            var visibilityDescriptor = Instances.VisibilityDescriptorOperator.From_JsonSerializationObject(instanceSetDescriptor.VisibilityDescriptor);

            var output = new InstanceSetDescriptor_EntryPointExecutable
            {
                Descriptor = descriptor,

                NetVersionDescriptor = netVersionDescriptor,
                OrganizationDescriptor = organizationDescriptor,
                VisibilityDescriptor = visibilityDescriptor
            };

            return output;
        }

        public Serialization_InstanceSetDescriptor_EntryPointExecutable To_SerializationType(InstanceSetDescriptor_EntryPointExecutable instanceSetDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_Descriptor(instanceSetDescriptor.Descriptor);
            var netVersionDescriptor = Instances.NetVersionDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.NetVersionDescriptor);
            var organizationDescriptor = Instances.OrganizationDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.OrganizationDescriptor);
            var visibilityDescriptor = Instances.VisibilityDescriptorOperator.To_JsonSerializationObject(instanceSetDescriptor.VisibilityDescriptor);

            var output = new Serialization_InstanceSetDescriptor_EntryPointExecutable
            {
                Descriptor = descriptor,

                NetVersionDescriptor = netVersionDescriptor,
                OrganizationDescriptor = organizationDescriptor,
                VisibilityDescriptor = visibilityDescriptor
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetDescriptor instanceSetDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.Descriptor);
            var variety_Lines = Instances.InstanceVarietyDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.InstanceVarietyDescriptor);
            var organization_Lines = Instances.OrganizationDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.OrganizationDescriptor);
            var instanceSetType_Lines = Instances.InstanceSetTypeDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.InstanceSetTypeDescriptor);
            var visibility_Lines = Instances.VisibilityDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.VisibilityDescriptor);
            var netVersion_Lines = Instances.NetVersionDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.NetVersionDescriptor);
            var dependencySet_Lines = Instances.DependencySetDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.DependencySetDescriptor);
            var applicability_Lines = Instances.ApplicabilityDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.ApplicabilityDescriptor);
            var domain_Lines = Instances.DomainDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.DomainDescriptor);
            var opinion_Lines = Instances.OpinionDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.OpinionDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Set Type:")
                    .Append_Many(instanceSetType_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Variety:")
                    .Append_Many(variety_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Organization:")
                    .Append_Many(organization_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Visibility:")
                    .Append_Many(visibility_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From(".NET Version:")
                    .Append_Many(netVersion_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Dependency Set:")
                    .Append_Many(dependencySet_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Applicability:")
                    .Append_Many(applicability_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Domain:")
                    .Append_Many(domain_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Opinion:")
                    .Append_Many(opinion_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetDescriptor instanceSetDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(instanceSetDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetDescriptor_CatchAllLibrary instanceSetDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.Descriptor);
            var netVersion_Lines = Instances.NetVersionDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.NetVersionDescriptor);
            var organization_Lines = Instances.OrganizationDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.OrganizationDescriptor);
            var visibility_Lines = Instances.VisibilityDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.VisibilityDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Organization:")
                    .Append_Many(organization_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Visibility:")
                    .Append_Many(visibility_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From(".NET Version:")
                    .Append_Many(netVersion_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetDescriptor_CatchAllLibrary instanceSetDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(instanceSetDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetDescriptor_EntryPointExecutable instanceSetDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.Descriptor);
            var netVersion_Lines = Instances.NetVersionDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.NetVersionDescriptor);
            var organization_Lines = Instances.OrganizationDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.OrganizationDescriptor);
            var visibility_Lines = Instances.VisibilityDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetDescriptor.VisibilityDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Organization:")
                    .Append_Many(organization_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Visibility:")
                    .Append_Many(visibility_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From(".NET Version:")
                    .Append_Many(netVersion_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetDescriptor_EntryPointExecutable instanceSetDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(instanceSetDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
