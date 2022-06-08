using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsync.AppsyncDatasourceDynamodbConfig")]
    public class AppsyncDatasourceDynamodbConfig : aws.Appsync.IAppsyncDatasourceDynamodbConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#table_name AppsyncDatasource#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public string TableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#region AppsyncDatasource#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_datasource#use_caller_credentials AppsyncDatasource#use_caller_credentials}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useCallerCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseCallerCredentials
        {
            get;
            set;
        }
    }
}
