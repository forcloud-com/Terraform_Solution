using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiByValue(fqn: "aws.elastictranscoder.ElastictranscoderPipelineContentConfigPermissions")]
    public class ElastictranscoderPipelineContentConfigPermissions : aws.Elastictranscoder.IElastictranscoderPipelineContentConfigPermissions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#access ElastictranscoderPipeline#access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Access
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#grantee ElastictranscoderPipeline#grantee}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grantee", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Grantee
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastictranscoder_pipeline#grantee_type ElastictranscoderPipeline#grantee_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "granteeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GranteeType
        {
            get;
            set;
        }
    }
}
