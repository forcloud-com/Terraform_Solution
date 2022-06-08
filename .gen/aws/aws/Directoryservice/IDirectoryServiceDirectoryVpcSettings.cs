using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directoryservice
{
    [JsiiInterface(nativeType: typeof(IDirectoryServiceDirectoryVpcSettings), fullyQualifiedName: "aws.directoryservice.DirectoryServiceDirectoryVpcSettings")]
    public interface IDirectoryServiceDirectoryVpcSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#subnet_ids DirectoryServiceDirectory#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#vpc_id DirectoryServiceDirectory#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDirectoryServiceDirectoryVpcSettings), fullyQualifiedName: "aws.directoryservice.DirectoryServiceDirectoryVpcSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#subnet_ids DirectoryServiceDirectory#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#vpc_id DirectoryServiceDirectory#vpc_id}.</summary>
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
