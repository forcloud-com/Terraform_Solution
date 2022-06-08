using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resourcegroups
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resourcegroups.ResourcegroupsGroupResourceQuery")]
    public class ResourcegroupsGroupResourceQuery : aws.Resourcegroups.IResourcegroupsGroupResourceQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/resourcegroups_group#query ResourcegroupsGroup#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public string Query
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/resourcegroups_group#type ResourcegroupsGroup#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
