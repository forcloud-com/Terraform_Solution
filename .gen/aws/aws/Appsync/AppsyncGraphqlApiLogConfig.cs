using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsync.AppsyncGraphqlApiLogConfig")]
    public class AppsyncGraphqlApiLogConfig : aws.Appsync.IAppsyncGraphqlApiLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#cloudwatch_logs_role_arn AppsyncGraphqlApi#cloudwatch_logs_role_arn}.</summary>
        [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CloudwatchLogsRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#field_log_level AppsyncGraphqlApi#field_log_level}.</summary>
        [JsiiProperty(name: "fieldLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string FieldLogLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#exclude_verbose_content AppsyncGraphqlApi#exclude_verbose_content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeVerboseContent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ExcludeVerboseContent
        {
            get;
            set;
        }
    }
}
