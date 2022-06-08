using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueJobExecutionProperty")]
    public class GlueJobExecutionProperty : aws.Glue.IGlueJobExecutionProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#max_concurrent_runs GlueJob#max_concurrent_runs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentRuns
        {
            get;
            set;
        }
    }
}
