using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Organizations
{
    /// <summary>AWS Organizations.</summary>
    [JsiiInterface(nativeType: typeof(IOrganizationsOrganizationConfig), fullyQualifiedName: "aws.organizations.OrganizationsOrganizationConfig")]
    public interface IOrganizationsOrganizationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organization#aws_service_access_principals OrganizationsOrganization#aws_service_access_principals}.</summary>
        [JsiiProperty(name: "awsServiceAccessPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AwsServiceAccessPrincipals
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organization#enabled_policy_types OrganizationsOrganization#enabled_policy_types}.</summary>
        [JsiiProperty(name: "enabledPolicyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EnabledPolicyTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organization#feature_set OrganizationsOrganization#feature_set}.</summary>
        [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FeatureSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Organizations.</summary>
        [JsiiTypeProxy(nativeType: typeof(IOrganizationsOrganizationConfig), fullyQualifiedName: "aws.organizations.OrganizationsOrganizationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Organizations.IOrganizationsOrganizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organization#aws_service_access_principals OrganizationsOrganization#aws_service_access_principals}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsServiceAccessPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AwsServiceAccessPrincipals
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organization#enabled_policy_types OrganizationsOrganization#enabled_policy_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabledPolicyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EnabledPolicyTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organization#feature_set OrganizationsOrganization#feature_set}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FeatureSet
            {
                get => GetInstanceProperty<string?>();
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
