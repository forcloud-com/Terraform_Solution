using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiByValue(fqn: "aws.elb.LbListenerRuleCondition")]
    public class LbListenerRuleCondition : aws.Elb.ILbListenerRuleCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#field LbListenerRule#field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Field
        {
            get;
            set;
        }

        /// <summary>host_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#host_header LbListenerRule#host_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionHostHeader\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleConditionHostHeader? HostHeader
        {
            get;
            set;
        }

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#http_header LbListenerRule#http_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleConditionHttpHeader? HttpHeader
        {
            get;
            set;
        }

        /// <summary>http_request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#http_request_method LbListenerRule#http_request_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
        {
            get;
            set;
        }

        /// <summary>path_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#path_pattern LbListenerRule#path_pattern}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionPathPattern\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleConditionPathPattern? PathPattern
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#query_string LbListenerRule#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueryString
        {
            get;
            set;
        }

        /// <summary>source_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#source_ip LbListenerRule#source_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleConditionSourceIp\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleConditionSourceIp? SourceIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#values LbListenerRule#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
