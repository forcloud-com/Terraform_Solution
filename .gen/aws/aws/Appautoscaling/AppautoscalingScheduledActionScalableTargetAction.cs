using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    [JsiiByValue(fqn: "aws.appautoscaling.AppautoscalingScheduledActionScalableTargetAction")]
    public class AppautoscalingScheduledActionScalableTargetAction : aws.Appautoscaling.IAppautoscalingScheduledActionScalableTargetAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#max_capacity AppautoscalingScheduledAction#max_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#min_capacity AppautoscalingScheduledAction#min_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinCapacity
        {
            get;
            set;
        }
    }
}
