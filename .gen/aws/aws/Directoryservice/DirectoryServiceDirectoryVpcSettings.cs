using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directoryservice
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.directoryservice.DirectoryServiceDirectoryVpcSettings")]
    public class DirectoryServiceDirectoryVpcSettings : aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#subnet_ids DirectoryServiceDirectory#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#vpc_id DirectoryServiceDirectory#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcId
        {
            get;
            set;
        }
    }
}
