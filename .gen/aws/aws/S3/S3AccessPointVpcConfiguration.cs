using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3AccessPointVpcConfiguration")]
    public class S3AccessPointVpcConfiguration : aws.S3.IS3AccessPointVpcConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#vpc_id S3AccessPoint#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcId
        {
            get;
            set;
        }
    }
}
