using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.DataAwsGlueScriptDagNode")]
    public class DataAwsGlueScriptDagNode : aws.Glue.IDataAwsGlueScriptDagNode
    {
        /// <summary>args block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#args DataAwsGlueScript#args}
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagNodeArgs\"},\"kind\":\"array\"}}]}}")]
        public object Args
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#id DataAwsGlueScript#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#node_type DataAwsGlueScript#node_type}.</summary>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#line_number DataAwsGlueScript#line_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lineNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LineNumber
        {
            get;
            set;
        }
    }
}
