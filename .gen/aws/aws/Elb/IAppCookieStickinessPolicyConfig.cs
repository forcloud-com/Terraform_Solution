using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    /// <summary>AWS Elastic Load Balancer.</summary>
    [JsiiInterface(nativeType: typeof(IAppCookieStickinessPolicyConfig), fullyQualifiedName: "aws.elb.AppCookieStickinessPolicyConfig")]
    public interface IAppCookieStickinessPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/app_cookie_stickiness_policy#cookie_name AppCookieStickinessPolicy#cookie_name}.</summary>
        [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}")]
        string CookieName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/app_cookie_stickiness_policy#lb_port AppCookieStickinessPolicy#lb_port}.</summary>
        [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}")]
        double LbPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/app_cookie_stickiness_policy#load_balancer AppCookieStickinessPolicy#load_balancer}.</summary>
        [JsiiProperty(name: "loadBalancer", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/app_cookie_stickiness_policy#name AppCookieStickinessPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>AWS Elastic Load Balancer.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAppCookieStickinessPolicyConfig), fullyQualifiedName: "aws.elb.AppCookieStickinessPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAppCookieStickinessPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/app_cookie_stickiness_policy#cookie_name AppCookieStickinessPolicy#cookie_name}.</summary>
            [JsiiProperty(name: "cookieName", typeJson: "{\"primitive\":\"string\"}")]
            public string CookieName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/app_cookie_stickiness_policy#lb_port AppCookieStickinessPolicy#lb_port}.</summary>
            [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}")]
            public double LbPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/app_cookie_stickiness_policy#load_balancer AppCookieStickinessPolicy#load_balancer}.</summary>
            [JsiiProperty(name: "loadBalancer", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/app_cookie_stickiness_policy#name AppCookieStickinessPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
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
