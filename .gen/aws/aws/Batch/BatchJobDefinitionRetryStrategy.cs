using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiByValue(fqn: "aws.batch.BatchJobDefinitionRetryStrategy")]
    public class BatchJobDefinitionRetryStrategy : aws.Batch.IBatchJobDefinitionRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#attempts BatchJobDefinition#attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Attempts
        {
            get;
            set;
        }
    }
}
