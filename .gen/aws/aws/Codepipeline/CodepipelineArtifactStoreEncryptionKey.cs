using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineArtifactStoreEncryptionKey")]
    public class CodepipelineArtifactStoreEncryptionKey : aws.Codepipeline.ICodepipelineArtifactStoreEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#id Codepipeline#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#type Codepipeline#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
