using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.storagegateway.StoragegatewayGatewaySmbActiveDirectorySettings")]
    public class StoragegatewayGatewaySmbActiveDirectorySettings : aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#domain_name StoragegatewayGateway#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#password StoragegatewayGateway#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#username StoragegatewayGateway#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
