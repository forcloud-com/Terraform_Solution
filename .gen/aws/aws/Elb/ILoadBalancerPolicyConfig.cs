using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    /// <summary>AWS Elastic Load Balancer.</summary>
    [JsiiInterface(nativeType: typeof(ILoadBalancerPolicyConfig), fullyQualifiedName: "aws.elb.LoadBalancerPolicyConfig")]
    public interface ILoadBalancerPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#load_balancer_name LoadBalancerPolicy#load_balancer_name}.</summary>
        [JsiiProperty(name: "loadBalancerName", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#policy_name LoadBalancerPolicy#policy_name}.</summary>
        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#policy_type_name LoadBalancerPolicy#policy_type_name}.</summary>
        [JsiiProperty(name: "policyTypeName", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyTypeName
        {
            get;
        }

        /// <summary>policy_attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#policy_attribute LoadBalancerPolicy#policy_attribute}
        /// </remarks>
        [JsiiProperty(name: "policyAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LoadBalancerPolicyPolicyAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PolicyAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Elastic Load Balancer.</summary>
        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPolicyConfig), fullyQualifiedName: "aws.elb.LoadBalancerPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILoadBalancerPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#load_balancer_name LoadBalancerPolicy#load_balancer_name}.</summary>
            [JsiiProperty(name: "loadBalancerName", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#policy_name LoadBalancerPolicy#policy_name}.</summary>
            [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#policy_type_name LoadBalancerPolicy#policy_type_name}.</summary>
            [JsiiProperty(name: "policyTypeName", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyTypeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>policy_attribute block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_policy#policy_attribute LoadBalancerPolicy#policy_attribute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policyAttribute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LoadBalancerPolicyPolicyAttribute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PolicyAttribute
            {
                get => GetInstanceProperty<object?>();
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
