using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    [JsiiInterface(nativeType: typeof(ISesReceiptRuleStopAction), fullyQualifiedName: "aws.ses.SesReceiptRuleStopAction")]
    public interface ISesReceiptRuleStopAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#position SesReceiptRule#position}.</summary>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}")]
        double Position
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#scope SesReceiptRule#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#topic_arn SesReceiptRule#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TopicArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesReceiptRuleStopAction), fullyQualifiedName: "aws.ses.SesReceiptRuleStopAction")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesReceiptRuleStopAction
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

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#scope SesReceiptRule#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#topic_arn SesReceiptRule#topic_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TopicArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
