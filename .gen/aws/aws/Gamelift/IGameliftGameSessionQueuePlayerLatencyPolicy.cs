using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    [JsiiInterface(nativeType: typeof(IGameliftGameSessionQueuePlayerLatencyPolicy), fullyQualifiedName: "aws.gamelift.GameliftGameSessionQueuePlayerLatencyPolicy")]
    public interface IGameliftGameSessionQueuePlayerLatencyPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_game_session_queue#maximum_individual_player_latency_milliseconds GameliftGameSessionQueue#maximum_individual_player_latency_milliseconds}.</summary>
        [JsiiProperty(name: "maximumIndividualPlayerLatencyMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumIndividualPlayerLatencyMilliseconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_game_session_queue#policy_duration_seconds GameliftGameSessionQueue#policy_duration_seconds}.</summary>
        [JsiiProperty(name: "policyDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PolicyDurationSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftGameSessionQueuePlayerLatencyPolicy), fullyQualifiedName: "aws.gamelift.GameliftGameSessionQueuePlayerLatencyPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Gamelift.IGameliftGameSessionQueuePlayerLatencyPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_game_session_queue#maximum_individual_player_latency_milliseconds GameliftGameSessionQueue#maximum_individual_player_latency_milliseconds}.</summary>
            [JsiiProperty(name: "maximumIndividualPlayerLatencyMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumIndividualPlayerLatencyMilliseconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_game_session_queue#policy_duration_seconds GameliftGameSessionQueue#policy_duration_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PolicyDurationSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
