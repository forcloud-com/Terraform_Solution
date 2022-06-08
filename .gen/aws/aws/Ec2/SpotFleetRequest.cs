using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request aws_spot_fleet_request}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.SpotFleetRequest), fullyQualifiedName: "aws.ec2.SpotFleetRequest", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2.SpotFleetRequestConfig\"}}]")]
    public class SpotFleetRequest : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request aws_spot_fleet_request} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SpotFleetRequest(Constructs.Construct scope, string id, aws.Ec2.ISpotFleetRequestConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotFleetRequest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotFleetRequest(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.SpotFleetRequestTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ec2.ISpotFleetRequestTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ISpotFleetRequestTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllocationStrategy")]
        public virtual void ResetAllocationStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcessCapacityTerminationPolicy")]
        public virtual void ResetExcessCapacityTerminationPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFleetType")]
        public virtual void ResetFleetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceInterruptionBehaviour")]
        public virtual void ResetInstanceInterruptionBehaviour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstancePoolsToUseCount")]
        public virtual void ResetInstancePoolsToUseCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchSpecification")]
        public virtual void ResetLaunchSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchTemplateConfig")]
        public virtual void ResetLaunchTemplateConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancers")]
        public virtual void ResetLoadBalancers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplaceUnhealthyInstances")]
        public virtual void ResetReplaceUnhealthyInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotPrice")]
        public virtual void ResetSpotPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetGroupArns")]
        public virtual void ResetTargetGroupArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminateInstancesWithExpiration")]
        public virtual void ResetTerminateInstancesWithExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidFrom")]
        public virtual void ResetValidFrom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidUntil")]
        public virtual void ResetValidUntil()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForFulfillment")]
        public virtual void ResetWaitForFulfillment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Ec2.SpotFleetRequest))!;

        [JsiiProperty(name: "clientToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spotRequestState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotRequestState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestTimeoutsOutputReference\"}")]
        public virtual aws.Ec2.SpotFleetRequestTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ec2.SpotFleetRequestTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllocationStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excessCapacityTerminationPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExcessCapacityTerminationPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamFleetRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IamFleetRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehaviourInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceInterruptionBehaviourInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancePoolsToUseCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstancePoolsToUseCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchSpecificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LaunchSpecificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LaunchTemplateConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LoadBalancersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replaceUnhealthyInstancesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReplaceUnhealthyInstancesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotPriceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpotPriceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TargetGroupArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateInstancesWithExpirationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TerminateInstancesWithExpirationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestTimeouts\"}", isOptional: true)]
        public virtual aws.Ec2.ISpotFleetRequestTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Ec2.ISpotFleetRequestTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validFromInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValidFromInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validUntilInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValidUntilInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForFulfillmentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WaitForFulfillmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllocationStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExcessCapacityTerminationPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamFleetRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamFleetRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInterruptionBehaviour
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instancePoolsToUseCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstancePoolsToUseCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchSpecification\"},\"kind\":\"array\"}}]}}")]
        public virtual object LaunchSpecification
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfig\"},\"kind\":\"array\"}}]}}")]
        public virtual object LaunchTemplateConfig
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LoadBalancers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ReplaceUnhealthyInstances
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotPrice
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetGroupArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TerminateInstancesWithExpiration
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidFrom
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidUntil
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WaitForFulfillment
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
