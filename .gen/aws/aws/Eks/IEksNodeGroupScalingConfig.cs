using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupScalingConfig), fullyQualifiedName: "aws.eks.EksNodeGroupScalingConfig")]
    public interface IEksNodeGroupScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#desired_size EksNodeGroup#desired_size}.</summary>
        [JsiiProperty(name: "desiredSize", typeJson: "{\"primitive\":\"number\"}")]
        double DesiredSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#max_size EksNodeGroup#max_size}.</summary>
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        double MaxSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#min_size EksNodeGroup#min_size}.</summary>
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        double MinSize
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupScalingConfig), fullyQualifiedName: "aws.eks.EksNodeGroupScalingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Eks.IEksNodeGroupScalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#desired_size EksNodeGroup#desired_size}.</summary>
            [JsiiProperty(name: "desiredSize", typeJson: "{\"primitive\":\"number\"}")]
            public double DesiredSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#max_size EksNodeGroup#max_size}.</summary>
            [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#min_size EksNodeGroup#min_size}.</summary>
            [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MinSize
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
