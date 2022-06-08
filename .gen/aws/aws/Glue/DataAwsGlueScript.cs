using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/glue_script aws_glue_script}.</summary>
    [JsiiClass(nativeType: typeof(aws.Glue.DataAwsGlueScript), fullyQualifiedName: "aws.glue.DataAwsGlueScript", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glue.DataAwsGlueScriptConfig\"}}]")]
    public class DataAwsGlueScript : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/glue_script aws_glue_script} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsGlueScript(Constructs.Construct scope, string id, aws.Glue.IDataAwsGlueScriptConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueScript(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlueScript(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLanguage")]
        public virtual void ResetLanguage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Glue.DataAwsGlueScript))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pythonScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PythonScript
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scalaCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScalaCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dagEdgeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DagEdgeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dagNodeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DagNodeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "languageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LanguageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dagEdge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagEdge\"},\"kind\":\"array\"}}]}}")]
        public virtual object DagEdge
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dagNode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.DataAwsGlueScriptDagNode\"},\"kind\":\"array\"}}]}}")]
        public virtual object DagNode
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Language
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
