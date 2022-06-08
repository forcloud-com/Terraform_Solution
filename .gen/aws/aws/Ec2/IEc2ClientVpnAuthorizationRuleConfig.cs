using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(IEc2ClientVpnAuthorizationRuleConfig), fullyQualifiedName: "aws.ec2.Ec2ClientVpnAuthorizationRuleConfig")]
    public interface IEc2ClientVpnAuthorizationRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#client_vpn_endpoint_id Ec2ClientVpnAuthorizationRule#client_vpn_endpoint_id}.</summary>
        [JsiiProperty(name: "clientVpnEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientVpnEndpointId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#target_network_cidr Ec2ClientVpnAuthorizationRule#target_network_cidr}.</summary>
        [JsiiProperty(name: "targetNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        string TargetNetworkCidr
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#access_group_id Ec2ClientVpnAuthorizationRule#access_group_id}.</summary>
        [JsiiProperty(name: "accessGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#authorize_all_groups Ec2ClientVpnAuthorizationRule#authorize_all_groups}.</summary>
        [JsiiProperty(name: "authorizeAllGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthorizeAllGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#description Ec2ClientVpnAuthorizationRule#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEc2ClientVpnAuthorizationRuleConfig), fullyQualifiedName: "aws.ec2.Ec2ClientVpnAuthorizationRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IEc2ClientVpnAuthorizationRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#client_vpn_endpoint_id Ec2ClientVpnAuthorizationRule#client_vpn_endpoint_id}.</summary>
            [JsiiProperty(name: "clientVpnEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientVpnEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#target_network_cidr Ec2ClientVpnAuthorizationRule#target_network_cidr}.</summary>
            [JsiiProperty(name: "targetNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetNetworkCidr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#access_group_id Ec2ClientVpnAuthorizationRule#access_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#authorize_all_groups Ec2ClientVpnAuthorizationRule#authorize_all_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizeAllGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AuthorizeAllGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_client_vpn_authorization_rule#description Ec2ClientVpnAuthorizationRule#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
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
