using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiByValue(fqn: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig : aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#notification_arn SsmMaintenanceWindowTask#notification_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#notification_events SsmMaintenanceWindowTask#notification_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotificationEvents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#notification_type SsmMaintenanceWindowTask#notification_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationType
        {
            get;
            set;
        }
    }
}
