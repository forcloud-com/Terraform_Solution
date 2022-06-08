using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    /// <summary>AWS Identity and Access Management.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsIamPolicyDocumentConfig), fullyQualifiedName: "aws.iam.DataAwsIamPolicyDocumentConfig")]
    public interface IDataAwsIamPolicyDocumentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#override_json DataAwsIamPolicyDocument#override_json}.</summary>
        [JsiiProperty(name: "overrideJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OverrideJson
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#policy_id DataAwsIamPolicyDocument#policy_id}.</summary>
        [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#source_json DataAwsIamPolicyDocument#source_json}.</summary>
        [JsiiProperty(name: "sourceJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceJson
        {
            get
            {
                return null;
            }
        }

        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#statement DataAwsIamPolicyDocument#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Statement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#version DataAwsIamPolicyDocument#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Identity and Access Management.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsIamPolicyDocumentConfig), fullyQualifiedName: "aws.iam.DataAwsIamPolicyDocumentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Iam.IDataAwsIamPolicyDocumentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#override_json DataAwsIamPolicyDocument#override_json}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overrideJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OverrideJson
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#policy_id DataAwsIamPolicyDocument#policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#source_json DataAwsIamPolicyDocument#source_json}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceJson
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#statement DataAwsIamPolicyDocument#statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Statement
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#version DataAwsIamPolicyDocument#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
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
