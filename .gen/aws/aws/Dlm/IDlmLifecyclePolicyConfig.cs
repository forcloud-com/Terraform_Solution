using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    /// <summary>AWS Data Lifecycle Manager.</summary>
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyConfig), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyConfig")]
    public interface IDlmLifecyclePolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#description DlmLifecyclePolicy#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        string Description
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#execution_role_arn DlmLifecyclePolicy#execution_role_arn}.</summary>
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionRoleArn
        {
            get;
        }

        /// <summary>policy_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#policy_details DlmLifecyclePolicy#policy_details}
        /// </remarks>
        [JsiiProperty(name: "policyDetails", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetails\"}")]
        aws.Dlm.IDlmLifecyclePolicyPolicyDetails PolicyDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#state DlmLifecyclePolicy#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#tags DlmLifecyclePolicy#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Data Lifecycle Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyConfig), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Dlm.IDlmLifecyclePolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#description DlmLifecyclePolicy#description}.</summary>
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
            public string Description
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#execution_role_arn DlmLifecyclePolicy#execution_role_arn}.</summary>
            [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>policy_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#policy_details DlmLifecyclePolicy#policy_details}
            /// </remarks>
            [JsiiProperty(name: "policyDetails", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetails\"}")]
            public aws.Dlm.IDlmLifecyclePolicyPolicyDetails PolicyDetails
            {
                get => GetInstanceProperty<aws.Dlm.IDlmLifecyclePolicyPolicyDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#state DlmLifecyclePolicy#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#tags DlmLifecyclePolicy#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
