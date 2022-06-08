using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kms
{
    /// <summary>AWS Key Management Service.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsKmsSecretConfig), fullyQualifiedName: "aws.kms.DataAwsKmsSecretConfig")]
    public interface IDataAwsKmsSecretConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secret#secret DataAwsKmsSecret#secret}
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kms.DataAwsKmsSecretSecret\"},\"kind\":\"array\"}}]}}")]
        object Secret
        {
            get;
        }

        /// <summary>AWS Key Management Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsKmsSecretConfig), fullyQualifiedName: "aws.kms.DataAwsKmsSecretConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Kms.IDataAwsKmsSecretConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>secret block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secret#secret DataAwsKmsSecret#secret}
            /// </remarks>
            [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kms.DataAwsKmsSecretSecret\"},\"kind\":\"array\"}}]}}")]
            public object Secret
            {
                get => GetInstanceProperty<object>()!;
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
