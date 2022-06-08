using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateTagSpecifications")]
    public class LaunchTemplateTagSpecifications : aws.Ec2.ILaunchTemplateTagSpecifications
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#resource_type LaunchTemplate#resource_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tags LaunchTemplate#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }
    }
}
