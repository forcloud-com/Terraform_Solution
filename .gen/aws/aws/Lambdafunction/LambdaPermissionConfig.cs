using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    /// <summary>AWS Lambda.</summary>
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaPermissionConfig")]
    public class LambdaPermissionConfig : aws.Lambdafunction.ILambdaPermissionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_permission#action LambdaPermission#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_permission#function_name LambdaPermission#function_name}.</summary>
        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_permission#principal LambdaPermission#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        public string Principal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_permission#event_source_token LambdaPermission#event_source_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventSourceToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventSourceToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_permission#qualifier LambdaPermission#qualifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Qualifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_permission#source_account LambdaPermission#source_account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceAccount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_permission#source_arn LambdaPermission#source_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_permission#statement_id LambdaPermission#statement_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statementId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StatementId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_permission#statement_id_prefix LambdaPermission#statement_id_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statementIdPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StatementIdPrefix
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
