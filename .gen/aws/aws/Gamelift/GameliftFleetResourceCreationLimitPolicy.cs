using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    [JsiiByValue(fqn: "aws.gamelift.GameliftFleetResourceCreationLimitPolicy")]
    public class GameliftFleetResourceCreationLimitPolicy : aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#new_game_sessions_per_creator GameliftFleet#new_game_sessions_per_creator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "newGameSessionsPerCreator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NewGameSessionsPerCreator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#policy_period_in_minutes GameliftFleet#policy_period_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PolicyPeriodInMinutes
        {
            get;
            set;
        }
    }
}
