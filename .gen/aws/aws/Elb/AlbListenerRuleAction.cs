using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbListenerRuleAction")]
    public class AlbListenerRuleAction : aws.Elb.IAlbListenerRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#type AlbListenerRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#authenticate_cognito AlbListenerRule#authenticate_cognito}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionAuthenticateCognito\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleActionAuthenticateCognito? AuthenticateCognito
        {
            get;
            set;
        }

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#authenticate_oidc AlbListenerRule#authenticate_oidc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionAuthenticateOidc\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleActionAuthenticateOidc? AuthenticateOidc
        {
            get;
            set;
        }

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#fixed_response AlbListenerRule#fixed_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionFixedResponse\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleActionFixedResponse? FixedResponse
        {
            get;
            set;
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#forward AlbListenerRule#forward}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionForward\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleActionForward? Forward
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#order AlbListenerRule#order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Order
        {
            get;
            set;
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#redirect AlbListenerRule#redirect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionRedirect\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleActionRedirect? Redirect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#target_group_arn AlbListenerRule#target_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetGroupArn
        {
            get;
            set;
        }
    }
}
