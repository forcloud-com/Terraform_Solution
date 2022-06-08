using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiByValue(fqn: "aws.elb.AlbListenerRuleCondition")]
    public class AlbListenerRuleCondition : aws.Elb.IAlbListenerRuleCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#field AlbListenerRule#field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Field
        {
            get;
            set;
        }

        /// <summary>host_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#host_header AlbListenerRule#host_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionHostHeader\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleConditionHostHeader? HostHeader
        {
            get;
            set;
        }

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#http_header AlbListenerRule#http_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleConditionHttpHeader? HttpHeader
        {
            get;
            set;
        }

        /// <summary>http_request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#http_request_method AlbListenerRule#http_request_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
        {
            get;
            set;
        }

        /// <summary>path_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#path_pattern AlbListenerRule#path_pattern}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionPathPattern\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleConditionPathPattern? PathPattern
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#query_string AlbListenerRule#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueryString
        {
            get;
            set;
        }

        /// <summary>source_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#source_ip AlbListenerRule#source_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionSourceIp\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleConditionSourceIp? SourceIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#values AlbListenerRule#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
