using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    [JsiiInterface(nativeType: typeof(IDataAwsIamPolicyDocumentStatementCondition), fullyQualifiedName: "aws.iam.DataAwsIamPolicyDocumentStatementCondition")]
    public interface IDataAwsIamPolicyDocumentStatementCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#test DataAwsIamPolicyDocument#test}.</summary>
        [JsiiProperty(name: "test", typeJson: "{\"primitive\":\"string\"}")]
        string Test
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#values DataAwsIamPolicyDocument#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#variable DataAwsIamPolicyDocument#variable}.</summary>
        [JsiiProperty(name: "variable", typeJson: "{\"primitive\":\"string\"}")]
        string Variable
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIamPolicyDocumentStatementCondition), fullyQualifiedName: "aws.iam.DataAwsIamPolicyDocumentStatementCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Iam.IDataAwsIamPolicyDocumentStatementCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#test DataAwsIamPolicyDocument#test}.</summary>
            [JsiiProperty(name: "test", typeJson: "{\"primitive\":\"string\"}")]
            public string Test
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#values DataAwsIamPolicyDocument#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#variable DataAwsIamPolicyDocument#variable}.</summary>
            [JsiiProperty(name: "variable", typeJson: "{\"primitive\":\"string\"}")]
            public string Variable
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
