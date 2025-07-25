using System;

using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// A change in .NET version (target framework moniker) for an instance set.
    /// </summary>
    /// <remarks>
    /// Instance sets can be related as instance set X is the .NET 6.0 version of instance set Y.
    /// These relationships can be both upgrades and downgrades. (Is instance set Y .NET 8.0 or .NET Standard 2.1?)
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_NetVersion_Change : IInstanceSetFlowDescriptor,
        IEquatable<InstanceSetFlowDescriptor_NetVersion_Change>
    {
        public Grade Grade { get; set; }

        /// <summary>
        /// Only the destination is recorded.
        /// </summary>
        public string TargetFrameworkMoniker_Destination { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetFlowDescriptor_NetVersion_Change applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetFlowDescriptor_NetVersion_Change other)
        {
            var output = true
                && this.Grade == other.Grade
                && this.TargetFrameworkMoniker_Destination == other.TargetFrameworkMoniker_Destination
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(
                this.Grade,
                this.TargetFrameworkMoniker_Destination);

            return output;
        }
    }
}
