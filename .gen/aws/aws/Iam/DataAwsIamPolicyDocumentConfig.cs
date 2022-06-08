using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    /// <summary>AWS Identity and Access Management.</summary>
    [JsiiByValue(fqn: "aws.iam.DataAwsIamPolicyDocumentConfig")]
    public class DataAwsIamPolicyDocumentConfig : aws.Iam.IDataAwsIamPolicyDocumentConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#override_json DataAwsIamPolicyDocument#override_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overrideJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OverrideJson
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#policy_id DataAwsIamPolicyDocument#policy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#source_json DataAwsIamPolicyDocument#source_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceJson
        {
            get;
            set;
        }

        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#statement DataAwsIamPolicyDocument#statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Statement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#version DataAwsIamPolicyDocument#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
