using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    [JsiiInterface(nativeType: typeof(IDataAwsIamPolicyDocumentStatement), fullyQualifiedName: "aws.iam.DataAwsIamPolicyDocumentStatement")]
    public interface IDataAwsIamPolicyDocumentStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#actions DataAwsIamPolicyDocument#actions}.</summary>
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Actions
        {
            get
            {
                return null;
            }
        }

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#condition DataAwsIamPolicyDocument#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatementCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#effect DataAwsIamPolicyDocument#effect}.</summary>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Effect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#not_actions DataAwsIamPolicyDocument#not_actions}.</summary>
        [JsiiProperty(name: "notActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotActions
        {
            get
            {
                return null;
            }
        }

        /// <summary>not_principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#not_principals DataAwsIamPolicyDocument#not_principals}
        /// </remarks>
        [JsiiProperty(name: "notPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatementNotPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NotPrincipals
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#not_resources DataAwsIamPolicyDocument#not_resources}.</summary>
        [JsiiProperty(name: "notResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotResources
        {
            get
            {
                return null;
            }
        }

        /// <summary>principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#principals DataAwsIamPolicyDocument#principals}
        /// </remarks>
        [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatementPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Principals
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#resources DataAwsIamPolicyDocument#resources}.</summary>
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Resources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#sid DataAwsIamPolicyDocument#sid}.</summary>
        [JsiiProperty(name: "sid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIamPolicyDocumentStatement), fullyQualifiedName: "aws.iam.DataAwsIamPolicyDocumentStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Iam.IDataAwsIamPolicyDocumentStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#actions DataAwsIamPolicyDocument#actions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Actions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#condition DataAwsIamPolicyDocument#condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatementCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Condition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#effect DataAwsIamPolicyDocument#effect}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Effect
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#not_actions DataAwsIamPolicyDocument#not_actions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotActions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>not_principals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#not_principals DataAwsIamPolicyDocument#not_principals}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatementNotPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NotPrincipals
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#not_resources DataAwsIamPolicyDocument#not_resources}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotResources
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>principals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#principals DataAwsIamPolicyDocument#principals}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iam.DataAwsIamPolicyDocumentStatementPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Principals
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#resources DataAwsIamPolicyDocument#resources}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Resources
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#sid DataAwsIamPolicyDocument#sid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
