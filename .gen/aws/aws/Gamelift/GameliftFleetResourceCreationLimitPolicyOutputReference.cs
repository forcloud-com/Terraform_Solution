using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    [JsiiClass(nativeType: typeof(aws.Gamelift.GameliftFleetResourceCreationLimitPolicyOutputReference), fullyQualifiedName: "aws.gamelift.GameliftFleetResourceCreationLimitPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GameliftFleetResourceCreationLimitPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GameliftFleetResourceCreationLimitPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleetResourceCreationLimitPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleetResourceCreationLimitPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetNewGameSessionsPerCreator")]
        public virtual void ResetNewGameSessionsPerCreator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyPeriodInMinutes")]
        public virtual void ResetPolicyPeriodInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "newGameSessionsPerCreatorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NewGameSessionsPerCreatorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyPeriodInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PolicyPeriodInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "newGameSessionsPerCreator", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NewGameSessionsPerCreator
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PolicyPeriodInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetResourceCreationLimitPolicy\"}", isOptional: true)]
        public virtual aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
