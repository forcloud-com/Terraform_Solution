using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Organizations
{
    /// <summary>AWS Organizations.</summary>
    [JsiiInterface(nativeType: typeof(IOrganizationsOrganizationalUnitConfig), fullyQualifiedName: "aws.organizations.OrganizationsOrganizationalUnitConfig")]
    public interface IOrganizationsOrganizationalUnitConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organizational_unit#name OrganizationsOrganizationalUnit#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organizational_unit#parent_id OrganizationsOrganizationalUnit#parent_id}.</summary>
        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        string ParentId
        {
            get;
        }

        /// <summary>AWS Organizations.</summary>
        [JsiiTypeProxy(nativeType: typeof(IOrganizationsOrganizationalUnitConfig), fullyQualifiedName: "aws.organizations.OrganizationsOrganizationalUnitConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Organizations.IOrganizationsOrganizationalUnitConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organizational_unit#name OrganizationsOrganizationalUnit#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/organizations_organizational_unit#parent_id OrganizationsOrganizationalUnit#parent_id}.</summary>
            [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
            public string ParentId
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
