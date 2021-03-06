using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiInterface(nativeType: typeof(IAppsyncResolverPipelineConfig), fullyQualifiedName: "aws.appsync.AppsyncResolverPipelineConfig")]
    public interface IAppsyncResolverPipelineConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#functions AppsyncResolver#functions}.</summary>
        [JsiiProperty(name: "functions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Functions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncResolverPipelineConfig), fullyQualifiedName: "aws.appsync.AppsyncResolverPipelineConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appsync.IAppsyncResolverPipelineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#functions AppsyncResolver#functions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Functions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
