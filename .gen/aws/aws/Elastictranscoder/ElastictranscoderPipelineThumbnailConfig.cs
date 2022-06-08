using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiByValue(fqn: "aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfig")]
    public class ElastictranscoderPipelineThumbnailConfig : aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#bucket ElastictranscoderPipeline#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#storage_class ElastictranscoderPipeline#storage_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageClass
        {
            get;
            set;
        }
    }
}
