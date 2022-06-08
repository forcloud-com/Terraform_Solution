using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    /// <summary>AWS EFS.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsEfsMountTargetConfig), fullyQualifiedName: "aws.efs.DataAwsEfsMountTargetConfig")]
    public interface IDataAwsEfsMountTargetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/efs_mount_target#mount_target_id DataAwsEfsMountTarget#mount_target_id}.</summary>
        [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}")]
        string MountTargetId
        {
            get;
        }

        /// <summary>AWS EFS.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsEfsMountTargetConfig), fullyQualifiedName: "aws.efs.DataAwsEfsMountTargetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Efs.IDataAwsEfsMountTargetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/efs_mount_target#mount_target_id DataAwsEfsMountTarget#mount_target_id}.</summary>
            [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}")]
            public string MountTargetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
