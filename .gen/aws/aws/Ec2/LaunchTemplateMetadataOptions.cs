using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateMetadataOptions")]
    public class LaunchTemplateMetadataOptions : aws.Ec2.ILaunchTemplateMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#http_endpoint LaunchTemplate#http_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#http_put_response_hop_limit LaunchTemplate#http_put_response_hop_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpPutResponseHopLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#http_tokens LaunchTemplate#http_tokens}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpTokens
        {
            get;
            set;
        }
    }
}
