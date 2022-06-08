using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueJobCommand")]
    public class GlueJobCommand : aws.Glue.IGlueJobCommand
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#script_location GlueJob#script_location}.</summary>
        [JsiiProperty(name: "scriptLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string ScriptLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#name GlueJob#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#python_version GlueJob#python_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PythonVersion
        {
            get;
            set;
        }
    }
}
