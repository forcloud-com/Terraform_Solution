using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eks.EksFargateProfileSelector")]
    public class EksFargateProfileSelector : aws.Eks.IEksFargateProfileSelector
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_fargate_profile#namespace EksFargateProfile#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_fargate_profile#labels EksFargateProfile#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get;
            set;
        }
    }
}
