using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    #pragma warning disable CS8618

    /// <summary>AWS DynamoDB.</summary>
    [JsiiByValue(fqn: "aws.dynamodb.DynamodbTableConfig")]
    public class DynamodbTableConfig : aws.Dynamodb.IDynamodbTableConfig
    {
        /// <summary>attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#attribute DynamodbTable#attribute}
        /// </remarks>
        [JsiiProperty(name: "attribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableAttribute\"},\"kind\":\"array\"}}]}}")]
        public object Attribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#hash_key DynamodbTable#hash_key}.</summary>
        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        public string HashKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#name DynamodbTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#billing_mode DynamodbTable#billing_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BillingMode
        {
            get;
            set;
        }

        /// <summary>global_secondary_index block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#global_secondary_index DynamodbTable#global_secondary_index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "globalSecondaryIndex", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GlobalSecondaryIndex
        {
            get;
            set;
        }

        /// <summary>local_secondary_index block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#local_secondary_index DynamodbTable#local_secondary_index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localSecondaryIndex", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LocalSecondaryIndex
        {
            get;
            set;
        }

        /// <summary>point_in_time_recovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#point_in_time_recovery DynamodbTable#point_in_time_recovery}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTablePointInTimeRecovery\"}", isOptional: true)]
        public aws.Dynamodb.IDynamodbTablePointInTimeRecovery? PointInTimeRecovery
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#range_key DynamodbTable#range_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RangeKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#read_capacity DynamodbTable#read_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadCapacity
        {
            get;
            set;
        }

        /// <summary>replica block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#replica DynamodbTable#replica}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replica", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dynamodb.DynamodbTableReplica\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Replica
        {
            get;
            set;
        }

        /// <summary>server_side_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#server_side_encryption DynamodbTable#server_side_encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTableServerSideEncryption\"}", isOptional: true)]
        public aws.Dynamodb.IDynamodbTableServerSideEncryption? ServerSideEncryption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#stream_enabled DynamodbTable#stream_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? StreamEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#stream_view_type DynamodbTable#stream_view_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamViewType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#tags DynamodbTable#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#timeouts DynamodbTable#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTableTimeouts\"}", isOptional: true)]
        public aws.Dynamodb.IDynamodbTableTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>ttl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#ttl DynamodbTable#ttl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"fqn\":\"aws.dynamodb.DynamodbTableTtl\"}", isOptional: true)]
        public aws.Dynamodb.IDynamodbTableTtl? Ttl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#write_capacity DynamodbTable#write_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WriteCapacity
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
