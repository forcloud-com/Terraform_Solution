using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbSubnetMapping")]
    public class AlbSubnetMapping : aws.Elb.IAlbSubnetMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb#subnet_id Alb#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb#allocation_id Alb#allocation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllocationId
        {
            get;
            set;
        }
    }
}
