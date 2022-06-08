using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueJobNotificationProperty")]
    public class GlueJobNotificationProperty : aws.Glue.IGlueJobNotificationProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#notify_delay_after GlueJob#notify_delay_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NotifyDelayAfter
        {
            get;
            set;
        }
    }
}
