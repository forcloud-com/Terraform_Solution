using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    [JsiiInterface(nativeType: typeof(IDynamodbGlobalTableReplica), fullyQualifiedName: "aws.dynamodb.DynamodbGlobalTableReplica")]
    public interface IDynamodbGlobalTableReplica
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_global_table#region_name DynamodbGlobalTable#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbGlobalTableReplica), fullyQualifiedName: "aws.dynamodb.DynamodbGlobalTableReplica")]
        internal sealed class _Proxy : DeputyBase, aws.Dynamodb.IDynamodbGlobalTableReplica
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_global_table#region_name DynamodbGlobalTable#region_name}.</summary>
            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
