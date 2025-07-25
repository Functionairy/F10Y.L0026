using System;
using F10Y.T0004;


namespace F10Y.L0026.T003
{
    /// <summary>
    /// To change the organization (ownership) or an instance set.
    /// </summary>
    /// <remarks>
    /// Instance sets always belong to an organization (even if that organization is you, personally).
    /// Thus when the organization owning an instance set changes, in a sense, the source organization contributed the instance set to the destination organization.
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetFlowDescriptor_Contribute : IInstanceSetFlowDescriptor,
        IEquatable<InstanceSetFlowDescriptor_Contribute>
    {
        /// <summary>
        /// Only the destination is recorded.
        /// </summary>
        public string OrganizationName_Destination { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is InstanceSetFlowDescriptor_Contribute applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(InstanceSetFlowDescriptor_Contribute other)
        {
            var output = true
                && this.OrganizationName_Destination == other.OrganizationName_Destination
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.OrganizationName_Destination);
            return output;
        }
    }
}
