using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    [JsiiByValue(fqn: "aws.rds.RdsClusterScalingConfiguration")]
    public class RdsClusterScalingConfiguration : aws.Rds.IRdsClusterScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#auto_pause RdsCluster#auto_pause}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoPause", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoPause
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#max_capacity RdsCluster#max_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#min_capacity RdsCluster#min_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#seconds_until_auto_pause RdsCluster#seconds_until_auto_pause}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondsUntilAutoPause", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SecondsUntilAutoPause
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#timeout_action RdsCluster#timeout_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeoutAction
        {
            get;
            set;
        }
    }
}
