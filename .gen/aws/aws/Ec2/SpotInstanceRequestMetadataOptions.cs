using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.SpotInstanceRequestMetadataOptions")]
    public class SpotInstanceRequestMetadataOptions : aws.Ec2.ISpotInstanceRequestMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#http_endpoint SpotInstanceRequest#http_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#http_put_response_hop_limit SpotInstanceRequest#http_put_response_hop_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpPutResponseHopLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#http_tokens SpotInstanceRequest#http_tokens}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpTokens
        {
            get;
            set;
        }
    }
}
