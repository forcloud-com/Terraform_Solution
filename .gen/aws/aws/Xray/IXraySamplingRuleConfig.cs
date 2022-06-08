using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Xray
{
    /// <summary>AWS X-Ray.</summary>
    [JsiiInterface(nativeType: typeof(IXraySamplingRuleConfig), fullyQualifiedName: "aws.xray.XraySamplingRuleConfig")]
    public interface IXraySamplingRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#fixed_rate XraySamplingRule#fixed_rate}.</summary>
        [JsiiProperty(name: "fixedRate", typeJson: "{\"primitive\":\"number\"}")]
        double FixedRate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#host XraySamplingRule#host}.</summary>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        string Host
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#http_method XraySamplingRule#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        string HttpMethod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#priority XraySamplingRule#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#reservoir_size XraySamplingRule#reservoir_size}.</summary>
        [JsiiProperty(name: "reservoirSize", typeJson: "{\"primitive\":\"number\"}")]
        double ReservoirSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#resource_arn XraySamplingRule#resource_arn}.</summary>
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#service_name XraySamplingRule#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#service_type XraySamplingRule#service_type}.</summary>
        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#url_path XraySamplingRule#url_path}.</summary>
        [JsiiProperty(name: "urlPath", typeJson: "{\"primitive\":\"string\"}")]
        string UrlPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#version XraySamplingRule#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        double Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#attributes XraySamplingRule#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#rule_name XraySamplingRule#rule_name}.</summary>
        [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuleName
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS X-Ray.</summary>
        [JsiiTypeProxy(nativeType: typeof(IXraySamplingRuleConfig), fullyQualifiedName: "aws.xray.XraySamplingRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Xray.IXraySamplingRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#fixed_rate XraySamplingRule#fixed_rate}.</summary>
            [JsiiProperty(name: "fixedRate", typeJson: "{\"primitive\":\"number\"}")]
            public double FixedRate
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#host XraySamplingRule#host}.</summary>
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
            public string Host
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#http_method XraySamplingRule#http_method}.</summary>
            [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string HttpMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#priority XraySamplingRule#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#reservoir_size XraySamplingRule#reservoir_size}.</summary>
            [JsiiProperty(name: "reservoirSize", typeJson: "{\"primitive\":\"number\"}")]
            public double ReservoirSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#resource_arn XraySamplingRule#resource_arn}.</summary>
            [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#service_name XraySamplingRule#service_name}.</summary>
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#service_type XraySamplingRule#service_type}.</summary>
            [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#url_path XraySamplingRule#url_path}.</summary>
            [JsiiProperty(name: "urlPath", typeJson: "{\"primitive\":\"string\"}")]
            public string UrlPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#version XraySamplingRule#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
            public double Version
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#attributes XraySamplingRule#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Attributes
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/xray_sampling_rule#rule_name XraySamplingRule#rule_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuleName
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
