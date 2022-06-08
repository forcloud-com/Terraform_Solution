using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Neptune
{
    #pragma warning disable CS8618

    /// <summary>AWS Neptune.</summary>
    [JsiiByValue(fqn: "aws.neptune.NeptuneClusterInstanceConfig")]
    public class NeptuneClusterInstanceConfig : aws.Neptune.INeptuneClusterInstanceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#cluster_identifier NeptuneClusterInstance#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#instance_class NeptuneClusterInstance#instance_class}.</summary>
        [JsiiProperty(name: "instanceClass", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#apply_immediately NeptuneClusterInstance#apply_immediately}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ApplyImmediately
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#auto_minor_version_upgrade NeptuneClusterInstance#auto_minor_version_upgrade}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoMinorVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#availability_zone NeptuneClusterInstance#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#engine NeptuneClusterInstance#engine}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Engine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#engine_version NeptuneClusterInstance#engine_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#identifier NeptuneClusterInstance#identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Identifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#identifier_prefix NeptuneClusterInstance#identifier_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentifierPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#neptune_parameter_group_name NeptuneClusterInstance#neptune_parameter_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "neptuneParameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NeptuneParameterGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#neptune_subnet_group_name NeptuneClusterInstance#neptune_subnet_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "neptuneSubnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NeptuneSubnetGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#port NeptuneClusterInstance#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#preferred_backup_window NeptuneClusterInstance#preferred_backup_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredBackupWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#preferred_maintenance_window NeptuneClusterInstance#preferred_maintenance_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredMaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#promotion_tier NeptuneClusterInstance#promotion_tier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "promotionTier", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PromotionTier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#publicly_accessible NeptuneClusterInstance#publicly_accessible}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PubliclyAccessible
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#tags NeptuneClusterInstance#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_instance#timeouts NeptuneClusterInstance#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.neptune.NeptuneClusterInstanceTimeouts\"}", isOptional: true)]
        public aws.Neptune.INeptuneClusterInstanceTimeouts? Timeouts
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
