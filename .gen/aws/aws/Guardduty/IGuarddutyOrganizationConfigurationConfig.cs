using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    /// <summary>AWS GuardDuty.</summary>
    [JsiiInterface(nativeType: typeof(IGuarddutyOrganizationConfigurationConfig), fullyQualifiedName: "aws.guardduty.GuarddutyOrganizationConfigurationConfig")]
    public interface IGuarddutyOrganizationConfigurationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#auto_enable GuarddutyOrganizationConfiguration#auto_enable}.</summary>
        [JsiiProperty(name: "autoEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object AutoEnable
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#detector_id GuarddutyOrganizationConfiguration#detector_id}.</summary>
        [JsiiProperty(name: "detectorId", typeJson: "{\"primitive\":\"string\"}")]
        string DetectorId
        {
            get;
        }

        /// <summary>AWS GuardDuty.</summary>
        [JsiiTypeProxy(nativeType: typeof(IGuarddutyOrganizationConfigurationConfig), fullyQualifiedName: "aws.guardduty.GuarddutyOrganizationConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Guardduty.IGuarddutyOrganizationConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#auto_enable GuarddutyOrganizationConfiguration#auto_enable}.</summary>
            [JsiiProperty(name: "autoEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object AutoEnable
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_organization_configuration#detector_id GuarddutyOrganizationConfiguration#detector_id}.</summary>
            [JsiiProperty(name: "detectorId", typeJson: "{\"primitive\":\"string\"}")]
            public string DetectorId
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
