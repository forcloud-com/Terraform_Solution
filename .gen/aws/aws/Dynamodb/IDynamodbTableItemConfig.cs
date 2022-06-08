using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    /// <summary>AWS DynamoDB.</summary>
    [JsiiInterface(nativeType: typeof(IDynamodbTableItemConfig), fullyQualifiedName: "aws.dynamodb.DynamodbTableItemConfig")]
    public interface IDynamodbTableItemConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table_item#hash_key DynamodbTableItem#hash_key}.</summary>
        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        string HashKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table_item#item DynamodbTableItem#item}.</summary>
        [JsiiProperty(name: "item", typeJson: "{\"primitive\":\"string\"}")]
        string Item
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table_item#table_name DynamodbTableItem#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table_item#range_key DynamodbTableItem#range_key}.</summary>
        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RangeKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS DynamoDB.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableItemConfig), fullyQualifiedName: "aws.dynamodb.DynamodbTableItemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Dynamodb.IDynamodbTableItemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table_item#hash_key DynamodbTableItem#hash_key}.</summary>
            [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
            public string HashKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table_item#item DynamodbTableItem#item}.</summary>
            [JsiiProperty(name: "item", typeJson: "{\"primitive\":\"string\"}")]
            public string Item
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table_item#table_name DynamodbTableItem#table_name}.</summary>
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table_item#range_key DynamodbTableItem#range_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RangeKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
