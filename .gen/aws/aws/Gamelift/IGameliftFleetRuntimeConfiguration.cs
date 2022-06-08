using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    [JsiiInterface(nativeType: typeof(IGameliftFleetRuntimeConfiguration), fullyQualifiedName: "aws.gamelift.GameliftFleetRuntimeConfiguration")]
    public interface IGameliftFleetRuntimeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#game_session_activation_timeout_seconds GameliftFleet#game_session_activation_timeout_seconds}.</summary>
        [JsiiProperty(name: "gameSessionActivationTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GameSessionActivationTimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#max_concurrent_game_session_activations GameliftFleet#max_concurrent_game_session_activations}.</summary>
        [JsiiProperty(name: "maxConcurrentGameSessionActivations", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentGameSessionActivations
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_process block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#server_process GameliftFleet#server_process}
        /// </remarks>
        [JsiiProperty(name: "serverProcess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfigurationServerProcess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServerProcess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetRuntimeConfiguration), fullyQualifiedName: "aws.gamelift.GameliftFleetRuntimeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Gamelift.IGameliftFleetRuntimeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#game_session_activation_timeout_seconds GameliftFleet#game_session_activation_timeout_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gameSessionActivationTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GameSessionActivationTimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#max_concurrent_game_session_activations GameliftFleet#max_concurrent_game_session_activations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentGameSessionActivations", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentGameSessionActivations
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>server_process block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#server_process GameliftFleet#server_process}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverProcess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfigurationServerProcess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServerProcess
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
