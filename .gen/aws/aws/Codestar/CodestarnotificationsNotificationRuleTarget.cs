using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codestar
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codestar.CodestarnotificationsNotificationRuleTarget")]
    public class CodestarnotificationsNotificationRuleTarget : aws.Codestar.ICodestarnotificationsNotificationRuleTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codestarnotifications_notification_rule#address CodestarnotificationsNotificationRule#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codestarnotifications_notification_rule#type CodestarnotificationsNotificationRule#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
