using System;

using F10Y.T0002;


namespace F10Y.L0026.T004
{
    [FunctionsMarker]
    public partial interface IInstanceVarietySearchDescriptorOperator
    {
        public InstanceVarietySearchDescriptor_Values From(
            INamingSchemeSearchDescriptor namingSchemeSearchDescriptor,
            IImplementationSchemeSearchDescriptor implementationSchemeSearchDescriptor,
            ITypingSchemeSearchDescriptor typingSchemeSearchDescriptor)
        {
            var output = new InstanceVarietySearchDescriptor_Values
            {
                ImplementationScheme = implementationSchemeSearchDescriptor,
                NamingScheme = namingSchemeSearchDescriptor,
                TypingScheme = typingSchemeSearchDescriptor
            };

            return output;
        }

        public InstanceVarietySearchDescriptor_Name From(
            string instanceVariety_Name,
            For_EqualityOperationDescriptor.IEqualityOperationDescriptor equalityOperationDescriptor,
            bool includeAll = false)
        {
            var output = new InstanceVarietySearchDescriptor_Name
            {
                EqualityOperationDescriptor = equalityOperationDescriptor,
                Include_All = includeAll,
                InstanceVariety_Name = instanceVariety_Name,
            };

            return output;
        }
    }
}
