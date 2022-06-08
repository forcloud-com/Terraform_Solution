using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.Ec2ClientVpnEndpointConnectionLogOptions")]
    public class Ec2ClientVpnEndpointConnectionLogOptions : aws.Ec2.IEc2ClientVpnEndpointConnectionLogOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#enabled Ec2ClientVpnEndpoint#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#cloudwatch_log_group Ec2ClientVpnEndpoint#cloudwatch_log_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudwatchLogGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#cloudwatch_log_stream Ec2ClientVpnEndpoint#cloudwatch_log_stream}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudwatchLogStream
        {
            get;
            set;
        }
    }
}
