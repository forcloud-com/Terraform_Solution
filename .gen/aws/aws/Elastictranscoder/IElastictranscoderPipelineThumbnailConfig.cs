using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPipelineThumbnailConfig), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfig")]
    public interface IElastictranscoderPipelineThumbnailConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#bucket ElastictranscoderPipeline#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#storage_class ElastictranscoderPipeline#storage_class}.</summary>
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageClass
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPipelineThumbnailConfig), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#bucket ElastictranscoderPipeline#bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#storage_class ElastictranscoderPipeline#storage_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageClass
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
