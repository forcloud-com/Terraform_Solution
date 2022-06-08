using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiByValue(fqn: "aws.batch.BatchJobDefinitionTimeout")]
    public class BatchJobDefinitionTimeout : aws.Batch.IBatchJobDefinitionTimeout
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#attempt_duration_seconds BatchJobDefinition#attempt_duration_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attemptDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AttemptDurationSeconds
        {
            get;
            set;
        }
    }
}
