using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    /// <summary>AWS Elastic MapReduce.</summary>
    [JsiiByValue(fqn: "aws.emr.EmrClusterConfig")]
    public class EmrClusterConfig : aws.Emr.IEmrClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#name EmrCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#release_label EmrCluster#release_label}.</summary>
        [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}")]
        public string ReleaseLabel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#service_role EmrCluster#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#additional_info EmrCluster#additional_info}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdditionalInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#applications EmrCluster#applications}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Applications
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#autoscaling_role EmrCluster#autoscaling_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoscalingRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoscalingRole
        {
            get;
            set;
        }

        /// <summary>bootstrap_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#bootstrap_action EmrCluster#bootstrap_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootstrapAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BootstrapAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#configurations EmrCluster#configurations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurations", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Configurations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#configurations_json EmrCluster#configurations_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigurationsJson
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#core_instance_count EmrCluster#core_instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoreInstanceCount
        {
            get;
            set;
        }

        /// <summary>core_instance_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#core_instance_group EmrCluster#core_instance_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceGroup", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceGroup\"}", isOptional: true)]
        public aws.Emr.IEmrClusterCoreInstanceGroup? CoreInstanceGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#core_instance_type EmrCluster#core_instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CoreInstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#custom_ami_id EmrCluster#custom_ami_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customAmiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomAmiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ebs_root_volume_size EmrCluster#ebs_root_volume_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsRootVolumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EbsRootVolumeSize
        {
            get;
            set;
        }

        /// <summary>ec2_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ec2_attributes EmrCluster#ec2_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ec2Attributes", typeJson: "{\"fqn\":\"aws.emr.EmrClusterEc2Attributes\"}", isOptional: true)]
        public aws.Emr.IEmrClusterEc2Attributes? Ec2Attributes
        {
            get;
            set;
        }

        /// <summary>instance_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_group EmrCluster#instance_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterInstanceGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InstanceGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#keep_job_flow_alive_when_no_steps EmrCluster#keep_job_flow_alive_when_no_steps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keepJobFlowAliveWhenNoSteps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? KeepJobFlowAliveWhenNoSteps
        {
            get;
            set;
        }

        /// <summary>kerberos_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#kerberos_attributes EmrCluster#kerberos_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kerberosAttributes", typeJson: "{\"fqn\":\"aws.emr.EmrClusterKerberosAttributes\"}", isOptional: true)]
        public aws.Emr.IEmrClusterKerberosAttributes? KerberosAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#log_uri EmrCluster#log_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogUri
        {
            get;
            set;
        }

        /// <summary>master_instance_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#master_instance_group EmrCluster#master_instance_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceGroup", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceGroup\"}", isOptional: true)]
        public aws.Emr.IEmrClusterMasterInstanceGroup? MasterInstanceGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#master_instance_type EmrCluster#master_instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterInstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#scale_down_behavior EmrCluster#scale_down_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleDownBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#security_configuration EmrCluster#security_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#step EmrCluster#step}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "step", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Step
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#step_concurrency_level EmrCluster#step_concurrency_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepConcurrencyLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StepConcurrencyLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#tags EmrCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#termination_protection EmrCluster#termination_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminationProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TerminationProtection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#visible_to_all_users EmrCluster#visible_to_all_users}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "visibleToAllUsers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? VisibleToAllUsers
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
