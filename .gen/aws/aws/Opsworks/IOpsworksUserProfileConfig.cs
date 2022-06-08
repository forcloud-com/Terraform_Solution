using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    /// <summary>AWS OpsWorks.</summary>
    [JsiiInterface(nativeType: typeof(IOpsworksUserProfileConfig), fullyQualifiedName: "aws.opsworks.OpsworksUserProfileConfig")]
    public interface IOpsworksUserProfileConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#ssh_username OpsworksUserProfile#ssh_username}.</summary>
        [JsiiProperty(name: "sshUsername", typeJson: "{\"primitive\":\"string\"}")]
        string SshUsername
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#user_arn OpsworksUserProfile#user_arn}.</summary>
        [JsiiProperty(name: "userArn", typeJson: "{\"primitive\":\"string\"}")]
        string UserArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#allow_self_management OpsworksUserProfile#allow_self_management}.</summary>
        [JsiiProperty(name: "allowSelfManagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowSelfManagement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#ssh_public_key OpsworksUserProfile#ssh_public_key}.</summary>
        [JsiiProperty(name: "sshPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SshPublicKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS OpsWorks.</summary>
        [JsiiTypeProxy(nativeType: typeof(IOpsworksUserProfileConfig), fullyQualifiedName: "aws.opsworks.OpsworksUserProfileConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Opsworks.IOpsworksUserProfileConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#ssh_username OpsworksUserProfile#ssh_username}.</summary>
            [JsiiProperty(name: "sshUsername", typeJson: "{\"primitive\":\"string\"}")]
            public string SshUsername
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#user_arn OpsworksUserProfile#user_arn}.</summary>
            [JsiiProperty(name: "userArn", typeJson: "{\"primitive\":\"string\"}")]
            public string UserArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#allow_self_management OpsworksUserProfile#allow_self_management}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowSelfManagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowSelfManagement
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#ssh_public_key OpsworksUserProfile#ssh_public_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sshPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SshPublicKey
            {
                get => GetInstanceProperty<string?>();
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
