using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    #pragma warning disable CS8618

    /// <summary>AWS VPC.</summary>
    [JsiiByValue(fqn: "aws.vpc.FlowLogConfig")]
    public class FlowLogConfig : aws.Vpc.IFlowLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#traffic_type FlowLog#traffic_type}.</summary>
        [JsiiProperty(name: "trafficType", typeJson: "{\"primitive\":\"string\"}")]
        public string TrafficType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#eni_id FlowLog#eni_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eniId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EniId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#iam_role_arn FlowLog#iam_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IamRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#log_destination FlowLog#log_destination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogDestination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#log_destination_type FlowLog#log_destination_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logDestinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogDestinationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#log_format FlowLog#log_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#log_group_name FlowLog#log_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#max_aggregation_interval FlowLog#max_aggregation_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAggregationInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAggregationInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#subnet_id FlowLog#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#tags FlowLog#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/flow_log#vpc_id FlowLog#vpc_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcId
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
