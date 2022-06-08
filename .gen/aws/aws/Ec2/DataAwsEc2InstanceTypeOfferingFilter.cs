using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.DataAwsEc2InstanceTypeOfferingFilter")]
    public class DataAwsEc2InstanceTypeOfferingFilter : aws.Ec2.IDataAwsEc2InstanceTypeOfferingFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type_offering#name DataAwsEc2InstanceTypeOffering#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type_offering#values DataAwsEc2InstanceTypeOffering#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
