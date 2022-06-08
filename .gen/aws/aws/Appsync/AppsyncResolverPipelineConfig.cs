using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiByValue(fqn: "aws.appsync.AppsyncResolverPipelineConfig")]
    public class AppsyncResolverPipelineConfig : aws.Appsync.IAppsyncResolverPipelineConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#functions AppsyncResolver#functions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "functions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Functions
        {
            get;
            set;
        }
    }
}
