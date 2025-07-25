using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface IApplicabilityDescriptorOperator
    {
        public ApplicabilityDescriptor From_Applicability(string applicability)
        {
            var output = new ApplicabilityDescriptor
            {
                Applicability = applicability,
            };

            return output;
        }

        public ApplicabilityDescriptor_Machine From_MachineName(string machineName)
        {
            var output = new ApplicabilityDescriptor_Machine
            {
                Machine_Name = machineName,
            };

            return output;
        }

        public ApplicabilityDescriptor_Organization From_OrganizationName(string organizationName)
        {
            var output = new ApplicabilityDescriptor_Organization
            {
                Organization_Name = organizationName,
            };

            return output;
        }

        public ApplicabilityDescriptor_Personal From_PersonName(string personName)
        {
            var output = new ApplicabilityDescriptor_Personal
            {
                Person_Name = personName,
            };

            return output;
        }

        public ApplicabilityDescriptor_Project From_Project(string projectName)
        {
            var output = new ApplicabilityDescriptor_Project
            {
                Project_Name = projectName,
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_Applicability(string)"/> as the default.
        /// </summary>
        public ApplicabilityDescriptor From(string applicability)
        {
            var output = this.From_Applicability(applicability);
            return output;
        }

        public string To_String(ApplicabilityDescriptor applicabilityDescriptor)
        {
            var output = $"Applicability: {applicabilityDescriptor.Applicability}";
            return output;
        }

        public string To_String(ApplicabilityDescriptor_Machine applicabilityDescriptor)
        {
            var output = $"Applicable Machine: {applicabilityDescriptor.Machine_Name}";
            return output;
        }

        public string To_String(ApplicabilityDescriptor_Organization applicabilityDescriptor)
        {
            var output = $"Applicable Organization: {applicabilityDescriptor.Organization_Name}";
            return output;
        }

        public string To_String(ApplicabilityDescriptor_Personal applicabilityDescriptor)
        {
            var output = $"Applicable Person: {applicabilityDescriptor.Person_Name}";
            return output;
        }

        public string To_String(ApplicabilityDescriptor_Project applicabilityDescriptor)
        {
            var output = $"Applicable Project: {applicabilityDescriptor.Project_Name}";
            return output;
        }
    }
}
