using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0026
{
    [FunctionsMarker]
    public partial interface IInstanceSetSearchOperator
    {
        public T[] Apply<T>(
            Synchronous_IInstanceSetSearch instanceSetSearch,
            IEnumerable<T> items)
            where T : IHas_InstanceSetDescriptor
        {
            var output = items
                .Where(item =>
                {
                    var output = instanceSetSearch.Predicate(item.InstanceSetDescriptor);
                    return output;
                })
                .ToArray();

            return output;
        }

        public Synchronous_InstanceSetSearch For_OrganizationName(
            string organizationName,
            IDescriptor descriptor_ForSearch)
        {
            // Fix. TODO
            var predicate = Instances.Predicates.For<IInstanceSetDescriptor>().True;

            var output = new Synchronous_InstanceSetSearch
            {
                Descriptor = descriptor_ForSearch,
                Predicate = predicate,
            };

            return output;
        }

        public Synchronous_InstanceSetSearch From(
            IDescriptor descriptor,
            Func<IInstanceSetDescriptor, bool> predicate)
        {
            var output = new Synchronous_InstanceSetSearch
            {
                Descriptor = descriptor,
                Predicate = predicate
            };

            return output;
        }
    }
}
