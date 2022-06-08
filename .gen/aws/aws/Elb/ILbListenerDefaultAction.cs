using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbListenerDefaultAction), fullyQualifiedName: "aws.elb.LbListenerDefaultAction")]
    public interface ILbListenerDefaultAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#type LbListener#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#authenticate_cognito LbListener#authenticate_cognito}
        /// </remarks>
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionAuthenticateCognito\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerDefaultActionAuthenticateCognito? AuthenticateCognito
        {
            get
            {
                return null;
            }
        }

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#authenticate_oidc LbListener#authenticate_oidc}
        /// </remarks>
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionAuthenticateOidc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerDefaultActionAuthenticateOidc? AuthenticateOidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#fixed_response LbListener#fixed_response}
        /// </remarks>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionFixedResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerDefaultActionFixedResponse? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#forward LbListener#forward}
        /// </remarks>
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionForward\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerDefaultActionForward? Forward
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#order LbListener#order}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#redirect LbListener#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionRedirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerDefaultActionRedirect? Redirect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#target_group_arn LbListener#target_group_arn}.</summary>
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerDefaultAction), fullyQualifiedName: "aws.elb.LbListenerDefaultAction")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbListenerDefaultAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#type LbListener#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authenticate_cognito block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#authenticate_cognito LbListener#authenticate_cognito}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionAuthenticateCognito\"}", isOptional: true)]
            public aws.Elb.ILbListenerDefaultActionAuthenticateCognito? AuthenticateCognito
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionAuthenticateCognito?>();
            }

            /// <summary>authenticate_oidc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#authenticate_oidc LbListener#authenticate_oidc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionAuthenticateOidc\"}", isOptional: true)]
            public aws.Elb.ILbListenerDefaultActionAuthenticateOidc? AuthenticateOidc
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionAuthenticateOidc?>();
            }

            /// <summary>fixed_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#fixed_response LbListener#fixed_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionFixedResponse\"}", isOptional: true)]
            public aws.Elb.ILbListenerDefaultActionFixedResponse? FixedResponse
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionFixedResponse?>();
            }

            /// <summary>forward block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#forward LbListener#forward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionForward\"}", isOptional: true)]
            public aws.Elb.ILbListenerDefaultActionForward? Forward
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionForward?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#order LbListener#order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#redirect LbListener#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionRedirect\"}", isOptional: true)]
            public aws.Elb.ILbListenerDefaultActionRedirect? Redirect
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionRedirect?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#target_group_arn LbListener#target_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetGroupArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
