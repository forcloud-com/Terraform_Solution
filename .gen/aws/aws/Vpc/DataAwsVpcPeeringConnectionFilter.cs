using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpc.DataAwsVpcPeeringConnectionFilter")]
    public class DataAwsVpcPeeringConnectionFilter : aws.Vpc.IDataAwsVpcPeeringConnectionFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#name DataAwsVpcPeeringConnection#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#values DataAwsVpcPeeringConnection#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
