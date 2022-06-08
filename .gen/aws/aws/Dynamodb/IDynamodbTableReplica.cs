using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableReplica), fullyQualifiedName: "aws.dynamodb.DynamodbTableReplica")]
    public interface IDynamodbTableReplica
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#region_name DynamodbTable#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableReplica), fullyQualifiedName: "aws.dynamodb.DynamodbTableReplica")]
        internal sealed class _Proxy : DeputyBase, aws.Dynamodb.IDynamodbTableReplica
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#region_name DynamodbTable#region_name}.</summary>
            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
