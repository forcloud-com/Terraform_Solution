using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Documentdb
{
    /// <summary>AWS DocumentDB.</summary>
    [JsiiInterface(nativeType: typeof(IDocdbClusterInstanceConfig), fullyQualifiedName: "aws.documentdb.DocdbClusterInstanceConfig")]
    public interface IDocdbClusterInstanceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#cluster_identifier DocdbClusterInstance#cluster_identifier}.</summary>
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#instance_class DocdbClusterInstance#instance_class}.</summary>
        [JsiiProperty(name: "instanceClass", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceClass
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#apply_immediately DocdbClusterInstance#apply_immediately}.</summary>
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplyImmediately
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#auto_minor_version_upgrade DocdbClusterInstance#auto_minor_version_upgrade}.</summary>
        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoMinorVersionUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#availability_zone DocdbClusterInstance#availability_zone}.</summary>
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#ca_cert_identifier DocdbClusterInstance#ca_cert_identifier}.</summary>
        [JsiiProperty(name: "caCertIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaCertIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#engine DocdbClusterInstance#engine}.</summary>
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Engine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#identifier DocdbClusterInstance#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Identifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#identifier_prefix DocdbClusterInstance#identifier_prefix}.</summary>
        [JsiiProperty(name: "identifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentifierPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#preferred_maintenance_window DocdbClusterInstance#preferred_maintenance_window}.</summary>
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredMaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#promotion_tier DocdbClusterInstance#promotion_tier}.</summary>
        [JsiiProperty(name: "promotionTier", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PromotionTier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#tags DocdbClusterInstance#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#timeouts DocdbClusterInstance#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.documentdb.DocdbClusterInstanceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Documentdb.IDocdbClusterInstanceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS DocumentDB.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDocdbClusterInstanceConfig), fullyQualifiedName: "aws.documentdb.DocdbClusterInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Documentdb.IDocdbClusterInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#cluster_identifier DocdbClusterInstance#cluster_identifier}.</summary>
            [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#instance_class DocdbClusterInstance#instance_class}.</summary>
            [JsiiProperty(name: "instanceClass", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceClass
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#apply_immediately DocdbClusterInstance#apply_immediately}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applyImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ApplyImmediately
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#auto_minor_version_upgrade DocdbClusterInstance#auto_minor_version_upgrade}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoMinorVersionUpgrade
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#availability_zone DocdbClusterInstance#availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#ca_cert_identifier DocdbClusterInstance#ca_cert_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caCertIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaCertIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#engine DocdbClusterInstance#engine}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Engine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#identifier DocdbClusterInstance#identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Identifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#identifier_prefix DocdbClusterInstance#identifier_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentifierPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#preferred_maintenance_window DocdbClusterInstance#preferred_maintenance_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredMaintenanceWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#promotion_tier DocdbClusterInstance#promotion_tier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "promotionTier", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PromotionTier
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#tags DocdbClusterInstance#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_instance#timeouts DocdbClusterInstance#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.documentdb.DocdbClusterInstanceTimeouts\"}", isOptional: true)]
            public aws.Documentdb.IDocdbClusterInstanceTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Documentdb.IDocdbClusterInstanceTimeouts?>();
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
