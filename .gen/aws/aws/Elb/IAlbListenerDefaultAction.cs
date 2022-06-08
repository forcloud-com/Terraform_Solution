using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IAlbListenerDefaultAction), fullyQualifiedName: "aws.elb.AlbListenerDefaultAction")]
    public interface IAlbListenerDefaultAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#type AlbListener#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#authenticate_cognito AlbListener#authenticate_cognito}
        /// </remarks>
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionAuthenticateCognito\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerDefaultActionAuthenticateCognito? AuthenticateCognito
        {
            get
            {
                return null;
            }
        }

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#authenticate_oidc AlbListener#authenticate_oidc}
        /// </remarks>
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionAuthenticateOidc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerDefaultActionAuthenticateOidc? AuthenticateOidc
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#fixed_response AlbListener#fixed_response}
        /// </remarks>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionFixedResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerDefaultActionFixedResponse? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#forward AlbListener#forward}
        /// </remarks>
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionForward\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerDefaultActionForward? Forward
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#order AlbListener#order}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#redirect AlbListener#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionRedirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerDefaultActionRedirect? Redirect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#target_group_arn AlbListener#target_group_arn}.</summary>
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerDefaultAction), fullyQualifiedName: "aws.elb.AlbListenerDefaultAction")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbListenerDefaultAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#type AlbListener#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authenticate_cognito block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#authenticate_cognito AlbListener#authenticate_cognito}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionAuthenticateCognito\"}", isOptional: true)]
            public aws.Elb.IAlbListenerDefaultActionAuthenticateCognito? AuthenticateCognito
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionAuthenticateCognito?>();
            }

            /// <summary>authenticate_oidc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#authenticate_oidc AlbListener#authenticate_oidc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionAuthenticateOidc\"}", isOptional: true)]
            public aws.Elb.IAlbListenerDefaultActionAuthenticateOidc? AuthenticateOidc
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionAuthenticateOidc?>();
            }

            /// <summary>fixed_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#fixed_response AlbListener#fixed_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionFixedResponse\"}", isOptional: true)]
            public aws.Elb.IAlbListenerDefaultActionFixedResponse? FixedResponse
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionFixedResponse?>();
            }

            /// <summary>forward block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#forward AlbListener#forward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionForward\"}", isOptional: true)]
            public aws.Elb.IAlbListenerDefaultActionForward? Forward
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionForward?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#order AlbListener#order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#redirect AlbListener#redirect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionRedirect\"}", isOptional: true)]
            public aws.Elb.IAlbListenerDefaultActionRedirect? Redirect
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionRedirect?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#target_group_arn AlbListener#target_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetGroupArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
