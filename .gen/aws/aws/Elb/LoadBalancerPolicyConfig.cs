using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    /// <summary>AWS Elastic Load Balancer.</summary>
    [JsiiByValue(fqn: "aws.elb.LoadBalancerPolicyConfig")]
    public class LoadBalancerPolicyConfig : aws.Elb.ILoadBalancerPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#load_balancer_name LoadBalancerPolicy#load_balancer_name}.</summary>
        [JsiiProperty(name: "loadBalancerName", typeJson: "{\"primitive\":\"string\"}")]
        public string LoadBalancerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#policy_name LoadBalancerPolicy#policy_name}.</summary>
        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        public string PolicyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#policy_type_name LoadBalancerPolicy#policy_type_name}.</summary>
        [JsiiProperty(name: "policyTypeName", typeJson: "{\"primitive\":\"string\"}")]
        public string PolicyTypeName
        {
            get;
            set;
        }

        /// <summary>policy_attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#policy_attribute LoadBalancerPolicy#policy_attribute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policyAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LoadBalancerPolicyPolicyAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PolicyAttribute
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
