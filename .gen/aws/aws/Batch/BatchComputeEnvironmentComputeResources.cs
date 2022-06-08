using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batch.BatchComputeEnvironmentComputeResources")]
    public class BatchComputeEnvironmentComputeResources : aws.Batch.IBatchComputeEnvironmentComputeResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#instance_role BatchComputeEnvironment#instance_role}.</summary>
        [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#instance_type BatchComputeEnvironment#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#max_vcpus BatchComputeEnvironment#max_vcpus}.</summary>
        [JsiiProperty(name: "maxVcpus", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxVcpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#min_vcpus BatchComputeEnvironment#min_vcpus}.</summary>
        [JsiiProperty(name: "minVcpus", typeJson: "{\"primitive\":\"number\"}")]
        public double MinVcpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#security_group_ids BatchComputeEnvironment#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#subnets BatchComputeEnvironment#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Subnets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#type BatchComputeEnvironment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#allocation_strategy BatchComputeEnvironment#allocation_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllocationStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#bid_percentage BatchComputeEnvironment#bid_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bidPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BidPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#desired_vcpus BatchComputeEnvironment#desired_vcpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredVcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DesiredVcpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#ec2_key_pair BatchComputeEnvironment#ec2_key_pair}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ec2KeyPair", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ec2KeyPair
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#image_id BatchComputeEnvironment#image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageId
        {
            get;
            set;
        }

        /// <summary>launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#launch_template BatchComputeEnvironment#launch_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResourcesLaunchTemplate\"}", isOptional: true)]
        public aws.Batch.IBatchComputeEnvironmentComputeResourcesLaunchTemplate? LaunchTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#spot_iam_fleet_role BatchComputeEnvironment#spot_iam_fleet_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotIamFleetRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpotIamFleetRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#tags BatchComputeEnvironment#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }
    }
}
