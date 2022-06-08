using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ses.SesReceiptRuleAddHeaderAction")]
    public class SesReceiptRuleAddHeaderAction : aws.Ses.ISesReceiptRuleAddHeaderAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#header_name SesReceiptRule#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#header_value SesReceiptRule#header_value}.</summary>
        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderValue
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
    }
}
