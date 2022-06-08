using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    [JsiiInterface(nativeType: typeof(IDataAwsIamPolicyDocumentStatementPrincipals), fullyQualifiedName: "aws.iam.DataAwsIamPolicyDocumentStatementPrincipals")]
    public interface IDataAwsIamPolicyDocumentStatementPrincipals
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#identifiers DataAwsIamPolicyDocument#identifiers}.</summary>
        [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Identifiers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#type DataAwsIamPolicyDocument#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIamPolicyDocumentStatementPrincipals), fullyQualifiedName: "aws.iam.DataAwsIamPolicyDocumentStatementPrincipals")]
        internal sealed class _Proxy : DeputyBase, aws.Iam.IDataAwsIamPolicyDocumentStatementPrincipals
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#identifiers DataAwsIamPolicyDocument#identifiers}.</summary>
            [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Identifiers
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#type DataAwsIamPolicyDocument#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
