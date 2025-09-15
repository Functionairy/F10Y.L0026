using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0026.L001
{
    [FunctionsMarker]
    public partial interface ILocationDescriptorOperator :
        T001.ILocationDescriptorOperator,
        For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ILocationDescriptor>
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public T001.ILocationDescriptorOperator _T001 => T001.LocationDescriptorOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<Type, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ILocationDescriptor>.TextHandlerSuites_ByType
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_LocationDescriptors_ByType;

        Dictionary<string, For_DescriptorTextOperationHandlerSuite.DescriptorTextOperationHandlerSuite<ILocationDescriptor>> For_Bases_IDescriptorTextOperator.IDescriptorTextOperator<ILocationDescriptor>.TextHandlerSuites_ByTypeName
            => Instances.DescriptorTextOperationHandlerSuiteSets.For_LocationDescriptors_ByTypeName;


        public LocationDescriptor_Aggregate From_SerializationType(Serialization_LocationDescriptor_Aggregate locationDescriptor)
        {
            var locationDescriptors = locationDescriptor.LocationDescriptors
                .Select(this.From_JsonSerializationObject)
                .ToArray();

            var output = new LocationDescriptor_Aggregate
            {
                LocationDescriptors = locationDescriptors
            };

            return output;
        }

        public Serialization_LocationDescriptor_Aggregate To_SerializationType(LocationDescriptor_Aggregate locationDescriptor)
        {
            var locationDescriptors = locationDescriptor.LocationDescriptors
                .Select(this.To_JsonSerializationObject)
                .ToArray();

            var output = new Serialization_LocationDescriptor_Aggregate
            {
                LocationDescriptors = locationDescriptors
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(LocationDescriptor_Aggregate locationDescriptor)
        {
            var count = locationDescriptor.LocationDescriptors.Length;

            var output = Instances.EnumerableOperator.From($"{count}: count")
                .Append_Many(locationDescriptor.LocationDescriptors
                    .SelectMany(this.To_Text_ContentOnly_Noexceptive)
                    .Entab()
                )
                ;

            return output;
        }

        public IEnumerable<string> To_Text(LocationDescriptor_Aggregate locationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(locationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(locationDescriptor);

            var output = Instances.EnumerableOperator.From($"Location Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(LocationDescriptor_GitHubRepository locationDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{locationDescriptor.RepositoryUrl}")
                .Append(": GitHub repository URL".Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text(LocationDescriptor_GitHubRepository locationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(locationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(locationDescriptor);

            var output = Instances.EnumerableOperator.From($"Location Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(LocationDescriptor_ProjectFile locationDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{locationDescriptor.ProjectFilePath}")
                .Append(": project file path".Entab())
                ;

            return output;
        }

        public IEnumerable<string> To_Text(LocationDescriptor_ProjectFile locationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(locationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeNameOf_DeclaredType(locationDescriptor);

            var output = Instances.EnumerableOperator.From($"Location Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
