using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueCrawlerJdbcTarget")]
    public class GlueCrawlerJdbcTarget : aws.Glue.IGlueCrawlerJdbcTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#connection_name GlueCrawler#connection_name}.</summary>
        [JsiiProperty(name: "connectionName", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#path GlueCrawler#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#exclusions GlueCrawler#exclusions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Exclusions
        {
            get;
            set;
        }
    }
}
