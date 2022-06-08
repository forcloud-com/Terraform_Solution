using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(IEc2ClientVpnEndpointConnectionLogOptions), fullyQualifiedName: "aws.ec2.Ec2ClientVpnEndpointConnectionLogOptions")]
    public interface IEc2ClientVpnEndpointConnectionLogOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#enabled Ec2ClientVpnEndpoint#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#cloudwatch_log_group Ec2ClientVpnEndpoint#cloudwatch_log_group}.</summary>
        [JsiiProperty(name: "cloudwatchLogGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchLogGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#cloudwatch_log_stream Ec2ClientVpnEndpoint#cloudwatch_log_stream}.</summary>
        [JsiiProperty(name: "cloudwatchLogStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchLogStream
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2ClientVpnEndpointConnectionLogOptions), fullyQualifiedName: "aws.ec2.Ec2ClientVpnEndpointConnectionLogOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IEc2ClientVpnEndpointConnectionLogOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#enabled Ec2ClientVpnEndpoint#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#cloudwatch_log_group Ec2ClientVpnEndpoint#cloudwatch_log_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchLogGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_endpoint#cloudwatch_log_stream Ec2ClientVpnEndpoint#cloudwatch_log_stream}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchLogStream
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
