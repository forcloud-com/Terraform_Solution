using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    [JsiiByValue(fqn: "aws.gamelift.GameliftFleetRuntimeConfiguration")]
    public class GameliftFleetRuntimeConfiguration : aws.Gamelift.IGameliftFleetRuntimeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#game_session_activation_timeout_seconds GameliftFleet#game_session_activation_timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gameSessionActivationTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GameSessionActivationTimeoutSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#max_concurrent_game_session_activations GameliftFleet#max_concurrent_game_session_activations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentGameSessionActivations", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentGameSessionActivations
        {
            get;
            set;
        }

        /// <summary>server_process block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#server_process GameliftFleet#server_process}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverProcess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfigurationServerProcess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServerProcess
        {
            get;
            set;
        }
    }
}
