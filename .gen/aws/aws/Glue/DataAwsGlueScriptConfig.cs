using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    /// <summary>AWS Glue.</summary>
    [JsiiByValue(fqn: "aws.glue.DataAwsGlueScriptConfig")]
    public class DataAwsGlueScriptConfig : aws.Glue.IDataAwsGlueScriptConfig
    {
        /// <summary>dag_edge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#dag_edge DataAwsGlueScript#dag_edge}
        /// </remarks>
        [JsiiProperty(name: "dagEdge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}]}}")]
        public object DagEdge
        {
            get;
            set;
        }

        /// <summary>dag_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#dag_node DataAwsGlueScript#dag_node}
        /// </remarks>
        [JsiiProperty(name: "dagNode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}]}}")]
        public object DagNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#language DataAwsGlueScript#language}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Language
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
