using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.LbListenerRuleAction")]
    public class LbListenerRuleAction : aws.Elb.ILbListenerRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#type LbListenerRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#authenticate_cognito LbListenerRule#authenticate_cognito}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionAuthenticateCognito\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleActionAuthenticateCognito? AuthenticateCognito
        {
            get;
            set;
        }

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#authenticate_oidc LbListenerRule#authenticate_oidc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionAuthenticateOidc\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleActionAuthenticateOidc? AuthenticateOidc
        {
            get;
            set;
        }

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#fixed_response LbListenerRule#fixed_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionFixedResponse\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleActionFixedResponse? FixedResponse
        {
            get;
            set;
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#forward LbListenerRule#forward}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionForward\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleActionForward? Forward
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#order LbListenerRule#order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Order
        {
            get;
            set;
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#redirect LbListenerRule#redirect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionRedirect\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleActionRedirect? Redirect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#target_group_arn LbListenerRule#target_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetGroupArn
        {
            get;
            set;
        }
    }
}
