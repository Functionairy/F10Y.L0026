using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface ILocationDescriptorOperator
    {
        public LocationDescriptor_Aggregate From(params ILocationDescriptor[] locationDescriptors)
        {
            var output = new LocationDescriptor_Aggregate
            {
                LocationDescriptors = locationDescriptors,
            };

            return output;
        }

        public LocationDescriptor_Aggregate From(IEnumerable<ILocationDescriptor> locationDescriptors)
            => this.From(locationDescriptors.Now());

        public LocationDescriptor_GitHubRepository From_GitHubRepositoryUrl(string gitHubRepositoryUrl)
        {
            var output = new LocationDescriptor_GitHubRepository
            {
                RepositoryUrl = gitHubRepositoryUrl
            };

            return output;
        }

        public LocationDescriptor_ProjectFile From_ProjectFilePath(string projectFilePath)
        {
            var output = new LocationDescriptor_ProjectFile
            {
                ProjectFilePath = projectFilePath,
            };

            return output;
        }

        public string To_String(LocationDescriptor_Aggregate locationDescriptor)
        {
            var count = Instances.CountOperator.Get_CountOf(locationDescriptor);

            var output = $"Locations count: {count}";
            return output;
        }

        public string To_String(LocationDescriptor_GitHubRepository locationDescriptor)
        {
            var output = $"GitHub: {locationDescriptor.RepositoryUrl}";
            return output;
        }

        public string To_String(LocationDescriptor_ProjectFile locationDescriptor)
        {
            var output = $"Project: {locationDescriptor.ProjectFilePath}";
            return output;
        }
    }
}
