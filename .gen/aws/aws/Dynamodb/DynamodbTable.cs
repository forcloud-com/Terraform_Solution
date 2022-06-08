using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table aws_dynamodb_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.Dynamodb.DynamodbTable), fullyQualifiedName: "aws.dynamodb.DynamodbTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dynamodb.DynamodbTableConfig\"}}]")]
    public class DynamodbTable : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table aws_dynamodb_table} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DynamodbTable(Constructs.Construct scope, string id, aws.Dynamodb.IDynamodbTableConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTable(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPointInTimeRecovery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodb.DynamodbTablePointInTimeRecovery\"}}]")]
        public virtual void PutPointInTimeRecovery(aws.Dynamodb.IDynamodbTablePointInTimeRecovery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dynamodb.IDynamodbTablePointInTimeRecovery)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerSideEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodb.DynamodbTableServerSideEncryption\"}}]")]
        public virtual void PutServerSideEncryption(aws.Dynamodb.IDynamodbTableServerSideEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dynamodb.IDynamodbTableServerSideEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodb.DynamodbTableTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Dynamodb.IDynamodbTableTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dynamodb.IDynamodbTableTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTtl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodb.DynamodbTableTtl\"}}]")]
        public virtual void PutTtl(aws.Dynamodb.IDynamodbTableTtl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dynamodb.IDynamodbTableTtl)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBillingMode")]
        public virtual void ResetBillingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlobalSecondaryIndex")]
        public virtual void ResetGlobalSecondaryIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalSecondaryIndex")]
        public virtual void ResetLocalSecondaryIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPointInTimeRecovery")]
        public virtual void ResetPointInTimeRecovery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRangeKey")]
        public virtual void ResetRangeKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadCapacity")]
        public virtual void ResetReadCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplica")]
        public virtual void ResetReplica()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryption")]
        public virtual void ResetServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamEnabled")]
        public virtual void ResetStreamEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamViewType")]
        public virtual void ResetStreamViewType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTtl")]
        public virtual void ResetTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteCapacity")]
        public virtual void ResetWriteCapacity()
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
        = GetStaticProperty<string>(typeof(aws.Dynamodb.DynamodbTable))!;

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

        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTablePointInTimeRecoveryOutputReference\"}")]
        public virtual aws.Dynamodb.DynamodbTablePointInTimeRecoveryOutputReference PointInTimeRecovery
        {
            get => GetInstanceProperty<aws.Dynamodb.DynamodbTablePointInTimeRecoveryOutputReference>()!;
        }

        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTableServerSideEncryptionOutputReference\"}")]
        public virtual aws.Dynamodb.DynamodbTableServerSideEncryptionOutputReference ServerSideEncryption
        {
            get => GetInstanceProperty<aws.Dynamodb.DynamodbTableServerSideEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTableTimeoutsOutputReference\"}")]
        public virtual aws.Dynamodb.DynamodbTableTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Dynamodb.DynamodbTableTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTableTtlOutputReference\"}")]
        public virtual aws.Dynamodb.DynamodbTableTtlOutputReference Ttl
        {
            get => GetInstanceProperty<aws.Dynamodb.DynamodbTableTtlOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AttributeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalSecondaryIndexInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GlobalSecondaryIndexInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HashKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localSecondaryIndexInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LocalSecondaryIndexInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeRecoveryInput", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTablePointInTimeRecovery\"}", isOptional: true)]
        public virtual aws.Dynamodb.IDynamodbTablePointInTimeRecovery? PointInTimeRecoveryInput
        {
            get => GetInstanceProperty<aws.Dynamodb.IDynamodbTablePointInTimeRecovery?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RangeKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableReplica\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ReplicaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionInput", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTableServerSideEncryption\"}", isOptional: true)]
        public virtual aws.Dynamodb.IDynamodbTableServerSideEncryption? ServerSideEncryptionInput
        {
            get => GetInstanceProperty<aws.Dynamodb.IDynamodbTableServerSideEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StreamEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamViewTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamViewTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTableTimeouts\"}", isOptional: true)]
        public virtual aws.Dynamodb.IDynamodbTableTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Dynamodb.IDynamodbTableTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttlInput", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTableTtl\"}", isOptional: true)]
        public virtual aws.Dynamodb.IDynamodbTableTtl? TtlInput
        {
            get => GetInstanceProperty<aws.Dynamodb.IDynamodbTableTtl?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "attribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableAttribute\"},\"kind\":\"array\"}}]}}")]
        public virtual object Attribute
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "globalSecondaryIndex", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}]}}")]
        public virtual object GlobalSecondaryIndex
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localSecondaryIndex", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}]}}")]
        public virtual object LocalSecondaryIndex
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replica", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableReplica\"},\"kind\":\"array\"}}]}}")]
        public virtual object Replica
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StreamEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamViewType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
