using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceLambdaConfig), fullyQualifiedName: "aws.appsync.AppsyncDatasourceLambdaConfig")]
    public interface IAppsyncDatasourceLambdaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#function_arn AppsyncDatasource#function_arn}.</summary>
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceLambdaConfig), fullyQualifiedName: "aws.appsync.AppsyncDatasourceLambdaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appsync.IAppsyncDatasourceLambdaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#function_arn AppsyncDatasource#function_arn}.</summary>
            [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
