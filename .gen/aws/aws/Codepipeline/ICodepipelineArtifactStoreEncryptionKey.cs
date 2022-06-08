using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineArtifactStoreEncryptionKey), fullyQualifiedName: "aws.codepipeline.CodepipelineArtifactStoreEncryptionKey")]
    public interface ICodepipelineArtifactStoreEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#id Codepipeline#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#type Codepipeline#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineArtifactStoreEncryptionKey), fullyQualifiedName: "aws.codepipeline.CodepipelineArtifactStoreEncryptionKey")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineArtifactStoreEncryptionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#id Codepipeline#id}.</summary>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#type Codepipeline#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
