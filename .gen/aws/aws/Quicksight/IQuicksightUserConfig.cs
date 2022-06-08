using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    /// <summary>AWS QuickSight.</summary>
    [JsiiInterface(nativeType: typeof(IQuicksightUserConfig), fullyQualifiedName: "aws.quicksight.QuicksightUserConfig")]
    public interface IQuicksightUserConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#email QuicksightUser#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#identity_type QuicksightUser#identity_type}.</summary>
        [JsiiProperty(name: "identityType", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#user_role QuicksightUser#user_role}.</summary>
        [JsiiProperty(name: "userRole", typeJson: "{\"primitive\":\"string\"}")]
        string UserRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#aws_account_id QuicksightUser#aws_account_id}.</summary>
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#iam_arn QuicksightUser#iam_arn}.</summary>
        [JsiiProperty(name: "iamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#namespace QuicksightUser#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#session_name QuicksightUser#session_name}.</summary>
        [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#user_name QuicksightUser#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS QuickSight.</summary>
        [JsiiTypeProxy(nativeType: typeof(IQuicksightUserConfig), fullyQualifiedName: "aws.quicksight.QuicksightUserConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Quicksight.IQuicksightUserConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#email QuicksightUser#email}.</summary>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#identity_type QuicksightUser#identity_type}.</summary>
            [JsiiProperty(name: "identityType", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#user_role QuicksightUser#user_role}.</summary>
            [JsiiProperty(name: "userRole", typeJson: "{\"primitive\":\"string\"}")]
            public string UserRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#aws_account_id QuicksightUser#aws_account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsAccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#iam_arn QuicksightUser#iam_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#namespace QuicksightUser#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#session_name QuicksightUser#session_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#user_name QuicksightUser#user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
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
