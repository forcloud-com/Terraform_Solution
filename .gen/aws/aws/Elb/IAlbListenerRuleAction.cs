using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleAction), fullyQualifiedName: "aws.elb.AlbListenerRuleAction")]
    public interface IAlbListenerRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#type AlbListenerRule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#authenticate_cognito AlbListenerRule#authenticate_cognito}
        /// </remarks>
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionAuthenticateCognito\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleActionAuthenticateCognito? AuthenticateCognito
        {
            get
            {
                return null;
            }
        }

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#authenticate_oidc AlbListenerRule#authenticate_oidc}
        /// </remarks>
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionAuthenticateOidc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleActionAuthenticateOidc? AuthenticateOidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#fixed_response AlbListenerRule#fixed_response}
        /// </remarks>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionFixedResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleActionFixedResponse? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#forward AlbListenerRule#forward}
        /// </remarks>
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionForward\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleActionForward? Forward
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#order AlbListenerRule#order}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#redirect AlbListenerRule#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionRedirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleActionRedirect? Redirect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#target_group_arn AlbListenerRule#target_group_arn}.</summary>
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleAction), fullyQualifiedName: "aws.elb.AlbListenerRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbListenerRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#type AlbListenerRule#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authenticate_cognito block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#authenticate_cognito AlbListenerRule#authenticate_cognito}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionAuthenticateCognito\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleActionAuthenticateCognito? AuthenticateCognito
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionAuthenticateCognito?>();
            }

            /// <summary>authenticate_oidc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#authenticate_oidc AlbListenerRule#authenticate_oidc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionAuthenticateOidc\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleActionAuthenticateOidc? AuthenticateOidc
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionAuthenticateOidc?>();
            }

            /// <summary>fixed_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#fixed_response AlbListenerRule#fixed_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionFixedResponse\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleActionFixedResponse? FixedResponse
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionFixedResponse?>();
            }

            /// <summary>forward block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#forward AlbListenerRule#forward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionForward\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleActionForward? Forward
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionForward?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#order AlbListenerRule#order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#redirect AlbListenerRule#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionRedirect\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleActionRedirect? Redirect
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionRedirect?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#target_group_arn AlbListenerRule#target_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetGroupArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
