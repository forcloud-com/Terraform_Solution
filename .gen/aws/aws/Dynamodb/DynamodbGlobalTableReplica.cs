using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodb.DynamodbGlobalTableReplica")]
    public class DynamodbGlobalTableReplica : aws.Dynamodb.IDynamodbGlobalTableReplica
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dynamodb_global_table#region_name DynamodbGlobalTable#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        public string RegionName
        {
            get;
            set;
        }
    }
}
