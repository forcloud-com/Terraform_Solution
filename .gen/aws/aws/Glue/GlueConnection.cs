using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/glue_connection aws_glue_connection}.</summary>
    [JsiiClass(nativeType: typeof(aws.Glue.GlueConnection), fullyQualifiedName: "aws.glue.GlueConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glue.GlueConnectionConfig\"}}]")]
    public class GlueConnection : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/glue_connection aws_glue_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueConnection(Constructs.Construct scope, string id, aws.Glue.IGlueConnectionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueConnection(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPhysicalConnectionRequirements", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueConnectionPhysicalConnectionRequirements\"}}]")]
        public virtual void PutPhysicalConnectionRequirements(aws.Glue.IGlueConnectionPhysicalConnectionRequirements @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueConnectionPhysicalConnectionRequirements)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionType")]
        public virtual void ResetConnectionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMatchCriteria")]
        public virtual void ResetMatchCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhysicalConnectionRequirements")]
        public virtual void ResetPhysicalConnectionRequirements()
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
        = GetStaticProperty<string>(typeof(aws.Glue.GlueConnection))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "physicalConnectionRequirements", typeJson: "{\"fqn\":\"aws.glue.GlueConnectionPhysicalConnectionRequirementsOutputReference\"}")]
        public virtual aws.Glue.GlueConnectionPhysicalConnectionRequirementsOutputReference PhysicalConnectionRequirements
        {
            get => GetInstanceProperty<aws.Glue.GlueConnectionPhysicalConnectionRequirementsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionPropertiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ConnectionPropertiesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchCriteriaInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MatchCriteriaInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "physicalConnectionRequirementsInput", typeJson: "{\"fqn\":\"aws.glue.GlueConnectionPhysicalConnectionRequirements\"}", isOptional: true)]
        public virtual aws.Glue.IGlueConnectionPhysicalConnectionRequirements? PhysicalConnectionRequirementsInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueConnectionPhysicalConnectionRequirements?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> ConnectionProperties
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "matchCriteria", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MatchCriteria
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
