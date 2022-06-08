using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableTtl), fullyQualifiedName: "aws.dynamodb.DynamodbTableTtl")]
    public interface IDynamodbTableTtl
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#attribute_name DynamodbTable#attribute_name}.</summary>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#enabled DynamodbTable#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableTtl), fullyQualifiedName: "aws.dynamodb.DynamodbTableTtl")]
        internal sealed class _Proxy : DeputyBase, aws.Dynamodb.IDynamodbTableTtl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#attribute_name DynamodbTable#attribute_name}.</summary>
            [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#enabled DynamodbTable#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
