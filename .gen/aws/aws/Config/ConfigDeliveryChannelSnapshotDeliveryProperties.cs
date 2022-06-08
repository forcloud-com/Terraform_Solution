using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiByValue(fqn: "aws.config.ConfigDeliveryChannelSnapshotDeliveryProperties")]
    public class ConfigDeliveryChannelSnapshotDeliveryProperties : aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#delivery_frequency ConfigDeliveryChannel#delivery_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deliveryFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeliveryFrequency
        {
            get;
            set;
        }
    }
}
