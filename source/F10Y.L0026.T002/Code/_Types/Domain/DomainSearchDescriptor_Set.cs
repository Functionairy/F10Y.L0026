using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a search of domains of an instance set by using a domain value.
    /// </summary>
    /// <remarks>
    /// The domains in the search descriptor will be set B in set equality operations like "is set A a superset of set B?"
    /// </remarks>
    [DataTypeMarker]
    public class DomainSearchDescriptor_Set : IDomainSearchDescriptor,
        IWith_Domains
    {
        public For_SetEqualityOperationDescriptors.ISetEqualityOperationDescriptor SetEqualityOperationDescriptor { get; set; }

        public string[] Domains { get; set; }
    }


    namespace Serialization
    {
        [DataTypeMarker]
        public class DomainSearchDescriptor_Set : IDomainSearchDescriptor,
            IWith_Domains
        {
            public JsonSerializationObject SetEqualityOperationDescriptor { get; set; }

            public string[] Domains { get; set; }
        }
    }
}
