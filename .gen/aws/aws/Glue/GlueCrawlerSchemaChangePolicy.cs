using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueCrawlerSchemaChangePolicy")]
    public class GlueCrawlerSchemaChangePolicy : aws.Glue.IGlueCrawlerSchemaChangePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#delete_behavior GlueCrawler#delete_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeleteBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#update_behavior GlueCrawler#update_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateBehavior
        {
            get;
            set;
        }
    }
}
