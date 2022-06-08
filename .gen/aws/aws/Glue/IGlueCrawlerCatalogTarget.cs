using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerCatalogTarget), fullyQualifiedName: "aws.glue.GlueCrawlerCatalogTarget")]
    public interface IGlueCrawlerCatalogTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#database_name GlueCrawler#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#tables GlueCrawler#tables}.</summary>
        [JsiiProperty(name: "tables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Tables
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerCatalogTarget), fullyQualifiedName: "aws.glue.GlueCrawlerCatalogTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueCrawlerCatalogTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#database_name GlueCrawler#database_name}.</summary>
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#tables GlueCrawler#tables}.</summary>
            [JsiiProperty(name: "tables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Tables
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
