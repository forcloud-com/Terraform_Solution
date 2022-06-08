using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.LbListenerDefaultAction")]
    public class LbListenerDefaultAction : aws.Elb.ILbListenerDefaultAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#type LbListener#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#authenticate_cognito LbListener#authenticate_cognito}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionAuthenticateCognito\"}", isOptional: true)]
        public aws.Elb.ILbListenerDefaultActionAuthenticateCognito? AuthenticateCognito
        {
            get;
            set;
        }

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#authenticate_oidc LbListener#authenticate_oidc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionAuthenticateOidc\"}", isOptional: true)]
        public aws.Elb.ILbListenerDefaultActionAuthenticateOidc? AuthenticateOidc
        {
            get;
            set;
        }

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#fixed_response LbListener#fixed_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionFixedResponse\"}", isOptional: true)]
        public aws.Elb.ILbListenerDefaultActionFixedResponse? FixedResponse
        {
            get;
            set;
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#forward LbListener#forward}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionForward\"}", isOptional: true)]
        public aws.Elb.ILbListenerDefaultActionForward? Forward
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#order LbListener#order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Order
        {
            get;
            set;
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#redirect LbListener#redirect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionRedirect\"}", isOptional: true)]
        public aws.Elb.ILbListenerDefaultActionRedirect? Redirect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#target_group_arn LbListener#target_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetGroupArn
        {
            get;
            set;
        }
    }
}
