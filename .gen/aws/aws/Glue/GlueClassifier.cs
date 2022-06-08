using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier aws_glue_classifier}.</summary>
    [JsiiClass(nativeType: typeof(aws.Glue.GlueClassifier), fullyQualifiedName: "aws.glue.GlueClassifier", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glue.GlueClassifierConfig\"}}]")]
    public class GlueClassifier : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/glue_classifier aws_glue_classifier} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueClassifier(Constructs.Construct scope, string id, aws.Glue.IGlueClassifierConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifier(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifier(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCsvClassifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueClassifierCsvClassifier\"}}]")]
        public virtual void PutCsvClassifier(aws.Glue.IGlueClassifierCsvClassifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueClassifierCsvClassifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrokClassifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueClassifierGrokClassifier\"}}]")]
        public virtual void PutGrokClassifier(aws.Glue.IGlueClassifierGrokClassifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueClassifierGrokClassifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJsonClassifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueClassifierJsonClassifier\"}}]")]
        public virtual void PutJsonClassifier(aws.Glue.IGlueClassifierJsonClassifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueClassifierJsonClassifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXmlClassifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueClassifierXmlClassifier\"}}]")]
        public virtual void PutXmlClassifier(aws.Glue.IGlueClassifierXmlClassifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueClassifierXmlClassifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCsvClassifier")]
        public virtual void ResetCsvClassifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrokClassifier")]
        public virtual void ResetGrokClassifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJsonClassifier")]
        public virtual void ResetJsonClassifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXmlClassifier")]
        public virtual void ResetXmlClassifier()
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
        = GetStaticProperty<string>(typeof(aws.Glue.GlueClassifier))!;

        [JsiiProperty(name: "csvClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierCsvClassifierOutputReference\"}")]
        public virtual aws.Glue.GlueClassifierCsvClassifierOutputReference CsvClassifier
        {
            get => GetInstanceProperty<aws.Glue.GlueClassifierCsvClassifierOutputReference>()!;
        }

        [JsiiProperty(name: "grokClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierGrokClassifierOutputReference\"}")]
        public virtual aws.Glue.GlueClassifierGrokClassifierOutputReference GrokClassifier
        {
            get => GetInstanceProperty<aws.Glue.GlueClassifierGrokClassifierOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jsonClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierJsonClassifierOutputReference\"}")]
        public virtual aws.Glue.GlueClassifierJsonClassifierOutputReference JsonClassifier
        {
            get => GetInstanceProperty<aws.Glue.GlueClassifierJsonClassifierOutputReference>()!;
        }

        [JsiiProperty(name: "xmlClassifier", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierXmlClassifierOutputReference\"}")]
        public virtual aws.Glue.GlueClassifierXmlClassifierOutputReference XmlClassifier
        {
            get => GetInstanceProperty<aws.Glue.GlueClassifierXmlClassifierOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvClassifierInput", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierCsvClassifier\"}", isOptional: true)]
        public virtual aws.Glue.IGlueClassifierCsvClassifier? CsvClassifierInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueClassifierCsvClassifier?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grokClassifierInput", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierGrokClassifier\"}", isOptional: true)]
        public virtual aws.Glue.IGlueClassifierGrokClassifier? GrokClassifierInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueClassifierGrokClassifier?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jsonClassifierInput", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierJsonClassifier\"}", isOptional: true)]
        public virtual aws.Glue.IGlueClassifierJsonClassifier? JsonClassifierInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueClassifierJsonClassifier?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xmlClassifierInput", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierXmlClassifier\"}", isOptional: true)]
        public virtual aws.Glue.IGlueClassifierXmlClassifier? XmlClassifierInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueClassifierXmlClassifier?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
