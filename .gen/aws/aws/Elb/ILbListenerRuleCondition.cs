using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleCondition), fullyQualifiedName: "aws.elb.LbListenerRuleCondition")]
    public interface ILbListenerRuleCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#field LbListenerRule#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Field
        {
            get
            {
                return null;
            }
        }

        /// <summary>host_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#host_header LbListenerRule#host_header}
        /// </remarks>
        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionHostHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleConditionHostHeader? HostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#http_header LbListenerRule#http_header}
        /// </remarks>
        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleConditionHttpHeader? HttpHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#http_request_method LbListenerRule#http_request_method}
        /// </remarks>
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#path_pattern LbListenerRule#path_pattern}
        /// </remarks>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionPathPattern\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleConditionPathPattern? PathPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#query_string LbListenerRule#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#source_ip LbListenerRule#source_ip}
        /// </remarks>
        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionSourceIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleConditionSourceIp? SourceIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#values LbListenerRule#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Values
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleCondition), fullyQualifiedName: "aws.elb.LbListenerRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbListenerRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#field LbListenerRule#field}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Field
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>host_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#host_header LbListenerRule#host_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionHostHeader\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleConditionHostHeader? HostHeader
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleConditionHostHeader?>();
            }

            /// <summary>http_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#http_header LbListenerRule#http_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionHttpHeader\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleConditionHttpHeader? HttpHeader
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleConditionHttpHeader?>();
            }

            /// <summary>http_request_method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#http_request_method LbListenerRule#http_request_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleConditionHttpRequestMethod?>();
            }

            /// <summary>path_pattern block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#path_pattern LbListenerRule#path_pattern}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionPathPattern\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleConditionPathPattern? PathPattern
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleConditionPathPattern?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#query_string LbListenerRule#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_ip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#source_ip LbListenerRule#source_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionSourceIp\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleConditionSourceIp? SourceIp
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleConditionSourceIp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#values LbListenerRule#values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Values
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
