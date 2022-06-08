using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    /// <summary>AWS Identity and Access Management.</summary>
    [JsiiInterface(nativeType: typeof(IIamUserSshKeyConfig), fullyQualifiedName: "aws.iam.IamUserSshKeyConfig")]
    public interface IIamUserSshKeyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_user_ssh_key#encoding IamUserSshKey#encoding}.</summary>
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}")]
        string Encoding
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_user_ssh_key#public_key IamUserSshKey#public_key}.</summary>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        string PublicKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_user_ssh_key#username IamUserSshKey#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_user_ssh_key#status IamUserSshKey#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Identity and Access Management.</summary>
        [JsiiTypeProxy(nativeType: typeof(IIamUserSshKeyConfig), fullyQualifiedName: "aws.iam.IamUserSshKeyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Iam.IIamUserSshKeyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_user_ssh_key#encoding IamUserSshKey#encoding}.</summary>
            [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}")]
            public string Encoding
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_user_ssh_key#public_key IamUserSshKey#public_key}.</summary>
            [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_user_ssh_key#username IamUserSshKey#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_user_ssh_key#status IamUserSshKey#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
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
