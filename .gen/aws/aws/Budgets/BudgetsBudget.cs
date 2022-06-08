using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget aws_budgets_budget}.</summary>
    [JsiiClass(nativeType: typeof(aws.Budgets.BudgetsBudget), fullyQualifiedName: "aws.budgets.BudgetsBudget", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.budgets.BudgetsBudgetConfig\"}}]")]
    public class BudgetsBudget : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget aws_budgets_budget} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BudgetsBudget(Constructs.Construct scope, string id, aws.Budgets.IBudgetsBudgetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudget(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudget(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostTypes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgets.BudgetsBudgetCostTypes\"}}]")]
        public virtual void PutCostTypes(aws.Budgets.IBudgetsBudgetCostTypes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Budgets.IBudgetsBudgetCostTypes)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCostFilters")]
        public virtual void ResetCostFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCostTypes")]
        public virtual void ResetCostTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotification")]
        public virtual void ResetNotification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimePeriodEnd")]
        public virtual void ResetTimePeriodEnd()
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
        = GetStaticProperty<string>(typeof(aws.Budgets.BudgetsBudget))!;

        [JsiiProperty(name: "costTypes", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetCostTypesOutputReference\"}")]
        public virtual aws.Budgets.BudgetsBudgetCostTypesOutputReference CostTypes
        {
            get => GetInstanceProperty<aws.Budgets.BudgetsBudgetCostTypesOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "budgetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BudgetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costFiltersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? CostFiltersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costTypesInput", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetCostTypes\"}", isOptional: true)]
        public virtual aws.Budgets.IBudgetsBudgetCostTypes? CostTypesInput
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetCostTypes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitAmountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LimitAmountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LimitUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgets.BudgetsBudgetNotification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NotificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timePeriodEndInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimePeriodEndInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timePeriodStartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimePeriodStartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "budgetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BudgetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "costFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> CostFilters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "limitAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LimitAmount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "limitUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LimitUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgets.BudgetsBudgetNotification\"},\"kind\":\"array\"}}]}}")]
        public virtual object Notification
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timePeriodEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePeriodEnd
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timePeriodStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePeriodStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
