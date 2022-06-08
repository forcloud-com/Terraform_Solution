using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ses.SesReceiptRuleWorkmailAction")]
    public class SesReceiptRuleWorkmailAction : aws.Ses.ISesReceiptRuleWorkmailAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#organization_arn SesReceiptRule#organization_arn}.</summary>
        [JsiiProperty(name: "organizationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string OrganizationArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#position SesReceiptRule#position}.</summary>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        public double Position
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#topic_arn SesReceiptRule#topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TopicArn
        {
            get;
            set;
        }
    }
}
