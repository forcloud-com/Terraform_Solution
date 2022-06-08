using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    /// <summary>AWS Elastic MapReduce.</summary>
    [JsiiInterface(nativeType: typeof(IEmrInstanceGroupConfig), fullyQualifiedName: "aws.emr.EmrInstanceGroupConfig")]
    public interface IEmrInstanceGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#cluster_id EmrInstanceGroup#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#instance_type EmrInstanceGroup#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#autoscaling_policy EmrInstanceGroup#autoscaling_policy}.</summary>
        [JsiiProperty(name: "autoscalingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoscalingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#bid_price EmrInstanceGroup#bid_price}.</summary>
        [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BidPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#configurations_json EmrInstanceGroup#configurations_json}.</summary>
        [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigurationsJson
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#ebs_config EmrInstanceGroup#ebs_config}
        /// </remarks>
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceGroupEbsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EbsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#ebs_optimized EmrInstanceGroup#ebs_optimized}.</summary>
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EbsOptimized
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#instance_count EmrInstanceGroup#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#name EmrInstanceGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Elastic MapReduce.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEmrInstanceGroupConfig), fullyQualifiedName: "aws.emr.EmrInstanceGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrInstanceGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#cluster_id EmrInstanceGroup#cluster_id}.</summary>
            [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#instance_type EmrInstanceGroup#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#autoscaling_policy EmrInstanceGroup#autoscaling_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoscalingPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#bid_price EmrInstanceGroup#bid_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BidPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#configurations_json EmrInstanceGroup#configurations_json}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigurationsJson
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ebs_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#ebs_config EmrInstanceGroup#ebs_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceGroupEbsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EbsConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#ebs_optimized EmrInstanceGroup#ebs_optimized}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EbsOptimized
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#instance_count EmrInstanceGroup#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#name EmrInstanceGroup#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
