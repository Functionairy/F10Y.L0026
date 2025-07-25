using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface IVisibilityDescriptorOperator
    {
        public VisibilityDescriptor From(Visibility visibility)
        {
            var output = new VisibilityDescriptor
            {
                Visibility = visibility
            };

            return output;
        }

        public string To_String(VisibilityDescriptor visibilityDescriptor)
        {
            var visibility = Instances.EnumerationOperator.Get_StringRepresentation(visibilityDescriptor.Visibility);

            var output = $"Visibility: {visibility}";
            return output;
        }

        public string To_String(VisibilityDescriptor_Invalid visibilityDescriptor)
        {
            var output = "Visibility: INVALID";
            return output;
        }
    }
}
