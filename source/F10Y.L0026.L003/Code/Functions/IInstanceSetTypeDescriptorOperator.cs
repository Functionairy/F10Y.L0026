using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.L0001.L000.Extensions;
using F10Y.T0002;


namespace F10Y.L0026.L003
{
    [FunctionsMarker]
    public partial interface IInstanceSetTypeDescriptorOperator :
        T003.IInstanceSetTypeDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetTypeDescriptor>
    {
        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetTypeDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetTypeDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<IInstanceSetTypeDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<IInstanceSetTypeDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_InstanceSetTypeDescriptors_ByTypeName;


        public Func<IInstanceSetTypeDescriptor, bool> Get_If_HasInstanceSetTypeName_Is(string instanceSetType_Name)
           => instanceSetTypeDescriptor => this.If_HasInstanceSetTypeName_Is(
               instanceSetTypeDescriptor,
               instanceSetType_Name);

        public bool If_HasInstanceSetTypeName_Is(
            IInstanceSetTypeDescriptor instanceSetTypeDescriptor,
            string instanceSetType_Name)
        {
            var output = Instances.PredicateOperator.If_TypeIs<IHas_InstanceSetTypeName>(
                instanceSetTypeDescriptor,
                descriptor => descriptor.InstanceSetType_Name == instanceSetType_Name);

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(InstanceSetTypeDescriptor_Name instanceSetTypeDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{instanceSetTypeDescriptor.InstanceSetType_Name}: instance set type")
                ;

            return output;
        }

        public IEnumerable<string> To_Text(InstanceSetTypeDescriptor_Name instanceSetTypeDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(instanceSetTypeDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(instanceSetTypeDescriptor);

            var output = Instances.EnumerableOperator.From($"Instance Set Type Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
