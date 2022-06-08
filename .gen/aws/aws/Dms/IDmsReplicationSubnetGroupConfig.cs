using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    /// <summary>AWS Database Migration Service.</summary>
    [JsiiInterface(nativeType: typeof(IDmsReplicationSubnetGroupConfig), fullyQualifiedName: "aws.dms.DmsReplicationSubnetGroupConfig")]
    public interface IDmsReplicationSubnetGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_subnet_group#replication_subnet_group_description DmsReplicationSubnetGroup#replication_subnet_group_description}.</summary>
        [JsiiProperty(name: "replicationSubnetGroupDescription", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicationSubnetGroupDescription
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_subnet_group#replication_subnet_group_id DmsReplicationSubnetGroup#replication_subnet_group_id}.</summary>
        [JsiiProperty(name: "replicationSubnetGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicationSubnetGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_subnet_group#subnet_ids DmsReplicationSubnetGroup#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_subnet_group#tags DmsReplicationSubnetGroup#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Database Migration Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDmsReplicationSubnetGroupConfig), fullyQualifiedName: "aws.dms.DmsReplicationSubnetGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Dms.IDmsReplicationSubnetGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_subnet_group#replication_subnet_group_description DmsReplicationSubnetGroup#replication_subnet_group_description}.</summary>
            [JsiiProperty(name: "replicationSubnetGroupDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicationSubnetGroupDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_subnet_group#replication_subnet_group_id DmsReplicationSubnetGroup#replication_subnet_group_id}.</summary>
            [JsiiProperty(name: "replicationSubnetGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicationSubnetGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_subnet_group#subnet_ids DmsReplicationSubnetGroup#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_subnet_group#tags DmsReplicationSubnetGroup#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
