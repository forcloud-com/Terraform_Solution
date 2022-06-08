using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    [JsiiInterface(nativeType: typeof(IDynamodbTablePointInTimeRecovery), fullyQualifiedName: "aws.dynamodb.DynamodbTablePointInTimeRecovery")]
    public interface IDynamodbTablePointInTimeRecovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#enabled DynamodbTable#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTablePointInTimeRecovery), fullyQualifiedName: "aws.dynamodb.DynamodbTablePointInTimeRecovery")]
        internal sealed class _Proxy : DeputyBase, aws.Dynamodb.IDynamodbTablePointInTimeRecovery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#enabled DynamodbTable#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
