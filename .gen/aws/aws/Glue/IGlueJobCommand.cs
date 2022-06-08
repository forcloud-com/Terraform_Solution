using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueJobCommand), fullyQualifiedName: "aws.glue.GlueJobCommand")]
    public interface IGlueJobCommand
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#script_location GlueJob#script_location}.</summary>
        [JsiiProperty(name: "scriptLocation", typeJson: "{\"primitive\":\"string\"}")]
        string ScriptLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#name GlueJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#python_version GlueJob#python_version}.</summary>
        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PythonVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueJobCommand), fullyQualifiedName: "aws.glue.GlueJobCommand")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueJobCommand
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#script_location GlueJob#script_location}.</summary>
            [JsiiProperty(name: "scriptLocation", typeJson: "{\"primitive\":\"string\"}")]
            public string ScriptLocation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#name GlueJob#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#python_version GlueJob#python_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PythonVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
