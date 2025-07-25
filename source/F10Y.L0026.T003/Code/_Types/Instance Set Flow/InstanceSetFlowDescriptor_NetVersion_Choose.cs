using System;
using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// To choose a specific .NET version (target framework moniker) for an instance set.
    /// </summary>
    /// <remarks>
    /// Instance sets can just specify LATEST as their .NET version, allowing the .NET version to be unspecified.
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_NetVersion_Choose : IInstanceSetFlowDescriptor,
        IEquatable<InstanceSetFlowDescriptor_NetVersion_Choose>
    {
        /// <summary>
        /// Only the destination is recorded.
        /// </summary>
        public string TargetFrameworkMoniker_Destination { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetFlowDescriptor_NetVersion_Choose applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetFlowDescriptor_NetVersion_Choose other)
        {
            var output = true
                && this.TargetFrameworkMoniker_Destination == other.TargetFrameworkMoniker_Destination
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.TargetFrameworkMoniker_Destination);
            return output;
        }
    }
}
