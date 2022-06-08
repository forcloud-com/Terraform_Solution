using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    /// <summary>AWS CloudWatch Event Bridge.</summary>
    [JsiiInterface(nativeType: typeof(ICloudwatchEventPermissionConfig), fullyQualifiedName: "aws.eventbridge.CloudwatchEventPermissionConfig")]
    public interface ICloudwatchEventPermissionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission#principal CloudwatchEventPermission#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        string Principal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission#statement_id CloudwatchEventPermission#statement_id}.</summary>
        [JsiiProperty(name: "statementId", typeJson: "{\"primitive\":\"string\"}")]
        string StatementId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission#action CloudwatchEventPermission#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission#condition CloudwatchEventPermission#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventPermissionCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventPermissionCondition? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CloudWatch Event Bridge.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventPermissionConfig), fullyQualifiedName: "aws.eventbridge.CloudwatchEventPermissionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventPermissionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission#principal CloudwatchEventPermission#principal}.</summary>
            [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
            public string Principal
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission#statement_id CloudwatchEventPermission#statement_id}.</summary>
            [JsiiProperty(name: "statementId", typeJson: "{\"primitive\":\"string\"}")]
            public string StatementId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission#action CloudwatchEventPermission#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission#condition CloudwatchEventPermission#condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventPermissionCondition\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventPermissionCondition? Condition
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventPermissionCondition?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
