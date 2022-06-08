using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionFileSystemConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionFileSystemConfig")]
    public interface ILambdaFunctionFileSystemConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#arn LambdaFunction#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#local_mount_path LambdaFunction#local_mount_path}.</summary>
        [JsiiProperty(name: "localMountPath", typeJson: "{\"primitive\":\"string\"}")]
        string LocalMountPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionFileSystemConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaFunctionFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#arn LambdaFunction#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#local_mount_path LambdaFunction#local_mount_path}.</summary>
            [JsiiProperty(name: "localMountPath", typeJson: "{\"primitive\":\"string\"}")]
            public string LocalMountPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
