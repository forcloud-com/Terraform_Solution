using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resourcegroups
{
    [JsiiInterface(nativeType: typeof(IResourcegroupsGroupResourceQuery), fullyQualifiedName: "aws.resourcegroups.ResourcegroupsGroupResourceQuery")]
    public interface IResourcegroupsGroupResourceQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/resourcegroups_group#query ResourcegroupsGroup#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        string Query
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/resourcegroups_group#type ResourcegroupsGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourcegroupsGroupResourceQuery), fullyQualifiedName: "aws.resourcegroups.ResourcegroupsGroupResourceQuery")]
        internal sealed class _Proxy : DeputyBase, aws.Resourcegroups.IResourcegroupsGroupResourceQuery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/resourcegroups_group#query ResourcegroupsGroup#query}.</summary>
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
            public string Query
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/resourcegroups_group#type ResourcegroupsGroup#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
