using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iam.DataAwsIamPolicyDocumentStatementPrincipals")]
    public class DataAwsIamPolicyDocumentStatementPrincipals : aws.Iam.IDataAwsIamPolicyDocumentStatementPrincipals
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#identifiers DataAwsIamPolicyDocument#identifiers}.</summary>
        [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Identifiers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/iam_policy_document#type DataAwsIamPolicyDocument#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
