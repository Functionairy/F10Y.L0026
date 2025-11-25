using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface IApplicabilityDescriptorOperator :
        T001.IApplicabilityDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IApplicabilityDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.IApplicabilityDescriptorOperator _T001 => T001.ApplicabilityDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IApplicabilityDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_ApplicabilityDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IApplicabilityDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IApplicabilityDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_ApplicabilityDescriptors_ByTypeName;


        public IEnumerable<string> To_Text_ContentOnly(ApplicabilityDescriptor applicabilityDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{applicabilityDescriptor.Applicability}: applicability")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(ApplicabilityDescriptor applicabilityDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(applicabilityDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(applicabilityDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(ApplicabilityDescriptor_Machine applicabilityDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{applicabilityDescriptor.Machine_Name}: machine")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(ApplicabilityDescriptor_Machine applicabilityDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(applicabilityDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(applicabilityDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(ApplicabilityDescriptor_Organization applicabilityDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{applicabilityDescriptor.Organization_Name}: organization")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(ApplicabilityDescriptor_Organization applicabilityDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(applicabilityDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(applicabilityDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(ApplicabilityDescriptor_Personal applicabilityDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{applicabilityDescriptor.Person_Name}: person")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(ApplicabilityDescriptor_Personal applicabilityDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(applicabilityDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(applicabilityDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(ApplicabilityDescriptor_Project applicabilityDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{applicabilityDescriptor.Project_Name}: project")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(ApplicabilityDescriptor_Project applicabilityDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(applicabilityDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(applicabilityDescriptor);

            var output = Instances.EnumerableOperator.From($"Dependency Set Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
