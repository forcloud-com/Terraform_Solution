using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudformation
{
    [JsiiByValue(fqn: "aws.cloudformation.CloudformationStackSetTimeouts")]
    public class CloudformationStackSetTimeouts : aws.Cloudformation.ICloudformationStackSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack_set#update CloudformationStackSet#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
