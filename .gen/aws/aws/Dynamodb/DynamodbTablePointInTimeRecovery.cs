using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodb.DynamodbTablePointInTimeRecovery")]
    public class DynamodbTablePointInTimeRecovery : aws.Dynamodb.IDynamodbTablePointInTimeRecovery
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#enabled DynamodbTable#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }
    }
}
