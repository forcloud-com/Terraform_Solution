using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    /// <summary>AWS Auto Scaling.</summary>
    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingScheduleConfig")]
    public class AutoscalingScheduleConfig : aws.Autoscaling.IAutoscalingScheduleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_schedule#autoscaling_group_name AutoscalingSchedule#autoscaling_group_name}.</summary>
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoscalingGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_schedule#scheduled_action_name AutoscalingSchedule#scheduled_action_name}.</summary>
        [JsiiProperty(name: "scheduledActionName", typeJson: "{\"primitive\":\"string\"}")]
        public string ScheduledActionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_schedule#desired_capacity AutoscalingSchedule#desired_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DesiredCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_schedule#end_time AutoscalingSchedule#end_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_schedule#max_size AutoscalingSchedule#max_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_schedule#min_size AutoscalingSchedule#min_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_schedule#recurrence AutoscalingSchedule#recurrence}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recurrence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Recurrence
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_schedule#start_time AutoscalingSchedule#start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartTime
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
