using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplatePlacement), fullyQualifiedName: "aws.ec2.LaunchTemplatePlacement")]
    public interface ILaunchTemplatePlacement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#affinity LaunchTemplate#affinity}.</summary>
        [JsiiProperty(name: "affinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Affinity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#availability_zone LaunchTemplate#availability_zone}.</summary>
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#group_name LaunchTemplate#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#host_id LaunchTemplate#host_id}.</summary>
        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#partition_number LaunchTemplate#partition_number}.</summary>
        [JsiiProperty(name: "partitionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PartitionNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#spread_domain LaunchTemplate#spread_domain}.</summary>
        [JsiiProperty(name: "spreadDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpreadDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tenancy LaunchTemplate#tenancy}.</summary>
        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tenancy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplatePlacement), fullyQualifiedName: "aws.ec2.LaunchTemplatePlacement")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ILaunchTemplatePlacement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#affinity LaunchTemplate#affinity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "affinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Affinity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#availability_zone LaunchTemplate#availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#group_name LaunchTemplate#group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#host_id LaunchTemplate#host_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#partition_number LaunchTemplate#partition_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partitionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PartitionNumber
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#spread_domain LaunchTemplate#spread_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spreadDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpreadDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#tenancy LaunchTemplate#tenancy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tenancy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
