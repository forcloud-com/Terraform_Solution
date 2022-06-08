using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    /// <summary>AWS Storage Gateway.</summary>
    [JsiiInterface(nativeType: typeof(IStoragegatewayWorkingStorageConfig), fullyQualifiedName: "aws.storagegateway.StoragegatewayWorkingStorageConfig")]
    public interface IStoragegatewayWorkingStorageConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_working_storage#disk_id StoragegatewayWorkingStorage#disk_id}.</summary>
        [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}")]
        string DiskId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_working_storage#gateway_arn StoragegatewayWorkingStorage#gateway_arn}.</summary>
        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        string GatewayArn
        {
            get;
        }

        /// <summary>AWS Storage Gateway.</summary>
        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayWorkingStorageConfig), fullyQualifiedName: "aws.storagegateway.StoragegatewayWorkingStorageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Storagegateway.IStoragegatewayWorkingStorageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_working_storage#disk_id StoragegatewayWorkingStorage#disk_id}.</summary>
            [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}")]
            public string DiskId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_working_storage#gateway_arn StoragegatewayWorkingStorage#gateway_arn}.</summary>
            [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
            public string GatewayArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
