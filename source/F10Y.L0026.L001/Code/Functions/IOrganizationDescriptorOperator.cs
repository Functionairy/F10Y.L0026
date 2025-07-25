using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.L0000.Extensions;
using F10Y.L0026.T000;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface IOrganizationDescriptorOperator :
        T001.IOrganizationDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOrganizationDescriptor>,
        For_Bases_IPredicateOperator.IPredicateOperator<IOrganizationDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Retained.IOrganizationDescriptorOperator _Retained => Retained.OrganizationDescriptorOperator.Instance;


        [Ignore]
        public T001.IOrganizationDescriptorOperator _T001 => T001.OrganizationDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOrganizationDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_OrganizationDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IOrganizationDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_OrganizationDescriptors_ByTypeName;

        Dictionary<Type, For_PredicateProviderSuite.PredicateProviderSuite<IOrganizationDescriptor>> For_Bases_IPredicateOperator.IPredicateOperator<IOrganizationDescriptor>.PredicateProviderSuites_ByType
            => Instances.PredicateProviderSuiteSets.For_OrganizationDescriptors_ByType;


        public bool Can_Handle(
            IOrganizationDescriptor organizationDescriptor,
            Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> handlerSuites_ByType,
            out For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor> handlerSuite_OrDefault)
        {
            var output = Instances.HandlerSuiteOperator.Can_Handle(
                organizationDescriptor,
                handlerSuites_ByType,
                out handlerSuite_OrDefault);

            return output;
        }

        public bool Can_Handle(
            IOrganizationDescriptor organizationDescriptor,
            out For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor> handlerSuite_OrDefault)
        {
            var handlerSuites_ByType = Instances.DescriptorTextOperationHandlerSuiteSets.For_OrganizationDescriptors_ByType;

            var output = this.Can_Handle(
                organizationDescriptor,
                handlerSuites_ByType,
                out handlerSuite_OrDefault);

            return output;
        }

        public IEnumerable<For_Results.N005.IResult<IOrganizationDescriptor, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>>>
            Can_Handle(
            IEnumerable<IOrganizationDescriptor> organizationDescriptors,
            Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> handlerSuites_ByType)
        {
            var output = Instances.HandlerSuiteOperator.Can_Handle(
                organizationDescriptors,
                handlerSuites_ByType);

            return output;
        }

        public OrganizationDescriptor_Name From_JsonSerializationObject(
            JsonSerializationObject jsonSerializationObject,
            For_OverloadTokens.OverloadToken_Output<OrganizationDescriptor_Name> _)
        {
            var output = Instances.JsonOperator.From_JsonSerializationObject<OrganizationDescriptor_Name>(
                jsonSerializationObject);

            return output;
        }

        public Func<IOrganizationDescriptor, bool> Get_PredicateFor(OrganizationDescriptor_Name organizationDescriptor)
            => organizationDescriptor_Other => this.If_HasOrganizationName_Is(
                organizationDescriptor_Other,
                organizationDescriptor.Organization_Name);

        public Func<IOrganizationDescriptor, bool> Get_PredicateFor(OrganizationDescriptor_Invalid organizationDescriptor)
            => Instances.Predicates.For<IOrganizationDescriptor>().False;

        public Func<IOrganizationDescriptor, bool> Get_If_HasOrganizationName_Is(string organizationName)
            => organizationDescriptor => this.If_HasOrganizationName_Is(
                organizationDescriptor,
                organizationName);

        public bool If_HasOrganizationName_Is(
            IOrganizationDescriptor organizationDescriptor,
            string organizationName)
        {
            var output = Instances.PredicateOperator.If_TypeIs<IHas_OrganizationName>(
                organizationDescriptor,
                descriptor => descriptor.Organization_Name == organizationName);

            return output;
        }

        public JsonSerializationObject To_JsonSerializationObject(OrganizationDescriptor_Name organizationDescriptor)
            => Instances.JsonOperator.To_JsonSerializationObject(
                organizationDescriptor);

        public IEnumerable<string> To_Text_ContentOnly(OrganizationDescriptor_Name organizationDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{organizationDescriptor.Organization_Name}: organization name")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(OrganizationDescriptor_Name organizationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(organizationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(organizationDescriptor);

            var output = Instances.EnumerableOperator.From($"Organization Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_DefaultForUnhandled(IOrganizationDescriptor organizationDescriptor)
        {
            var typeName = Instances.TypeNameOperator.Get_TypeNameOf(organizationDescriptor);

            var output = Instances.EnumerableOperator.From($"UNHANDLED - Organization Descriptor ({typeName})")
                ;

            return output;
        }

        public IEnumerable<string> To_Text_DefaultIfUnhandled(
            IOrganizationDescriptor organizationDescriptor,
            Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> handlerSuites_ByType)
        {
            var can_Handle = this.Can_Handle(
                organizationDescriptor,
                handlerSuites_ByType,
                out var handlerSuite_OrDefault);

            var output = can_Handle
                ? handlerSuite_OrDefault.To_Text(organizationDescriptor)
                : this.To_Text_DefaultForUnhandled(organizationDescriptor)
                ;

            return output;
        }

        public IEnumerable<string> To_Text_DefaultIfUnhandled(IOrganizationDescriptor organizationDescriptor)
        {
            var output = this.To_Text_DefaultIfUnhandled(
                organizationDescriptor,
                Instances.DescriptorTextOperationHandlerSuiteSets.For_OrganizationDescriptors_ByType);

            return output;
        }

        public IEnumerable<string> To_Text_DefaultIfUnhandled(
            IEnumerable<IOrganizationDescriptor> organizationDescriptors,
            Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> handlerSuites_ByType)
        {
            var output = organizationDescriptors.SelectMany(this.To_Text_DefaultIfUnhandled);
            return output;
        }

        public IEnumerable<string> To_Text_DefaultIfUnhandled(IEnumerable<IOrganizationDescriptor> organizationDescriptors)
        {
            var output = this.To_Text_DefaultIfUnhandled(
                organizationDescriptors,
                Instances.DescriptorTextOperationHandlerSuiteSets.For_OrganizationDescriptors_ByType);

            return output;
        }

        public IEnumerable<string> To_Text_ExceptionIfUnhandled(
            IOrganizationDescriptor organizationDescriptor,
            Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> handlerSuites_ByType)
        {
            var can_Handle = this.Can_Handle(
                organizationDescriptor,
                handlerSuites_ByType,
                out var handlerSuite_OrDefault);

            if (can_Handle)
            {
                var output = handlerSuite_OrDefault.To_Text(organizationDescriptor);
                return output;
            }
            else
            {
                var implementationType_TypeName = Instances.TypeOperator.Get_TypeName_OfImplementationType(organizationDescriptor);

                var message = $"No handler suite found for organization descriptor type '{implementationType_TypeName}'";

                throw Instances.ExceptionOperator.From(message);
            }
        }

        public IEnumerable<string> To_Text_ExceptionIfUnhandled(IOrganizationDescriptor organizationDescriptor)
        {
            var output = this.To_Text_ExceptionIfUnhandled(
                organizationDescriptor,
                Instances.DescriptorTextOperationHandlerSuiteSets.For_OrganizationDescriptors_ByType);

            return output;
        }

        public IEnumerable<string> To_Text_ExceptionIfUnhandled(
            IEnumerable<IOrganizationDescriptor> organizationDescriptors,
            Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IOrganizationDescriptor>> handlerSuites_ByType)
        {
            var output = organizationDescriptors.SelectMany(this.To_Text_ExceptionIfUnhandled);
            return output;
        }

        public IEnumerable<string> To_Text_ExceptionIfUnhandled(IEnumerable<IOrganizationDescriptor> organizationDescriptors)
        {
            var output = this.To_Text_ExceptionIfUnhandled(
                organizationDescriptors,
                Instances.DescriptorTextOperationHandlerSuiteSets.For_OrganizationDescriptors_ByType);

            return output;
        }
    }
}
