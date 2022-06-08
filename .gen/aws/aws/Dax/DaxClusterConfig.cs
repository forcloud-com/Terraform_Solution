using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dax
{
    #pragma warning disable CS8618

    /// <summary>AWS DynamoDB Accelerator.</summary>
    [JsiiByValue(fqn: "aws.dax.DaxClusterConfig")]
    public class DaxClusterConfig : aws.Dax.IDaxClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#cluster_name DaxCluster#cluster_name}.</summary>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#iam_role_arn DaxCluster#iam_role_arn}.</summary>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string IamRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#node_type DaxCluster#node_type}.</summary>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#replication_factor DaxCluster#replication_factor}.</summary>
        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public double ReplicationFactor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#availability_zones DaxCluster#availability_zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AvailabilityZones
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#description DaxCluster#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#maintenance_window DaxCluster#maintenance_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#notification_topic_arn DaxCluster#notification_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationTopicArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#parameter_group_name DaxCluster#parameter_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParameterGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#security_group_ids DaxCluster#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>server_side_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#server_side_encryption DaxCluster#server_side_encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.dax.DaxClusterServerSideEncryption\"}", isOptional: true)]
        public aws.Dax.IDaxClusterServerSideEncryption? ServerSideEncryption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#subnet_group_name DaxCluster#subnet_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#tags DaxCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#timeouts DaxCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dax.DaxClusterTimeouts\"}", isOptional: true)]
        public aws.Dax.IDaxClusterTimeouts? Timeouts
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
