using System;

using F10Y.T0002;


namespace F10Y.L0026.T002
{
    [FunctionsMarker]
    public partial interface IVisibilitySearchDescriptorOperator
    {
        public VisibilitySearchDescriptor From(Visibility visibility)
        {
            var output = new VisibilitySearchDescriptor
            {
                Visibility = visibility,
            };

            return output;
        }
    }
}
