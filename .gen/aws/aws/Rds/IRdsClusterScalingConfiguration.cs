using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    [JsiiInterface(nativeType: typeof(IRdsClusterScalingConfiguration), fullyQualifiedName: "aws.rds.RdsClusterScalingConfiguration")]
    public interface IRdsClusterScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#auto_pause RdsCluster#auto_pause}.</summary>
        [JsiiProperty(name: "autoPause", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoPause
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#max_capacity RdsCluster#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#min_capacity RdsCluster#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#seconds_until_auto_pause RdsCluster#seconds_until_auto_pause}.</summary>
        [JsiiProperty(name: "secondsUntilAutoPause", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SecondsUntilAutoPause
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#timeout_action RdsCluster#timeout_action}.</summary>
        [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeoutAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdsClusterScalingConfiguration), fullyQualifiedName: "aws.rds.RdsClusterScalingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Rds.IRdsClusterScalingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#auto_pause RdsCluster#auto_pause}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoPause", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoPause
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#max_capacity RdsCluster#max_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#min_capacity RdsCluster#min_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#seconds_until_auto_pause RdsCluster#seconds_until_auto_pause}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondsUntilAutoPause", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SecondsUntilAutoPause
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#timeout_action RdsCluster#timeout_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeoutAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
