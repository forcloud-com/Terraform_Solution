using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsync.AppsyncDatasourceHttpConfig")]
    public class AppsyncDatasourceHttpConfig : aws.Appsync.IAppsyncDatasourceHttpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#endpoint AppsyncDatasource#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }
    }
}
