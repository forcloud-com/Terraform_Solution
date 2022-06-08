using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    #pragma warning disable CS8618

    /// <summary>AWS Budgets.</summary>
    [JsiiByValue(fqn: "aws.budgets.BudgetsBudgetConfig")]
    public class BudgetsBudgetConfig : aws.Budgets.IBudgetsBudgetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#budget_type BudgetsBudget#budget_type}.</summary>
        [JsiiProperty(name: "budgetType", typeJson: "{\"primitive\":\"string\"}")]
        public string BudgetType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#limit_amount BudgetsBudget#limit_amount}.</summary>
        [JsiiProperty(name: "limitAmount", typeJson: "{\"primitive\":\"string\"}")]
        public string LimitAmount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#limit_unit BudgetsBudget#limit_unit}.</summary>
        [JsiiProperty(name: "limitUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string LimitUnit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#time_period_start BudgetsBudget#time_period_start}.</summary>
        [JsiiProperty(name: "timePeriodStart", typeJson: "{\"primitive\":\"string\"}")]
        public string TimePeriodStart
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#time_unit BudgetsBudget#time_unit}.</summary>
        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeUnit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#account_id BudgetsBudget#account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#cost_filters BudgetsBudget#cost_filters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "costFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? CostFilters
        {
            get;
            set;
        }

        /// <summary>cost_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#cost_types BudgetsBudget#cost_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costTypes", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetCostTypes\"}", isOptional: true)]
        public aws.Budgets.IBudgetsBudgetCostTypes? CostTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#name BudgetsBudget#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#name_prefix BudgetsBudget#name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamePrefix
        {
            get;
            set;
        }

        /// <summary>notification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#notification BudgetsBudget#notification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgets.BudgetsBudgetNotification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Notification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#time_period_end BudgetsBudget#time_period_end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timePeriodEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimePeriodEnd
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
