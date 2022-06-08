using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiInterface(nativeType: typeof(IBatchComputeEnvironmentComputeResourcesLaunchTemplate), fullyQualifiedName: "aws.batch.BatchComputeEnvironmentComputeResourcesLaunchTemplate")]
    public interface IBatchComputeEnvironmentComputeResourcesLaunchTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#launch_template_id BatchComputeEnvironment#launch_template_id}.</summary>
        [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchTemplateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#launch_template_name BatchComputeEnvironment#launch_template_name}.</summary>
        [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchTemplateName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#version BatchComputeEnvironment#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchComputeEnvironmentComputeResourcesLaunchTemplate), fullyQualifiedName: "aws.batch.BatchComputeEnvironmentComputeResourcesLaunchTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.Batch.IBatchComputeEnvironmentComputeResourcesLaunchTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#launch_template_id BatchComputeEnvironment#launch_template_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchTemplateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#launch_template_name BatchComputeEnvironment#launch_template_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchTemplateName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#version BatchComputeEnvironment#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
