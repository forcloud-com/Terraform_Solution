using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2TransitGatewayDxGatewayAttachmentFilter), fullyQualifiedName: "aws.ec2.DataAwsEc2TransitGatewayDxGatewayAttachmentFilter")]
    public interface IDataAwsEc2TransitGatewayDxGatewayAttachmentFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_transit_gateway_dx_gateway_attachment#name DataAwsEc2TransitGatewayDxGatewayAttachment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_transit_gateway_dx_gateway_attachment#values DataAwsEc2TransitGatewayDxGatewayAttachment#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2TransitGatewayDxGatewayAttachmentFilter), fullyQualifiedName: "aws.ec2.DataAwsEc2TransitGatewayDxGatewayAttachmentFilter")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IDataAwsEc2TransitGatewayDxGatewayAttachmentFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_transit_gateway_dx_gateway_attachment#name DataAwsEc2TransitGatewayDxGatewayAttachment#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_transit_gateway_dx_gateway_attachment#values DataAwsEc2TransitGatewayDxGatewayAttachment#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
