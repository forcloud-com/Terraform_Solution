using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cur
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/cur_report_definition aws_cur_report_definition}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cur.DataAwsCurReportDefinition), fullyQualifiedName: "aws.cur.DataAwsCurReportDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cur.DataAwsCurReportDefinitionConfig\"}}]")]
    public class DataAwsCurReportDefinition : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/cur_report_definition aws_cur_report_definition} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsCurReportDefinition(Constructs.Construct scope, string id, aws.Cur.IDataAwsCurReportDefinitionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCurReportDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCurReportDefinition(DeputyProps props): base(props)
        {
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
        = GetStaticProperty<string>(typeof(aws.Cur.DataAwsCurReportDefinition))!;

        [JsiiProperty(name: "additionalArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalArtifacts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "additionalSchemaElements", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalSchemaElements
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Compression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Format
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Prefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUnit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "reportName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
