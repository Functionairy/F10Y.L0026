using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.L0000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L004
{
    [FunctionsMarker]
    public partial interface IInstanceSetSearchDescriptorOperator :
        T004.IInstanceSetSearchDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetSearchDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IInstanceSetSearchDescriptor, IInstanceSetDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T004.IInstanceSetSearchDescriptorOperator _T004 => T004.InstanceSetSearchDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetSearchDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetSearchDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetSearchDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetSearchDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetSearchDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IInstanceSetSearchDescriptor, IInstanceSetDescriptor>> For_Bases_IPredicateOperator.IPredicateOperator<IInstanceSetSearchDescriptor, IInstanceSetDescriptor>.PredicateProviderSuites_ByType
            => Instances.PredicateProviderSuiteSets.For_InstanceSetSearchDescriptors_ByType;


        public InstanceSetSearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor instanceSetSearchDescriptor)
        {
            //var applicabilityDescriptor = Instances.ApplicabilityDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.ApplicabilityDescriptor);
            //var dependencySetDescriptor = Instances.DependencySetDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.DependencySetDescriptor);
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);
            //var domainDescriptor = Instances.DomainDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.DomainDescriptor);
            var instanceSetTypeSearchDescriptor = Instances.InstanceSetTypeSearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.InstanceSetTypeSearchDescriptor);
            //var netVersionDescriptor = Instances.NetVersionDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.NetVersionDescriptor);
            //var opinionDescriptor = Instances.OpinionDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.OpinionDescriptor);
            var organizationSearchDescriptor = Instances.OrganizationSearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.OrganizationSearchDescriptor);
            var varietySearchDescriptor = Instances.InstanceVarietySearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.VarietySearchDescriptor);
            var visibilitySearchDescriptor = Instances.VisibilitySearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.VisibilitySearchDescriptor);

            var output = new InstanceSetSearchDescriptor
            {
                Descriptor = descriptor,

                InstanceSetTypeSearchDescriptor = instanceSetTypeSearchDescriptor,

                InstanceVarietySearchDescriptor = varietySearchDescriptor,
                OrganizationSearchDescriptor = organizationSearchDescriptor,
                VisibilitySearchDescriptor = visibilitySearchDescriptor,

                //NetVersionDescriptor = netVersionDescriptor,
                //DependencySetDescriptor = dependencySetDescriptor,

                //ApplicabilityDescriptor = applicabilityDescriptor,
                //DomainDescriptor = domainDescriptor,
                //OpinionDescriptor = opinionDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor To_SerializationType(InstanceSetSearchDescriptor instanceSetSearchDescriptor)
        {
            //var applicabilityDescriptor = Instances.ApplicabilityDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.ApplicabilityDescriptor);
            //var dependencySetDescriptor = Instances.DependencySetDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.DependencySetDescriptor);
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);
            //var domainDescriptor = Instances.DomainDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.DomainDescriptor);
            var instanceSetTypeSearchDescriptor = Instances.InstanceSetTypeSearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.InstanceSetTypeSearchDescriptor);
            //var netVersionDescriptor = Instances.NetVersionDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.NetVersionDescriptor);
            //var opinionDescriptor = Instances.OpinionDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.OpinionDescriptor);
            var organizationSearchDescriptor = Instances.OrganizationSearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.OrganizationSearchDescriptor);
            var varietySearchDescriptor = Instances.InstanceVarietySearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.InstanceVarietySearchDescriptor);
            var visibilitySearchDescriptor = Instances.VisibilitySearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.VisibilitySearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor
            {
                Descriptor = descriptor,

                InstanceSetTypeSearchDescriptor = instanceSetTypeSearchDescriptor,

                VarietySearchDescriptor = varietySearchDescriptor,
                OrganizationSearchDescriptor = organizationSearchDescriptor,
                VisibilitySearchDescriptor = visibilitySearchDescriptor,

                //NetVersionDescriptor = netVersionDescriptor,
                //DependencySetDescriptor = dependencySetDescriptor,

                //ApplicabilityDescriptor = applicabilityDescriptor,
                //DomainDescriptor = domainDescriptor,
                //OpinionDescriptor = opinionDescriptor,
            };

            return output;
        }


        public InstanceSetSearchDescriptor_Aggregate From_SerializationType(Serialization_InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var instanceSetSearchDescriptors = instanceSetSearchDescriptor.InstanceSetSearchDescriptors
                .Select(this.From_JsonSerializationObject)
                .ToArray();

            var output = new InstanceSetSearchDescriptor_Aggregate
            {
                Descriptor = descriptor,

                InstanceSetSearchDescriptors = instanceSetSearchDescriptors,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_Aggregate To_SerializationType(InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var instanceSetSearchDescriptors = instanceSetSearchDescriptor.InstanceSetSearchDescriptors
                .Select(this.To_JsonSerializationObject)
                .ToArray();

            var output = new Serialization_InstanceSetSearchDescriptor_Aggregate
            {
                Descriptor = descriptor,

                InstanceSetSearchDescriptors = instanceSetSearchDescriptors,
            };

            return output;
        }

        public N001_InstanceSetSearchDescriptor_Aggregate From_SerializationType(N001_Serialization_InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);
            var anyOrAll = Instances.AnyOrAllOperator.From_String(instanceSetSearchDescriptor.AnyOrAll);

            var instanceSetSearchDescriptors = instanceSetSearchDescriptor.InstanceSetSearchDescriptors
                .Select(this.From_JsonSerializationObject)
                .ToArray();

            var output = new N001_InstanceSetSearchDescriptor_Aggregate
            {
                Descriptor = descriptor,

                InstanceSetSearchDescriptors = instanceSetSearchDescriptors,
                AnyOrAll = anyOrAll
            };

            return output;
        }

        public N001_Serialization_InstanceSetSearchDescriptor_Aggregate To_SerializationType(N001_InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);
            var anyOrAll = Instances.AnyOrAllOperator.To_String(instanceSetSearchDescriptor.AnyOrAll);

            var instanceSetSearchDescriptors = instanceSetSearchDescriptor.InstanceSetSearchDescriptors
                .Select(this.To_JsonSerializationObject)
                .ToArray();

            var output = new N001_Serialization_InstanceSetSearchDescriptor_Aggregate
            {
                Descriptor = descriptor,

                InstanceSetSearchDescriptors = instanceSetSearchDescriptors,
                AnyOrAll = anyOrAll
            };

            return output;
        }

        public N002_InstanceSetSearchDescriptor_Aggregate From_SerializationType(N002_Serialization_InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var all_InstanceSetSearchDescriptors = instanceSetSearchDescriptor.All_Set
                .Select(this.From_JsonSerializationObject)
                .ToArray();
            var any_InstanceSetSearchDescriptors = instanceSetSearchDescriptor.Any_Set
                .Select(this.From_JsonSerializationObject)
                .ToArray();

            var output = new N002_InstanceSetSearchDescriptor_Aggregate
            {
                Descriptor = descriptor,

                All_Set = all_InstanceSetSearchDescriptors,
                Any_Set = any_InstanceSetSearchDescriptors,
            };

            return output;
        }

        public N002_Serialization_InstanceSetSearchDescriptor_Aggregate To_SerializationType(N002_InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var all_InstanceSetSearchDescriptors = instanceSetSearchDescriptor.All_Set
                .Select(this.To_JsonSerializationObject)
                .ToArray();
            var any_InstanceSetSearchDescriptors = instanceSetSearchDescriptor.Any_Set
                .Select(this.To_JsonSerializationObject)
                .ToArray();

            var output = new N002_Serialization_InstanceSetSearchDescriptor_Aggregate
            {
                Descriptor = descriptor,

                All_Set = all_InstanceSetSearchDescriptors,
                Any_Set = any_InstanceSetSearchDescriptors,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_OrganizationSearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor_OrganizationSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var organizationSearchDescriptor = Instances.OrganizationSearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.OrganizationSearchDescriptor);

            var output = new InstanceSetSearchDescriptor_OrganizationSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                OrganizationSearchDescriptor = organizationSearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_OrganizationSearchDescriptor To_SerializationType(InstanceSetSearchDescriptor_OrganizationSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var organizationSearchDescriptor = Instances.OrganizationSearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.OrganizationSearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor_OrganizationSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                OrganizationSearchDescriptor = organizationSearchDescriptor,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var instanceSetTypeSearchDescriptor = Instances.InstanceSetTypeSearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.InstanceSetTypeSearchDescriptor);

            var output = new InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                InstanceSetTypeSearchDescriptor = instanceSetTypeSearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor To_SerializationType(InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var instanceSetTypeSearchDescriptor = Instances.InstanceSetTypeSearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.InstanceSetTypeSearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                InstanceSetTypeSearchDescriptor = instanceSetTypeSearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_VisibilitySearchDescriptor To_SerializationType(InstanceSetSearchDescriptor_VisibilitySearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var visibilitySearchDescriptor = Instances.VisibilitySearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.VisibilitySearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor_VisibilitySearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                VisibilitySearchDescriptor = visibilitySearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_DependencySetSearchDescriptor To_SerializationType(InstanceSetSearchDescriptor_DependencySetSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var dependencySetSearchDescriptor = Instances.DependencySetSearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.DependencySetSearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor_DependencySetSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                DependencySetSearchDescriptor = dependencySetSearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor To_SerializationType(InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var applicabilitySearchDescriptor = Instances.ApplicabilitySearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.ApplicabilitySearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                ApplicabilitySearchDescriptor = applicabilitySearchDescriptor,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_VisibilitySearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor_VisibilitySearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var visibilitySearchDescriptor = Instances.VisibilitySearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.VisibilitySearchDescriptor);

            var output = new InstanceSetSearchDescriptor_VisibilitySearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                VisibilitySearchDescriptor = visibilitySearchDescriptor,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_DependencySetSearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor_DependencySetSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var dependencySetSearchDescriptor = Instances.DependencySetSearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.DependencySetSearchDescriptor);

            var output = new InstanceSetSearchDescriptor_DependencySetSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                DependencySetSearchDescriptor = dependencySetSearchDescriptor,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var applicabilitySearchDescriptor = Instances.ApplicabilitySearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.ApplicabilitySearchDescriptor);

            var output = new InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                ApplicabilitySearchDescriptor = applicabilitySearchDescriptor,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var instanceVarietySearchDescriptor = Instances.InstanceVarietySearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.InstanceVarietySearchDescriptor);

            var output = new InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                InstanceVarietySearchDescriptor = instanceVarietySearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor To_SerializationType(InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var instanceVarietySearchDescriptor = Instances.InstanceVarietySearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.InstanceVarietySearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                InstanceVarietySearchDescriptor = instanceVarietySearchDescriptor,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_DomainSearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor_DomainSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var domainSearchDescriptor = Instances.DomainSearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.DomainSearchDescriptor);

            var output = new InstanceSetSearchDescriptor_DomainSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                DomainSearchDescriptor = domainSearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_DomainSearchDescriptor To_SerializationType(InstanceSetSearchDescriptor_DomainSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var domainSearchDescriptor = Instances.DomainSearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.DomainSearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor_DomainSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                DomainSearchDescriptor = domainSearchDescriptor,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_OpinionSearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor_OpinionSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var opinionSearchDescriptor = Instances.OpinionSearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.OpinionSearchDescriptor);

            var output = new InstanceSetSearchDescriptor_OpinionSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                OpinionSearchDescriptor = opinionSearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_OpinionSearchDescriptor To_SerializationType(InstanceSetSearchDescriptor_OpinionSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var opinionSearchDescriptor = Instances.OpinionSearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.OpinionSearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor_OpinionSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                OpinionSearchDescriptor = opinionSearchDescriptor,
            };

            return output;
        }

        public InstanceSetSearchDescriptor_NetVersionSearchDescriptor From_SerializationType(Serialization_InstanceSetSearchDescriptor_NetVersionSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var netVersionSearchDescriptor = Instances.NetVersionSearchDescriptorOperator.From_JsonSerializationObject(instanceSetSearchDescriptor.NetVersionSearchDescriptor);

            var output = new InstanceSetSearchDescriptor_NetVersionSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                NetVersionSearchDescriptor = netVersionSearchDescriptor,
            };

            return output;
        }

        public Serialization_InstanceSetSearchDescriptor_NetVersionSearchDescriptor To_SerializationType(InstanceSetSearchDescriptor_NetVersionSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor = Instances.DescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.Descriptor);

            var netVersionSearchDescriptor = Instances.NetVersionSearchDescriptorOperator.To_JsonSerializationObject(instanceSetSearchDescriptor.NetVersionSearchDescriptor);

            var output = new Serialization_InstanceSetSearchDescriptor_NetVersionSearchDescriptor
            {
                Descriptor = descriptor,

                Value_IfMissingDescriptor = instanceSetSearchDescriptor.Value_IfMissingDescriptor,
                NetVersionSearchDescriptor = netVersionSearchDescriptor,
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            //var descriptorSearch_Lines = ;
            var varietySearch_Lines = Instances.InstanceVarietySearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.InstanceVarietySearchDescriptor);
            var organizationSearch_Lines = Instances.OrganizationSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.OrganizationSearchDescriptor);
            var instanceSetTypeSearch_Lines = Instances.InstanceSetTypeSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.InstanceSetTypeSearchDescriptor);
            var visibilitySearch_Lines = Instances.VisibilitySearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.VisibilitySearchDescriptor);
            //var netVersionSearch_Lines = Instances.NetVersionDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.NetVersionDescriptor);
            //var dependencySetSearch_Lines = Instances.DependencySetDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.DependencySetDescriptor);
            //var applicabilitySearch_Lines = Instances.ApplicabilityDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.ApplicabilityDescriptor);
            //var domainSearch_Lines = Instances.DomainDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.DomainDescriptor);
            //var opinionSearch_Lines = Instances.OpinionDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.OpinionDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                //Instances.EnumerableOperator.From("Descriptor Search:")
                //    .Append_Many(descriptor_Lines.Entab())
                //    ,
                Instances.EnumerableOperator.From("Set Type:")
                    .Append_Many(instanceSetTypeSearch_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Variety:")
                    .Append_Many(varietySearch_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Organization:")
                    .Append_Many(organizationSearch_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From("Visibility:")
                    .Append_Many(visibilitySearch_Lines.Entab())
                //,
                //Instances.EnumerableOperator.From(".NET Version:")
                //    .Append_Many(netVersion_Lines.Entab())
                //    ,
                //Instances.EnumerableOperator.From("Dependency Set:")
                //    .Append_Many(dependencySet_Lines.Entab())
                //    ,
                //Instances.EnumerableOperator.From("Applicability:")
                //    .Append_Many(applicability_Lines.Entab())
                //    ,
                //Instances.EnumerableOperator.From("Domain:")
                //    .Append_Many(domain_Lines.Entab())
                //    ,
                //Instances.EnumerableOperator.From("Opinion:")
                //    .Append_Many(opinion_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var count = Instances.ArrayOperator.Get_Count(instanceSetSearchDescriptor.InstanceSetSearchDescriptors);

            var subSearch_Lines = instanceSetSearchDescriptor.InstanceSetSearchDescriptors
                .SelectMany(this.To_Text_ContentOnly_Noexceptive)
                ;

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"Sub-Search Descriptors ({count}):")
                    .Append_Many(subSearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(N001_InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var anyOrAll_Token = Instances.AnyOrAllOperator.To_String(instanceSetSearchDescriptor.AnyOrAll);

            var count = Instances.ArrayOperator.Get_Count(instanceSetSearchDescriptor.InstanceSetSearchDescriptors);

            var subSearch_Lines = instanceSetSearchDescriptor.InstanceSetSearchDescriptors
                .SelectMany(this.To_Text_ContentOnly_Noexceptive)
                ;

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{anyOrAll_Token}: any-or-all")
                    ,
                Instances.EnumerableOperator.From($"Sub-Search Descriptors ({count}):")
                    .Append_Many(subSearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(N001_InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(N002_InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var all_Count = Instances.ArrayOperator.Get_Count(instanceSetSearchDescriptor.All_Set);

            var all_SubSearch_Lines = instanceSetSearchDescriptor.All_Set
                .SelectMany(this.To_Text_ContentOnly_Noexceptive)
                ;

            var any_Count = Instances.ArrayOperator.Get_Count(instanceSetSearchDescriptor.All_Set);

            var any_SubSearch_Lines = instanceSetSearchDescriptor.All_Set
                .SelectMany(this.To_Text_ContentOnly_Noexceptive)
                ;

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"ALL Sub-Search Descriptors ({all_Count}):")
                    .Append_Many(all_SubSearch_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"ANY Sub-Search Descriptors ({any_Count}):")
                    .Append_Many(any_SubSearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(N002_InstanceSetSearchDescriptor_Aggregate instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_OrganizationSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var organizationSearch_Lines = Instances.OrganizationSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.OrganizationSearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Value_IfMissingDescriptor}: value, if instance set missing organization descriptor facet")
                    ,
                Instances.EnumerableOperator.From("Organization Search:")
                    .Append_Many(organizationSearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_OrganizationSearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var instanceSetTypeSearch_Lines = Instances.InstanceSetTypeSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.InstanceSetTypeSearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Value_IfMissingDescriptor}: value, if instance set missing instance set type descriptor facet")
                    ,
                Instances.EnumerableOperator.From("Instance Set Type Search:")
                    .Append_Many(instanceSetTypeSearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_OrganizationName instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_OrganizationName instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Organization_Name}: organization name")
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_VisibilitySearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_VisibilitySearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var visibilitySearch_Lines = Instances.VisibilitySearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.VisibilitySearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Value_IfMissingDescriptor}: value, if instance set missing visibility descriptor facet")
                    ,
                Instances.EnumerableOperator.From("Visibility Search:")
                    .Append_Many(visibilitySearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_DependencySetSearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_DependencySetSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var dependencySetSearch_Lines = Instances.DependencySetSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.DependencySetSearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Value_IfMissingDescriptor}: value, if instance set missing instance variety descriptor facet")
                    ,
                Instances.EnumerableOperator.From("Dependency Set Search:")
                    .Append_Many(dependencySetSearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var intanceVarietySearch_Lines = Instances.InstanceVarietySearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.InstanceVarietySearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Value_IfMissingDescriptor}: value, if instance set missing instance variety descriptor facet")
                    ,
                Instances.EnumerableOperator.From("Instance Variety Search:")
                    .Append_Many(intanceVarietySearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_DomainSearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_DomainSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var domainSearch_Lines = Instances.DomainSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.DomainSearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Value_IfMissingDescriptor}: value, if instance set missing instance variety descriptor facet")
                    ,
                Instances.EnumerableOperator.From("Domain Search:")
                    .Append_Many(domainSearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_OpinionSearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_OpinionSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var opinionSearch_Lines = Instances.OpinionSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.OpinionSearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Value_IfMissingDescriptor}: value, if instance set missing instance variety descriptor facet")
                    ,
                Instances.EnumerableOperator.From("Opinion Search:")
                    .Append_Many(opinionSearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var applicabilitySearch_Lines = Instances.ApplicabilitySearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.ApplicabilitySearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Value_IfMissingDescriptor}: value, if instance set missing instance variety descriptor facet")
                    ,
                Instances.EnumerableOperator.From("Applicability Search:")
                    .Append_Many(applicabilitySearch_Lines.Entab())
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetSearchDescriptor_NetVersionSearchDescriptor instanceSetSearchDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetSearchDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetSearchDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Search Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetSearchDescriptor_NetVersionSearchDescriptor instanceSetSearchDescriptor)
        {
            var descriptor_Lines = Instances.DescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.Descriptor);

            var netVersionSearch_Lines = Instances.NetVersionSearchDescriptorOperator.To_Text_ContentOnly_Noexceptive(instanceSetSearchDescriptor.NetVersionSearchDescriptor);

            var output = Instances.EnumerableOperator.From(
                Instances.EnumerableOperator.From("Descriptor:")
                    .Append_Many(descriptor_Lines.Entab())
                    ,
                Instances.EnumerableOperator.From($"{instanceSetSearchDescriptor.Value_IfMissingDescriptor}: value, if instance set missing instance variety descriptor facet")
                    ,
                Instances.EnumerableOperator.From(".NET Version Search:")
                    .Append_Many(netVersionSearch_Lines.Entab())
                )
                ;

            return output;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_InstanceSetTypeSearchDescriptor searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_InstanceSetTypeDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var descriptorPredicate = Instances.InstanceSetTypeSearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.InstanceSetTypeSearchDescriptor);

                        var output = descriptorPredicate(has_FacetDescriptor.InstanceSetTypeDescriptor);
                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_InstanceVarietySearchDescriptor searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_InstanceVarietyDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var instanceVarietyDescriptorPredicate = Instances.InstanceVarietySearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.InstanceVarietySearchDescriptor);

                        var output = instanceVarietyDescriptorPredicate(has_FacetDescriptor.InstanceVarietyDescriptor);
                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_Aggregate searchDescriptor)
        {
            var subPredicates = searchDescriptor.InstanceSetSearchDescriptors
                .Select(this.Get_Predicate_Synchronous)
                .ToArray();

            /// The <see cref="InstanceSetSearchDescriptor_Aggregate"/> is assumed to be AND.
            var output = Instances.PredicateOperator.And(subPredicates);
            return output;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(N001_InstanceSetSearchDescriptor_Aggregate searchDescriptor)
        {
            var subPredicates = searchDescriptor.InstanceSetSearchDescriptors
                .Select(this.Get_Predicate_Synchronous)
                .ToArray();

            /// The <see cref="InstanceSetSearchDescriptor_Aggregate"/> is assumed to be AND.
            var combinator = Instances.AnyOrAllOperator.Switch<Func<ICollection<Func<IInstanceSetDescriptor, bool>>, Func<IInstanceSetDescriptor, bool>>>(
                searchDescriptor.AnyOrAll,
                Instances.PredicateOperator.And,
                Instances.PredicateOperator.Any);

            var output = combinator(subPredicates);
            return output;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(N002_InstanceSetSearchDescriptor_Aggregate searchDescriptor)
        {
            var all_SubPredicates = searchDescriptor.All_Set
                .Select(this.Get_Predicate_Synchronous)
                .ToArray();

            var any_SubPredicates = searchDescriptor.All_Set
                .Select(this.Get_Predicate_Synchronous)
                .ToArray();

            var all_Predicate = Instances.PredicateOperator.And(all_SubPredicates);
            var any_Predicate = Instances.PredicateOperator.And(any_SubPredicates);

            var output = Instances.PredicateOperator.And(
                all_Predicate,
                any_Predicate);

            return output;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_OrganizationSearchDescriptor searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_OrganizationDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var organizationDescriptorPredicate = Instances.OrganizationSearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.OrganizationSearchDescriptor);

                        var output = organizationDescriptorPredicate(has_FacetDescriptor.OrganizationDescriptor);
                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_OrganizationName searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_OrganizationDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var output = Instances.OrganizationDescriptorOperator.If_HasOrganizationName_Is(
                            has_FacetDescriptor.OrganizationDescriptor,
                            searchDescriptor.Organization_Name);

                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_VisibilitySearchDescriptor searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_VisibilityDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var organizationDescriptorPredicate = Instances.VisibilitySearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.VisibilitySearchDescriptor);

                        var output = organizationDescriptorPredicate(has_FacetDescriptor.VisibilityDescriptor);
                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_DependencySetSearchDescriptor searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_DependencySetDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var dependencySetDescriptorPredicate = Instances.DependencySetSearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.DependencySetSearchDescriptor);

                        var output = dependencySetDescriptorPredicate(has_FacetDescriptor.DependencySetDescriptor);
                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_ApplicabilitySearchDescriptor searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_ApplicabilityDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var applicabilityDescriptorPredicate = Instances.ApplicabilitySearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.ApplicabilitySearchDescriptor);

                        var output = applicabilityDescriptorPredicate(has_FacetDescriptor.ApplicabilityDescriptor);
                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_DomainSearchDescriptor searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_DomainDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var domainDescriptorPredicate = Instances.DomainSearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.DomainSearchDescriptor);

                        var output = domainDescriptorPredicate(has_FacetDescriptor.DomainDescriptor);
                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_OpinionSearchDescriptor searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_OpinionDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var opinionDescriptorPredicate = Instances.OpinionSearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.OpinionSearchDescriptor);

                        var output = opinionDescriptorPredicate(has_FacetDescriptor.OpinionDescriptor);
                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }

        public Func<IInstanceSetDescriptor, bool> Get_PredicateFor(InstanceSetSearchDescriptor_NetVersionSearchDescriptor searchDescriptor)
        {
            bool Internal(IInstanceSetDescriptor instanceSetDescriptor)
            {
                // Note: the is-operator returns false for null values.
                var output = Instances.PredicateOperator.If_TypeIs_Else<IHas_NetVersionDescriptor>(
                    instanceSetDescriptor,
                    has_FacetDescriptor =>
                    {
                        var dependencySetDescriptorPredicate = Instances.NetVersionSearchDescriptorOperator.Get_Predicate_Synchronous(searchDescriptor.NetVersionSearchDescriptor);

                        var output = dependencySetDescriptorPredicate(has_FacetDescriptor.NetVersionDescriptor);
                        return output;
                    },
                    searchDescriptor.Value_IfMissingDescriptor);

                return output;
            }

            return Internal;
        }
    }
}
