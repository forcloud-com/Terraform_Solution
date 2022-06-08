using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceHttpConfig), fullyQualifiedName: "aws.appsync.AppsyncDatasourceHttpConfig")]
    public interface IAppsyncDatasourceHttpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#endpoint AppsyncDatasource#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceHttpConfig), fullyQualifiedName: "aws.appsync.AppsyncDatasourceHttpConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appsync.IAppsyncDatasourceHttpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#endpoint AppsyncDatasource#endpoint}.</summary>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
