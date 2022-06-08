using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    /// <summary>AWS Config.</summary>
    [JsiiInterface(nativeType: typeof(IConfigConfigurationAggregatorConfig), fullyQualifiedName: "aws.config.ConfigConfigurationAggregatorConfig")]
    public interface IConfigConfigurationAggregatorConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#name ConfigConfigurationAggregator#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>account_aggregation_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#account_aggregation_source ConfigConfigurationAggregator#account_aggregation_source}
        /// </remarks>
        [JsiiProperty(name: "accountAggregationSource", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationAggregatorAccountAggregationSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Config.IConfigConfigurationAggregatorAccountAggregationSource? AccountAggregationSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>organization_aggregation_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#organization_aggregation_source ConfigConfigurationAggregator#organization_aggregation_source}
        /// </remarks>
        [JsiiProperty(name: "organizationAggregationSource", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationAggregatorOrganizationAggregationSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Config.IConfigConfigurationAggregatorOrganizationAggregationSource? OrganizationAggregationSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#tags ConfigConfigurationAggregator#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Config.</summary>
        [JsiiTypeProxy(nativeType: typeof(IConfigConfigurationAggregatorConfig), fullyQualifiedName: "aws.config.ConfigConfigurationAggregatorConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Config.IConfigConfigurationAggregatorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#name ConfigConfigurationAggregator#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>account_aggregation_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#account_aggregation_source ConfigConfigurationAggregator#account_aggregation_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountAggregationSource", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationAggregatorAccountAggregationSource\"}", isOptional: true)]
            public aws.Config.IConfigConfigurationAggregatorAccountAggregationSource? AccountAggregationSource
            {
                get => GetInstanceProperty<aws.Config.IConfigConfigurationAggregatorAccountAggregationSource?>();
            }

            /// <summary>organization_aggregation_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#organization_aggregation_source ConfigConfigurationAggregator#organization_aggregation_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "organizationAggregationSource", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationAggregatorOrganizationAggregationSource\"}", isOptional: true)]
            public aws.Config.IConfigConfigurationAggregatorOrganizationAggregationSource? OrganizationAggregationSource
            {
                get => GetInstanceProperty<aws.Config.IConfigConfigurationAggregatorOrganizationAggregationSource?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator#tags ConfigConfigurationAggregator#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
