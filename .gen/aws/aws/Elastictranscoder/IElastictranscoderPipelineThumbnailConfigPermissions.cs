using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPipelineThumbnailConfigPermissions), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfigPermissions")]
    public interface IElastictranscoderPipelineThumbnailConfigPermissions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#access ElastictranscoderPipeline#access}.</summary>
        [JsiiProperty(name: "access", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Access
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#grantee ElastictranscoderPipeline#grantee}.</summary>
        [JsiiProperty(name: "grantee", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Grantee
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#grantee_type ElastictranscoderPipeline#grantee_type}.</summary>
        [JsiiProperty(name: "granteeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GranteeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPipelineThumbnailConfigPermissions), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPipelineThumbnailConfigPermissions")]
        internal sealed class _Proxy : DeputyBase, aws.Elastictranscoder.IElastictranscoderPipelineThumbnailConfigPermissions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#access ElastictranscoderPipeline#access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "access", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Access
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#grantee ElastictranscoderPipeline#grantee}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grantee", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Grantee
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#grantee_type ElastictranscoderPipeline#grantee_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "granteeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GranteeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
