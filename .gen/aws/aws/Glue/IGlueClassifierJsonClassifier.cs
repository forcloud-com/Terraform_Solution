using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierJsonClassifier), fullyQualifiedName: "aws.glue.GlueClassifierJsonClassifier")]
    public interface IGlueClassifierJsonClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#json_path GlueClassifier#json_path}.</summary>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        string JsonPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierJsonClassifier), fullyQualifiedName: "aws.glue.GlueClassifierJsonClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueClassifierJsonClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier#json_path GlueClassifier#json_path}.</summary>
            [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
            public string JsonPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
