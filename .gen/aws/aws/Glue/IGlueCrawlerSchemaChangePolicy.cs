using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerSchemaChangePolicy), fullyQualifiedName: "aws.glue.GlueCrawlerSchemaChangePolicy")]
    public interface IGlueCrawlerSchemaChangePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#delete_behavior GlueCrawler#delete_behavior}.</summary>
        [JsiiProperty(name: "deleteBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeleteBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#update_behavior GlueCrawler#update_behavior}.</summary>
        [JsiiProperty(name: "updateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerSchemaChangePolicy), fullyQualifiedName: "aws.glue.GlueCrawlerSchemaChangePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueCrawlerSchemaChangePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#delete_behavior GlueCrawler#delete_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeleteBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#update_behavior GlueCrawler#update_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateBehavior
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
