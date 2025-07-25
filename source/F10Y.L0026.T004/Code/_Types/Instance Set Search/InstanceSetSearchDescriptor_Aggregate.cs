using System;

using F10Y.T0004;


namespace F10Y.L0026.T004
{
    /// <summary>
    /// An aggregation of instance set search descriptors.
    /// </summary>
    /// <remarks>
    /// No data is provided about whether the predictes generated from the search descriptors should be combined into a single predicate using ANY or ALL logic, but ALL should be assumed.
    /// (See <see cref="N001.InstanceSetSearchDescriptor_Aggregate"/> and <see cref="N002.InstanceSetSearchDescriptor_Aggregate"/> for other options.)
    /// </remarks>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_Aggregate : IInstanceSetSearchDescriptor,
        IWith_Descriptor
    {
        public IDescriptor Descriptor { get; set; }

        public IInstanceSetSearchDescriptor[] InstanceSetSearchDescriptors { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="T004.InstanceSetSearchDescriptor_Aggregate"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor_Aggregate
        {
            public JsonSerializationObject Descriptor { get; set; }

            public JsonSerializationObject[] InstanceSetSearchDescriptors { get; set; }
        }
    }
}


namespace F10Y.L0026.T004.N001
{
    /// <summary>
    /// An aggregation of instance set search descriptors allowing specification of whether any, or all, sub-searches must be true.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_Aggregate : T004.IInstanceSetSearchDescriptor,
        IWith_Descriptor
    {
        public IDescriptor Descriptor { get; set; }

        public T004.IInstanceSetSearchDescriptor[] InstanceSetSearchDescriptors { get; set; }

        public AnyOrAll AnyOrAll { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="N001.InstanceSetSearchDescriptor_Aggregate"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor_Aggregate
        {
            public JsonSerializationObject Descriptor { get; set; }

            public JsonSerializationObject[] InstanceSetSearchDescriptors { get; set; }

            public string AnyOrAll { get; set; }
        }
    }
}


namespace F10Y.L0026.T004.N002
{
    /// <summary>
    /// An aggregation of instance set search descriptors allowing separation of sub-searches for which all must be true from sub-seaches where any must be true.
    /// </summary>
    [DataTypeMarker]
    public class InstanceSetSearchDescriptor_Aggregate : T004.IInstanceSetSearchDescriptor,
        IWith_Descriptor
    {
        public IDescriptor Descriptor { get; set; }

        public T004.IInstanceSetSearchDescriptor[] All_Set { get; set; }

        public T004.IInstanceSetSearchDescriptor[] Any_Set { get; set; }
    }


    namespace Serialization
    {
        /// <summary>
        /// Serialization type for <see cref="N002.InstanceSetSearchDescriptor_Aggregate"/>.
        /// </summary>
        [DataTypeMarker]
        public class InstanceSetSearchDescriptor_Aggregate
        {
            public JsonSerializationObject Descriptor { get; set; }

            public JsonSerializationObject[] All_Set { get; set; }

            public JsonSerializationObject[] Any_Set { get; set; }
        }
    }
}
