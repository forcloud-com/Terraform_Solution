using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.DataAwsGlueScriptDagNodeArgs")]
    public class DataAwsGlueScriptDagNodeArgs : aws.Glue.IDataAwsGlueScriptDagNodeArgs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#name DataAwsGlueScript#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#value DataAwsGlueScript#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#param DataAwsGlueScript#param}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "param", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Param
        {
            get;
            set;
        }
    }
}
