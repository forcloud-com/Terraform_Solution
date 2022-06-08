using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    /// <summary>AWS Route 53.</summary>
    [JsiiByValue(fqn: "aws.route53.DataAwsRoute53ResolverRuleConfig")]
    public class DataAwsRoute53ResolverRuleConfig : aws.Route53.IDataAwsRoute53ResolverRuleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rule#domain_name DataAwsRoute53ResolverRule#domain_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rule#name DataAwsRoute53ResolverRule#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rule#resolver_endpoint_id DataAwsRoute53ResolverRule#resolver_endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resolverEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResolverEndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rule#resolver_rule_id DataAwsRoute53ResolverRule#resolver_rule_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resolverRuleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResolverRuleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rule#rule_type DataAwsRoute53ResolverRule#rule_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/route53_resolver_rule#tags DataAwsRoute53ResolverRule#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
