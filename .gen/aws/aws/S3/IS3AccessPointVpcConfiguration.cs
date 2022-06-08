using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3AccessPointVpcConfiguration), fullyQualifiedName: "aws.s3.S3AccessPointVpcConfiguration")]
    public interface IS3AccessPointVpcConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#vpc_id S3AccessPoint#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3AccessPointVpcConfiguration), fullyQualifiedName: "aws.s3.S3AccessPointVpcConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3AccessPointVpcConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#vpc_id S3AccessPoint#vpc_id}.</summary>
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
