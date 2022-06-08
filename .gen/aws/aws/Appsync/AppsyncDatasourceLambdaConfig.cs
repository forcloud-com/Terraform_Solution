using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsync.AppsyncDatasourceLambdaConfig")]
    public class AppsyncDatasourceLambdaConfig : aws.Appsync.IAppsyncDatasourceLambdaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#function_arn AppsyncDatasource#function_arn}.</summary>
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionArn
        {
            get;
            set;
        }
    }
}
