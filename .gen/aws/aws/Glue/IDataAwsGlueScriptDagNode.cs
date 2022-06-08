using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IDataAwsGlueScriptDagNode), fullyQualifiedName: "aws.glue.DataAwsGlueScriptDagNode")]
    public interface IDataAwsGlueScriptDagNode
    {
        /// <summary>args block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#args DataAwsGlueScript#args}
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagNodeArgs\"},\"kind\":\"array\"}}]}}")]
        object Args
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#id DataAwsGlueScript#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#node_type DataAwsGlueScript#node_type}.</summary>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#line_number DataAwsGlueScript#line_number}.</summary>
        [JsiiProperty(name: "lineNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LineNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsGlueScriptDagNode), fullyQualifiedName: "aws.glue.DataAwsGlueScriptDagNode")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IDataAwsGlueScriptDagNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>args block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#args DataAwsGlueScript#args}
            /// </remarks>
            [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagNodeArgs\"},\"kind\":\"array\"}}]}}")]
            public object Args
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#id DataAwsGlueScript#id}.</summary>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#node_type DataAwsGlueScript#node_type}.</summary>
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/glue_script#line_number DataAwsGlueScript#line_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lineNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LineNumber
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
