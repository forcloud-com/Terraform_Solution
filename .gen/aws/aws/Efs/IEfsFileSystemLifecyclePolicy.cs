using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiInterface(nativeType: typeof(IEfsFileSystemLifecyclePolicy), fullyQualifiedName: "aws.efs.EfsFileSystemLifecyclePolicy")]
    public interface IEfsFileSystemLifecyclePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#transition_to_ia EfsFileSystem#transition_to_ia}.</summary>
        [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}")]
        string TransitionToIa
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsFileSystemLifecyclePolicy), fullyQualifiedName: "aws.efs.EfsFileSystemLifecyclePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Efs.IEfsFileSystemLifecyclePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#transition_to_ia EfsFileSystem#transition_to_ia}.</summary>
            [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitionToIa
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
