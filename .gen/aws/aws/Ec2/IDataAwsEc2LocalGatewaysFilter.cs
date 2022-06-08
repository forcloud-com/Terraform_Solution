using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2LocalGatewaysFilter), fullyQualifiedName: "aws.ec2.DataAwsEc2LocalGatewaysFilter")]
    public interface IDataAwsEc2LocalGatewaysFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_local_gateways#name DataAwsEc2LocalGateways#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_local_gateways#values DataAwsEc2LocalGateways#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2LocalGatewaysFilter), fullyQualifiedName: "aws.ec2.DataAwsEc2LocalGatewaysFilter")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IDataAwsEc2LocalGatewaysFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_local_gateways#name DataAwsEc2LocalGateways#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_local_gateways#values DataAwsEc2LocalGateways#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
