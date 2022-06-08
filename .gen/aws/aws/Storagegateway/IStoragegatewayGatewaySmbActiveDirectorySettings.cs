using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiInterface(nativeType: typeof(IStoragegatewayGatewaySmbActiveDirectorySettings), fullyQualifiedName: "aws.storagegateway.StoragegatewayGatewaySmbActiveDirectorySettings")]
    public interface IStoragegatewayGatewaySmbActiveDirectorySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#domain_name StoragegatewayGateway#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#password StoragegatewayGateway#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#username StoragegatewayGateway#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayGatewaySmbActiveDirectorySettings), fullyQualifiedName: "aws.storagegateway.StoragegatewayGatewaySmbActiveDirectorySettings")]
        internal sealed class _Proxy : DeputyBase, aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#domain_name StoragegatewayGateway#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#password StoragegatewayGateway#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#username StoragegatewayGateway#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
