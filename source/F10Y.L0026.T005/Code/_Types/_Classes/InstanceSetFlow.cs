using System;

using F10Y.T0004;


namespace F10Y.L0026.T005
{
    /// <inheritdoc cref="IInstanceSetFlow"/>
    [DataTypeMarker]
    public class InstanceSetFlow :
        IInstanceSetFlow
    {
        public IInstanceSetDescriptor Source { get; set; }

        public IInstanceSetDescriptor Destination { get; set; }

        public IInstanceSetFlowDescriptor Flow { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class InstanceSetFlow
        {
            public JsonSerializationObject Source { get; set; }

            public JsonSerializationObject Destination { get; set; }

            public JsonSerializationObject Flow { get; set; }
        }
    }
}
