using System;

using F10Y.T0002;


namespace F10Y.L0026.T003
{
    [FunctionsMarker]
    public partial interface IInstanceVarietyDescriptorOperator
    {
        public InstanceVarietyDescriptor_Values From(
            ITypingSchemeDescriptor typingScheme,
            INamingSchemeDescriptor namingScheme,
            IImplementationSchemeDescriptor implementationScheme)
        {
            var output = new InstanceVarietyDescriptor_Values
            {
                ImplementationScheme = implementationScheme,
                NamingScheme = namingScheme,
                TypingScheme = typingScheme,
            };

            return output;
        }

        public InstanceVarietyDescriptor_Values From(
            TypingScheme typingScheme,
            NamingScheme namingScheme,
            ImplementationScheme implementationScheme)
        {
            var typingSchemeDescriptor = Instances.TypingSchemeDescriptorOperator.From(typingScheme);
            var namingSchemeDescriptor = Instances.NamingSchemeDescriptorOperator.From(namingScheme);
            var implementationSchemeDescriptor = Instances.ImplementationSchemeDescriptorOperator.From(implementationScheme);

            var output = this.From(
                typingSchemeDescriptor,
                namingSchemeDescriptor,
                implementationSchemeDescriptor);

            return output;
        }

        public InstanceVarietyDescriptor_Name From_Name(string instanceVarietyName)
        {
            var output = new InstanceVarietyDescriptor_Name
            {
                InstanceVariety_Name = instanceVarietyName
            };

            return output;
        }

        public InstanceVarietyDescriptor_Name_Set From_Names(params string[] instanceVarietyNames)
        {
            var output = new InstanceVarietyDescriptor_Name_Set
            {
                InstanceVariety_Names = instanceVarietyNames
            };

            return output;
        }
    }
}
