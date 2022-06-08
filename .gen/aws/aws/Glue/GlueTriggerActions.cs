using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueTriggerActions")]
    public class GlueTriggerActions : aws.Glue.IGlueTriggerActions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#arguments GlueTrigger#arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Arguments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#crawler_name GlueTrigger#crawler_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crawlerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrawlerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#job_name GlueTrigger#job_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#timeout GlueTrigger#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }
    }
}
