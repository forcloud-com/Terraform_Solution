using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleAction), fullyQualifiedName: "aws.elb.LbListenerRuleAction")]
    public interface ILbListenerRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#type LbListenerRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#authenticate_cognito LbListenerRule#authenticate_cognito}
        /// </remarks>
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionAuthenticateCognito\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleActionAuthenticateCognito? AuthenticateCognito
        {
            get
            {
                return null;
            }
        }

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#authenticate_oidc LbListenerRule#authenticate_oidc}
        /// </remarks>
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionAuthenticateOidc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleActionAuthenticateOidc? AuthenticateOidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#fixed_response LbListenerRule#fixed_response}
        /// </remarks>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionFixedResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleActionFixedResponse? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#forward LbListenerRule#forward}
        /// </remarks>
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionForward\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleActionForward? Forward
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#order LbListenerRule#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Order
        {
            get
            {
                return null;
            }
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#redirect LbListenerRule#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionRedirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleActionRedirect? Redirect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#target_group_arn LbListenerRule#target_group_arn}.</summary>
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleAction), fullyQualifiedName: "aws.elb.LbListenerRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbListenerRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#type LbListenerRule#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authenticate_cognito block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#authenticate_cognito LbListenerRule#authenticate_cognito}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionAuthenticateCognito\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleActionAuthenticateCognito? AuthenticateCognito
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionAuthenticateCognito?>();
            }

            /// <summary>authenticate_oidc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#authenticate_oidc LbListenerRule#authenticate_oidc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionAuthenticateOidc\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleActionAuthenticateOidc? AuthenticateOidc
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionAuthenticateOidc?>();
            }

            /// <summary>fixed_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#fixed_response LbListenerRule#fixed_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionFixedResponse\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleActionFixedResponse? FixedResponse
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionFixedResponse?>();
            }

            /// <summary>forward block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#forward LbListenerRule#forward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionForward\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleActionForward? Forward
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionForward?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#order LbListenerRule#order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#redirect LbListenerRule#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionRedirect\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleActionRedirect? Redirect
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionRedirect?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#target_group_arn LbListenerRule#target_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetGroupArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
