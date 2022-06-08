using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    [JsiiByValue(fqn: "aws.budgets.BudgetsBudgetCostTypes")]
    public class BudgetsBudgetCostTypes : aws.Budgets.IBudgetsBudgetCostTypes
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#include_credit BudgetsBudget#include_credit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeCredit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeCredit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#include_discount BudgetsBudget#include_discount}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeDiscount", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeDiscount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#include_other_subscription BudgetsBudget#include_other_subscription}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeOtherSubscription", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeOtherSubscription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#include_recurring BudgetsBudget#include_recurring}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeRecurring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeRecurring
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#include_refund BudgetsBudget#include_refund}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeRefund", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeRefund
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#include_subscription BudgetsBudget#include_subscription}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeSubscription", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeSubscription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#include_support BudgetsBudget#include_support}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeSupport
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#include_tax BudgetsBudget#include_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeTax", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeTax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#include_upfront BudgetsBudget#include_upfront}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeUpfront", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeUpfront
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#use_amortized BudgetsBudget#use_amortized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useAmortized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseAmortized
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget#use_blended BudgetsBudget#use_blended}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useBlended", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseBlended
        {
            get;
            set;
        }
    }
}
