using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    [JsiiByValue(fqn: "aws.iam.DataAwsIamPolicyDocumentStatement")]
    public class DataAwsIamPolicyDocumentStatement : aws.Iam.IDataAwsIamPolicyDocumentStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#actions DataAwsIamPolicyDocument#actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Actions
        {
            get;
            set;
        }

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#condition DataAwsIamPolicyDocument#condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatementCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Condition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#effect DataAwsIamPolicyDocument#effect}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Effect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#not_actions DataAwsIamPolicyDocument#not_actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotActions
        {
            get;
            set;
        }

        /// <summary>not_principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#not_principals DataAwsIamPolicyDocument#not_principals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatementNotPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NotPrincipals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#not_resources DataAwsIamPolicyDocument#not_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotResources
        {
            get;
            set;
        }

        /// <summary>principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#principals DataAwsIamPolicyDocument#principals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatementPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Principals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#resources DataAwsIamPolicyDocument#resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Resources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#sid DataAwsIamPolicyDocument#sid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sid
        {
            get;
            set;
        }
    }
}
