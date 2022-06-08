using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplatePlacement")]
    public class LaunchTemplatePlacement : aws.Ec2.ILaunchTemplatePlacement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#affinity LaunchTemplate#affinity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "affinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Affinity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#availability_zone LaunchTemplate#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#group_name LaunchTemplate#group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#host_id LaunchTemplate#host_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#partition_number LaunchTemplate#partition_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partitionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PartitionNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#spread_domain LaunchTemplate#spread_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spreadDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpreadDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tenancy LaunchTemplate#tenancy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tenancy
        {
            get;
            set;
        }
    }
}
