using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>AWS Glue.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsGlueScriptConfig), fullyQualifiedName: "aws.glue.DataAwsGlueScriptConfig")]
    public interface IDataAwsGlueScriptConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>dag_edge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#dag_edge DataAwsGlueScript#dag_edge}
        /// </remarks>
        [JsiiProperty(name: "dagEdge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}]}}")]
        object DagEdge
        {
            get;
        }

        /// <summary>dag_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#dag_node DataAwsGlueScript#dag_node}
        /// </remarks>
        [JsiiProperty(name: "dagNode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}]}}")]
        object DagNode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#language DataAwsGlueScript#language}.</summary>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Language
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Glue.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsGlueScriptConfig), fullyQualifiedName: "aws.glue.DataAwsGlueScriptConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IDataAwsGlueScriptConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dag_edge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#dag_edge DataAwsGlueScript#dag_edge}
            /// </remarks>
            [JsiiProperty(name: "dagEdge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}]}}")]
            public object DagEdge
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>dag_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#dag_node DataAwsGlueScript#dag_node}
            /// </remarks>
            [JsiiProperty(name: "dagNode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}]}}")]
            public object DagNode
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#language DataAwsGlueScript#language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Language
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
