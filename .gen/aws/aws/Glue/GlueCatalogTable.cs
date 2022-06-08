using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table aws_glue_catalog_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.Glue.GlueCatalogTable), fullyQualifiedName: "aws.glue.GlueCatalogTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glue.GlueCatalogTableConfig\"}}]")]
    public class GlueCatalogTable : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table aws_glue_catalog_table} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueCatalogTable(Constructs.Construct scope, string id, aws.Glue.IGlueCatalogTableConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTable(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStorageDescriptor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptor\"}}]")]
        public virtual void PutStorageDescriptor(aws.Glue.IGlueCatalogTableStorageDescriptor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueCatalogTableStorageDescriptor)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwner")]
        public virtual void ResetOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartitionKeys")]
        public virtual void ResetPartitionKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetention")]
        public virtual void ResetRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageDescriptor")]
        public virtual void ResetStorageDescriptor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableType")]
        public virtual void ResetTableType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewExpandedText")]
        public virtual void ResetViewExpandedText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewOriginalText")]
        public virtual void ResetViewOriginalText()
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
        = GetStaticProperty<string>(typeof(aws.Glue.GlueCatalogTable))!;

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

        [JsiiProperty(name: "storageDescriptor", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorOutputReference\"}")]
        public virtual aws.Glue.GlueCatalogTableStorageDescriptorOutputReference StorageDescriptor
        {
            get => GetInstanceProperty<aws.Glue.GlueCatalogTableStorageDescriptorOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionKeysInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTablePartitionKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PartitionKeysInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageDescriptorInput", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptor\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptor? StorageDescriptorInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptor?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewExpandedTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewExpandedTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewOriginalTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewOriginalTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partitionKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTablePartitionKeys\"},\"kind\":\"array\"}}]}}")]
        public virtual object PartitionKeys
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retention
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewExpandedText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewExpandedText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewOriginalText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewOriginalText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
