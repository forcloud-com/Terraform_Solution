using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    /// <summary>AWS Route 53.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsRoute53ResolverRulesConfig), fullyQualifiedName: "aws.route53.DataAwsRoute53ResolverRulesConfig")]
    public interface IDataAwsRoute53ResolverRulesConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rules#owner_id DataAwsRoute53ResolverRules#owner_id}.</summary>
        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OwnerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rules#resolver_endpoint_id DataAwsRoute53ResolverRules#resolver_endpoint_id}.</summary>
        [JsiiProperty(name: "resolverEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResolverEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rules#rule_type DataAwsRoute53ResolverRules#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuleType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rules#share_status DataAwsRoute53ResolverRules#share_status}.</summary>
        [JsiiProperty(name: "shareStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShareStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Route 53.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsRoute53ResolverRulesConfig), fullyQualifiedName: "aws.route53.DataAwsRoute53ResolverRulesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IDataAwsRoute53ResolverRulesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rules#owner_id DataAwsRoute53ResolverRules#owner_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OwnerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rules#resolver_endpoint_id DataAwsRoute53ResolverRules#resolver_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resolverEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResolverEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rules#rule_type DataAwsRoute53ResolverRules#rule_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuleType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rules#share_status DataAwsRoute53ResolverRules#share_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shareStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShareStatus
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
