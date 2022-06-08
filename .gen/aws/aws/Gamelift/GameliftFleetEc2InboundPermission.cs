using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.gamelift.GameliftFleetEc2InboundPermission")]
    public class GameliftFleetEc2InboundPermission : aws.Gamelift.IGameliftFleetEc2InboundPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#from_port GameliftFleet#from_port}.</summary>
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
        public double FromPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#ip_range GameliftFleet#ip_range}.</summary>
        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}")]
        public string IpRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#protocol GameliftFleet#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#to_port GameliftFleet#to_port}.</summary>
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ToPort
        {
            get;
            set;
        }
    }
}
