using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiByValue(fqn: "aws.elastictranscoder.ElastictranscoderPipelineNotifications")]
    public class ElastictranscoderPipelineNotifications : aws.Elastictranscoder.IElastictranscoderPipelineNotifications
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#completed ElastictranscoderPipeline#completed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Completed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#error ElastictranscoderPipeline#error}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Error
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#progressing ElastictranscoderPipeline#progressing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "progressing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Progressing
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#warning ElastictranscoderPipeline#warning}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Warning
        {
            get;
            set;
        }
    }
}
