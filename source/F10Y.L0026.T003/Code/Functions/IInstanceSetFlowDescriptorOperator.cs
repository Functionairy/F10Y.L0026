using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0026.T003
{
    [FunctionsMarker]
    public partial interface IInstanceSetFlowDescriptorOperator
    {
        public InstanceSetFlowDescriptor_Aggregate From(IEnumerable<IInstanceSetFlowDescriptor> descriptors)
        {
            var output = this.From(
                descriptors.ToArray());

            return output;
        }

        public InstanceSetFlowDescriptor_Aggregate From(params IInstanceSetFlowDescriptor[] descriptors)
        {
            var output = new InstanceSetFlowDescriptor_Aggregate
            {
                Descriptors = descriptors,
            };

            return output;
        }

        public InstanceSetFlowDescriptor_NetVersion_Choose Choose_NetVersion(string targetFrameworkMoniker_Destination)
        {
            var output = new InstanceSetFlowDescriptor_NetVersion_Choose
            {
                TargetFrameworkMoniker_Destination = targetFrameworkMoniker_Destination,
            };

            return output;
        }

        public InstanceSetFlowDescriptor_Contribute Contribute(string organizationName_Destination)
        {
            var output = new InstanceSetFlowDescriptor_Contribute()
            {
                OrganizationName_Destination = organizationName_Destination,
            };

            return output;
        }
    }
}
