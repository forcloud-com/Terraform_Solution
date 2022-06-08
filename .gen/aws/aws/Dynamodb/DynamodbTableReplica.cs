using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodb.DynamodbTableReplica")]
    public class DynamodbTableReplica : aws.Dynamodb.IDynamodbTableReplica
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_table#region_name DynamodbTable#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        public string RegionName
        {
            get;
            set;
        }
    }
}
