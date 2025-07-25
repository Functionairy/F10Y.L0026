using System;

using F10Y.T0002;


namespace F10Y.L0026.T001
{
    [FunctionsMarker]
    public partial interface IOpinionDescriptorOperator
    {
        public OpinionDescriptor From_Opinion(string opinion)
        {
            var output = new OpinionDescriptor
            {
                Opinion = opinion,
            };

            return output;
        }

        public OpinionDescriptor From(string opinion)
            => this.From_Opinion(opinion);

        public OpinionDescriptor_Set From_Opinions(params string[] opinions)
        {
            var output = new OpinionDescriptor_Set
            {
                Opinions = opinions
            };

            return output;
        }

        public OpinionDescriptor_Set From(params string[] opinions)
            => this.From_Opinions(opinions);

        public string To_String(OpinionDescriptor opinionDescriptor)
        {
            var output = $"Opinion: {opinionDescriptor.Opinion}";
            return output;
        }

        public string To_String(OpinionDescriptor_Set opinionDescriptor)
        {
            var count = Instances.CountOperator.Get_CountOf(opinionDescriptor.Opinions);

            var output = $"Opinion set - count: {count}";
            return output;
        }
    }
}
