using System;


namespace F10Y.L0026.T003
{
    public static class Instances
    {
        public static L0000.IArrayOperator ArrayOperator => L0000.ArrayOperator.Instance;
        public static L0000.IHashCodeOperator HashCodeOperator => L0000.HashCodeOperator.Instance;
        public static IInstanceSetDescriptorOperator InstanceSetDescriptorOperator => T003.InstanceSetDescriptorOperator.Instance;
        public static IInstanceSetTypeDescriptorOperator InstanceSetTypeDescriptorOperator => T003.InstanceSetTypeDescriptorOperator.Instance;
        public static IInstanceSetTypeDescriptors InstanceSetTypeDescriptors => T003.InstanceSetTypeDescriptors.Instance;
        public static T001.IImplementationSchemeDescriptorOperator ImplementationSchemeDescriptorOperator => T001.ImplementationSchemeDescriptorOperator.Instance;
        public static IInstanceSetTypeNames InstanceSetTypeNames => T003.InstanceSetTypeNames.Instance;
        public static T001.INamingSchemeDescriptorOperator NamingSchemeDescriptorOperator => T001.NamingSchemeDescriptorOperator.Instance;
        public static T001.ITypingSchemeDescriptorOperator TypingSchemeDescriptorOperator => T001.TypingSchemeDescriptorOperator.Instance;
    }
}