using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiClass(nativeType: typeof(aws.Efs.DataAwsEfsAccessPointRootDirectoryOutputReference), fullyQualifiedName: "aws.efs.DataAwsEfsAccessPointRootDirectoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEfsAccessPointRootDirectoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEfsAccessPointRootDirectoryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEfsAccessPointRootDirectoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEfsAccessPointRootDirectoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "creationInfo", typeJson: "{\"fqn\":\"aws.efs.DataAwsEfsAccessPointRootDirectoryCreationInfoList\"}")]
        public virtual aws.Efs.DataAwsEfsAccessPointRootDirectoryCreationInfoList CreationInfo
        {
            get => GetInstanceProperty<aws.Efs.DataAwsEfsAccessPointRootDirectoryCreationInfoList>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.efs.DataAwsEfsAccessPointRootDirectory\"}", isOptional: true)]
        public virtual aws.Efs.IDataAwsEfsAccessPointRootDirectory? InternalValue
        {
            get => GetInstanceProperty<aws.Efs.IDataAwsEfsAccessPointRootDirectory?>();
            set => SetInstanceProperty(value);
        }
    }
}
