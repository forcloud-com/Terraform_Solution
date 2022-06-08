using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    /// <summary>AWS DataSync.</summary>
    [JsiiInterface(nativeType: typeof(IDatasyncLocationNfsConfig), fullyQualifiedName: "aws.datasync.DatasyncLocationNfsConfig")]
    public interface IDatasyncLocationNfsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>on_prem_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#on_prem_config DatasyncLocationNfs#on_prem_config}
        /// </remarks>
        [JsiiProperty(name: "onPremConfig", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationNfsOnPremConfig\"}")]
        aws.Datasync.IDatasyncLocationNfsOnPremConfig OnPremConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#server_hostname DatasyncLocationNfs#server_hostname}.</summary>
        [JsiiProperty(name: "serverHostname", typeJson: "{\"primitive\":\"string\"}")]
        string ServerHostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#subdirectory DatasyncLocationNfs#subdirectory}.</summary>
        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
        string Subdirectory
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#tags DatasyncLocationNfs#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS DataSync.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationNfsConfig), fullyQualifiedName: "aws.datasync.DatasyncLocationNfsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Datasync.IDatasyncLocationNfsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_prem_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#on_prem_config DatasyncLocationNfs#on_prem_config}
            /// </remarks>
            [JsiiProperty(name: "onPremConfig", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationNfsOnPremConfig\"}")]
            public aws.Datasync.IDatasyncLocationNfsOnPremConfig OnPremConfig
            {
                get => GetInstanceProperty<aws.Datasync.IDatasyncLocationNfsOnPremConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#server_hostname DatasyncLocationNfs#server_hostname}.</summary>
            [JsiiProperty(name: "serverHostname", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerHostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#subdirectory DatasyncLocationNfs#subdirectory}.</summary>
            [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
            public string Subdirectory
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#tags DatasyncLocationNfs#tags}.</summary>
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
