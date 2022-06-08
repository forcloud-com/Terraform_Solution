using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IDataAwsGlueScriptDagNodeArgs), fullyQualifiedName: "aws.glue.DataAwsGlueScriptDagNodeArgs")]
    public interface IDataAwsGlueScriptDagNodeArgs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#name DataAwsGlueScript#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#value DataAwsGlueScript#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#param DataAwsGlueScript#param}.</summary>
        [JsiiProperty(name: "param", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Param
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsGlueScriptDagNodeArgs), fullyQualifiedName: "aws.glue.DataAwsGlueScriptDagNodeArgs")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IDataAwsGlueScriptDagNodeArgs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#name DataAwsGlueScript#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#value DataAwsGlueScript#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#param DataAwsGlueScript#param}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "param", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Param
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
