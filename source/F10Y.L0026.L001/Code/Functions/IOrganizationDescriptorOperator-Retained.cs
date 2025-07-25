using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0026.L001.Retained
{
    [FunctionsMarker]
    public partial interface IOrganizationDescriptorOperator
    {
        public bool Can_Handle(IOrganizationDescriptor organizationDescriptor)
        {
            var output = organizationDescriptor switch
            {
                OrganizationDescriptor_Name => true,
                _ => false
            };

            return output;
        }

        public IEnumerable<string> To_Text_ContentOnly(IOrganizationDescriptor organizationDescriptor)
        {
            var output = organizationDescriptor switch
            {
                OrganizationDescriptor_Name organizationDescriptor_Class => this.To_Text_ContentOnly(organizationDescriptor_Class),
                _ => throw Instances.SwitchOperator.Get_DefaultCaseException_ForType(organizationDescriptor)
            };

            return output;
        }

        public IEnumerable<string> To_Text_ExceptionIfUnhandled(IOrganizationDescriptor organizationDescriptor)
        {
            var output = organizationDescriptor switch
            {
                OrganizationDescriptor_Name organizationDescriptor_Class => Instances.OrganizationDescriptorOperator.To_Text(organizationDescriptor_Class),
                _ => throw Instances.SwitchOperator.Get_DefaultCaseException_ForType(organizationDescriptor)
            };

            return output;
        }

        public IEnumerable<string> To_Text_ExceptionIfUnhandled(IEnumerable<IOrganizationDescriptor> organizationDescriptors)
        {
            var output = organizationDescriptors
                .SelectMany(this.To_Text_ExceptionIfUnhandled)
                ;

            return output;
        }

        public IEnumerable<string> To_Text_DefaultIfUnhandled(IOrganizationDescriptor organizationDescriptor)
        {
            var output = organizationDescriptor switch
            {
                OrganizationDescriptor_Name organizationDescriptor_Class => Instances.OrganizationDescriptorOperator.To_Text(organizationDescriptor_Class),
                _ => Instances.OrganizationDescriptorOperator.To_Text_DefaultForUnhandled(organizationDescriptor)
            };

            return output;
        }

        public IEnumerable<string> To_Text_DefaultIfUnhandled(IEnumerable<IOrganizationDescriptor> organizationDescriptors)
        {
            var output = organizationDescriptors
                .SelectMany(this.To_Text_DefaultIfUnhandled)
                ;

            return output;
        }
    }
}
