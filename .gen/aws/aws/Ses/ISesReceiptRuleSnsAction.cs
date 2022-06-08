using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleSnsAction), fullyQualifiedName: "aws.ses.SesReceiptRuleSnsAction")]
    public interface ISesReceiptRuleSnsAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#position SesReceiptRule#position}.</summary>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        double Position
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#topic_arn SesReceiptRule#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleSnsAction), fullyQualifiedName: "aws.ses.SesReceiptRuleSnsAction")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesReceiptRuleSnsAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#position SesReceiptRule#position}.</summary>
            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
            public double Position
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#topic_arn SesReceiptRule#topic_arn}.</summary>
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
