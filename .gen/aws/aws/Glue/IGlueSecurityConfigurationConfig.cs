using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>AWS Glue.</summary>
    [JsiiInterface(nativeType: typeof(IGlueSecurityConfigurationConfig), fullyQualifiedName: "aws.glue.GlueSecurityConfigurationConfig")]
    public interface IGlueSecurityConfigurationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#encryption_configuration GlueSecurityConfiguration#encryption_configuration}
        /// </remarks>
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfiguration\"}")]
        aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration EncryptionConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#name GlueSecurityConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>AWS Glue.</summary>
        [JsiiTypeProxy(nativeType: typeof(IGlueSecurityConfigurationConfig), fullyQualifiedName: "aws.glue.GlueSecurityConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueSecurityConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>encryption_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#encryption_configuration GlueSecurityConfiguration#encryption_configuration}
            /// </remarks>
            [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfiguration\"}")]
            public aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration EncryptionConfiguration
            {
                get => GetInstanceProperty<aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#name GlueSecurityConfiguration#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
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
