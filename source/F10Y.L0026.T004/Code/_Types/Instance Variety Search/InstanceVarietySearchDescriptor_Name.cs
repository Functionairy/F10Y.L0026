using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// An instance variety search descriptor for instance variety name.
    /// </summary>
    [DataTypeMarker]
    public class InstanceVarietySearchDescriptor_Name : IInstanceVarietySearchDescriptor,
        IWith_InstanceVarietyName
    {
        public For_EqualityOperationDescriptor.IEqualityOperationDescriptor EqualityOperationDescriptor { get; set; }

        public bool Include_All { get; set; }

        public string InstanceVariety_Name { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="T004.InstanceVarietySearchDescriptor_Name"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceVarietySearchDescriptor_Name
        {
            public JsonSerializationObject EqualityOperationDescriptor { get; set; }

            public bool Include_All { get; set; }

            public string InstanceVariety_Name { get; set; }
        }
    }
}
