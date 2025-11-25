using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.L0026.T001;
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


        LocationDescriptor_Aggregate From_SerializationType(Serialization_LocationDescriptor_Aggregate locationDescriptor)
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

        bool Has_ProjectFilePath_FirstOrDefault(
            ILocationDescriptor locationDescriptor,
            out string projectFilePath_OrDefault)
        {
            if (locationDescriptor is LocationDescriptor_ProjectFile projectFile_LocationDescriptor)
            {
                projectFilePath_OrDefault = projectFile_LocationDescriptor.ProjectFilePath;

                return true;
            }

            if (locationDescriptor is LocationDescriptor_Aggregate aggregate_LocationDescriptor)
            {
                var projectFile_LocationDescriptor_FirstOrDefault = aggregate_LocationDescriptor.LocationDescriptors
                    .Where(locationDescriptor => locationDescriptor is LocationDescriptor_ProjectFile)
                    .Cast<LocationDescriptor_ProjectFile>()
                    .FirstOrDefault();

                var is_NotDefault = Instances.DefaultOperator.Is_NotDefault(projectFile_LocationDescriptor_FirstOrDefault);

                projectFilePath_OrDefault = is_NotDefault
                    ? projectFile_LocationDescriptor_FirstOrDefault.ProjectFilePath
                    : default
                    ;

                return is_NotDefault;
            }

            // Else.
            projectFilePath_OrDefault = default;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Chooses <see cref="Has_ProjectFilePath_FirstOrDefault(F10Y.L0026.T006.ILocationDescriptor, out string)"/> as the default.
        /// </remarks>
        bool Has_ProjectFilePath(
            ILocationDescriptor locationDescriptor,
            out string projectFilePath_OrDefault)
            => this.Has_ProjectFilePath_FirstOrDefault(
                locationDescriptor,
                out projectFilePath_OrDefault);

        Serialization_LocationDescriptor_Aggregate To_SerializationType(LocationDescriptor_Aggregate locationDescriptor)
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

        IEnumerable<string> To_Text_ContentOnly(LocationDescriptor_Aggregate locationDescriptor)
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

        IEnumerable<string> To_Text(LocationDescriptor_Aggregate locationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(locationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(locationDescriptor);

            var output = Instances.EnumerableOperator.From($"Location Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        /// <inheritdoc cref="For_Bases_IDescriptorTextOperator.IDescriptorTextOperator{TDescriptor}.To_Text_AsResult(TDescriptor)" path="/summary"/>
        /// <remarks>
        /// Special overload for <see cref="LocationDescriptor_Aggregate"/> to resolve ambiguity between enumerable and instance methods.
        /// </remarks>
        For_Results.N003.Result<
            IEnumerable<string>,
            For_Results.N002.IFailed<ILocationDescriptor>>
            To_Text_AsResult(
            LocationDescriptor_Aggregate descriptor)
            => this.To_Text_AsResult(descriptor as ILocationDescriptor);

        IEnumerable<string> To_Text_ContentOnly(LocationDescriptor_GitHubRepository locationDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{locationDescriptor.RepositoryUrl}")
                .Append(": GitHub repository URL".Entab())
                ;

            return output;
        }

        IEnumerable<string> To_Text(LocationDescriptor_GitHubRepository locationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(locationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(locationDescriptor);

            var output = Instances.EnumerableOperator.From($"Location Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly(LocationDescriptor_ProjectFile locationDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{locationDescriptor.ProjectFilePath}")
                .Append(": project file path".Entab())
                ;

            return output;
        }

        IEnumerable<string> To_Text(LocationDescriptor_ProjectFile locationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(locationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(locationDescriptor);

            var output = Instances.EnumerableOperator.From($"Location Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly(LocationDescriptor_AssemblyFile locationDescriptor)
        {
            var output = Instances.EnumerableOperator.From($"{locationDescriptor.AssemblyFilePath}")
                .Append(": assembly file path".Entab())
                ;

            return output;
        }

        IEnumerable<string> To_Text(LocationDescriptor_AssemblyFile locationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(locationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(locationDescriptor);

            var output = Instances.EnumerableOperator.From($"Location Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }

        IEnumerable<string> To_Text_ContentOnly(LocationDescriptor_NugetPackage locationDescriptor)
        {
            var output = Instances.EnumerableOperator.Empty<string>()
                .Append($"{locationDescriptor.PackageName}")
                .Append(": package name".Entab())
                .Append($"{locationDescriptor.Version}")
                .Append(": version".Entab())
                ;

            return output;
        }

        IEnumerable<string> To_Text(LocationDescriptor_NugetPackage locationDescriptor)
        {
            var lines_ForContent = this.To_Text_ContentOnly(locationDescriptor);

            var typeName = Instances.TypeNameOperator.Get_TypeName_OfDeclaredType(locationDescriptor);

            var output = Instances.EnumerableOperator.From($"Location Descriptor ({typeName})")
                .Append_Many(lines_ForContent.Entab())
                ;

            return output;
        }
    }
}
