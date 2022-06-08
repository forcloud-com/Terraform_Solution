using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleAddHeaderAction), fullyQualifiedName: "aws.ses.SesReceiptRuleAddHeaderAction")]
    public interface ISesReceiptRuleAddHeaderAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#header_name SesReceiptRule#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        string HeaderName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#header_value SesReceiptRule#header_value}.</summary>
        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
        string HeaderValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#position SesReceiptRule#position}.</summary>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        double Position
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleAddHeaderAction), fullyQualifiedName: "aws.ses.SesReceiptRuleAddHeaderAction")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesReceiptRuleAddHeaderAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#header_name SesReceiptRule#header_name}.</summary>
            [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
            public string HeaderName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#header_value SesReceiptRule#header_value}.</summary>
            [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
            public string HeaderValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#position SesReceiptRule#position}.</summary>
            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
            public double Position
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
