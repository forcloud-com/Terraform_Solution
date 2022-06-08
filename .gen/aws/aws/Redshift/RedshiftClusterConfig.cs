using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    #pragma warning disable CS8618

    /// <summary>AWS Redshift.</summary>
    [JsiiByValue(fqn: "aws.redshift.RedshiftClusterConfig")]
    public class RedshiftClusterConfig : aws.Redshift.IRedshiftClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#cluster_identifier RedshiftCluster#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#node_type RedshiftCluster#node_type}.</summary>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#allow_version_upgrade RedshiftCluster#allow_version_upgrade}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#automated_snapshot_retention_period RedshiftCluster#automated_snapshot_retention_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automatedSnapshotRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutomatedSnapshotRetentionPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#availability_zone RedshiftCluster#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#bucket_name RedshiftCluster#bucket_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#cluster_parameter_group_name RedshiftCluster#cluster_parameter_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterParameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterParameterGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#cluster_public_key RedshiftCluster#cluster_public_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterPublicKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#cluster_revision_number RedshiftCluster#cluster_revision_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterRevisionNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterRevisionNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#cluster_security_groups RedshiftCluster#cluster_security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterSecurityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ClusterSecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#cluster_subnet_group_name RedshiftCluster#cluster_subnet_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterSubnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterSubnetGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#cluster_type RedshiftCluster#cluster_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#cluster_version RedshiftCluster#cluster_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#database_name RedshiftCluster#database_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#elastic_ip RedshiftCluster#elastic_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElasticIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#enable_logging RedshiftCluster#enable_logging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableLogging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableLogging
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#encrypted RedshiftCluster#encrypted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Encrypted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#endpoint RedshiftCluster#endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#enhanced_vpc_routing RedshiftCluster#enhanced_vpc_routing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enhancedVpcRouting", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnhancedVpcRouting
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#final_snapshot_identifier RedshiftCluster#final_snapshot_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "finalSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FinalSnapshotIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#iam_roles RedshiftCluster#iam_roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IamRoles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#kms_key_id RedshiftCluster#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>logging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#logging RedshiftCluster#logging}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterLogging\"}", isOptional: true)]
        public aws.Redshift.IRedshiftClusterLogging? Logging
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#master_password RedshiftCluster#master_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#master_username RedshiftCluster#master_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#number_of_nodes RedshiftCluster#number_of_nodes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfNodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#owner_account RedshiftCluster#owner_account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ownerAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OwnerAccount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#port RedshiftCluster#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#preferred_maintenance_window RedshiftCluster#preferred_maintenance_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredMaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#publicly_accessible RedshiftCluster#publicly_accessible}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PubliclyAccessible
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#s3_key_prefix RedshiftCluster#s3_key_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3KeyPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#skip_final_snapshot RedshiftCluster#skip_final_snapshot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipFinalSnapshot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SkipFinalSnapshot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#snapshot_cluster_identifier RedshiftCluster#snapshot_cluster_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotClusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>snapshot_copy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#snapshot_copy RedshiftCluster#snapshot_copy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotCopy", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterSnapshotCopy\"}", isOptional: true)]
        public aws.Redshift.IRedshiftClusterSnapshotCopy? SnapshotCopy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#snapshot_identifier RedshiftCluster#snapshot_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#tags RedshiftCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#timeouts RedshiftCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterTimeouts\"}", isOptional: true)]
        public aws.Redshift.IRedshiftClusterTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#vpc_security_group_ids RedshiftCluster#vpc_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpcSecurityGroupIds
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
