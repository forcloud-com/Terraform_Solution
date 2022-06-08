using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAwsProviderConfig), fullyQualifiedName: "aws.AwsProviderConfig")]
    public interface IAwsProviderConfig
    {
        /// <summary>The region where AWS operations will take place. Examples are us-east-1, us-west-2, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#region AwsProvider#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>The access key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#access_key AwsProvider#access_key}
        /// </remarks>
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#alias AwsProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#allowed_account_ids AwsProvider#allowed_account_ids}.</summary>
        [JsiiProperty(name: "allowedAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAccountIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>assume_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#assume_role AwsProvider#assume_role}
        /// </remarks>
        [JsiiProperty(name: "assumeRole", typeJson: "{\"fqn\":\"aws.AwsProviderAssumeRole\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAwsProviderAssumeRole? AssumeRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>endpoints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#endpoints AwsProvider#endpoints}
        /// </remarks>
        [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Endpoints
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#forbidden_account_ids AwsProvider#forbidden_account_ids}.</summary>
        [JsiiProperty(name: "forbiddenAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ForbiddenAccountIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>ignore_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#ignore_tags AwsProvider#ignore_tags}
        /// </remarks>
        [JsiiProperty(name: "ignoreTags", typeJson: "{\"fqn\":\"aws.AwsProviderIgnoreTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAwsProviderIgnoreTags? IgnoreTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#insecure AwsProvider#insecure}
        /// </remarks>
        [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Insecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of times an AWS API request is being executed.</summary>
        /// <remarks>
        /// If the API request still fails, an error is
        /// thrown.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#max_retries AwsProvider#max_retries}
        /// </remarks>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>The profile for API operations. If not set, the default profile created with `aws configure` will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#profile AwsProvider#profile}
        /// </remarks>
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Profile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set this to true to force the request to use path-style addressing, i.e., http://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will use virtual hosted bucket addressing when possible (http://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#s3_force_path_style AwsProvider#s3_force_path_style}
        /// </remarks>
        [JsiiProperty(name: "s3ForcePathStyle", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3ForcePathStyle
        {
            get
            {
                return null;
            }
        }

        /// <summary>The secret key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#secret_key AwsProvider#secret_key}
        /// </remarks>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the shared credentials file. If not set this defaults to ~/.aws/credentials.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#shared_credentials_file AwsProvider#shared_credentials_file}
        /// </remarks>
        [JsiiProperty(name: "sharedCredentialsFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SharedCredentialsFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_credentials_validation AwsProvider#skip_credentials_validation}
        /// </remarks>
        [JsiiProperty(name: "skipCredentialsValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipCredentialsValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip getting the supported EC2 platforms. Used by users that don't have ec2:DescribeAccountAttributes permissions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_get_ec2_platforms AwsProvider#skip_get_ec2_platforms}
        /// </remarks>
        [JsiiProperty(name: "skipGetEc2Platforms", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipGetEc2Platforms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_metadata_api_check AwsProvider#skip_metadata_api_check}.</summary>
        [JsiiProperty(name: "skipMetadataApiCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipMetadataApiCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip static validation of region name.</summary>
        /// <remarks>
        /// Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_region_validation AwsProvider#skip_region_validation}
        /// </remarks>
        [JsiiProperty(name: "skipRegionValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipRegionValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_requesting_account_id AwsProvider#skip_requesting_account_id}
        /// </remarks>
        [JsiiProperty(name: "skipRequestingAccountId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipRequestingAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>session token. A session token is only required if you are using temporary security credentials.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#token AwsProvider#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAwsProviderConfig), fullyQualifiedName: "aws.AwsProviderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAwsProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The region where AWS operations will take place. Examples are us-east-1, us-west-2, etc.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#region AwsProvider#region}
            /// </remarks>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The access key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#access_key AwsProvider#access_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#alias AwsProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#allowed_account_ids AwsProvider#allowed_account_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAccountIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>assume_role block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#assume_role AwsProvider#assume_role}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assumeRole", typeJson: "{\"fqn\":\"aws.AwsProviderAssumeRole\"}", isOptional: true)]
            public aws.IAwsProviderAssumeRole? AssumeRole
            {
                get => GetInstanceProperty<aws.IAwsProviderAssumeRole?>();
            }

            /// <summary>endpoints block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#endpoints AwsProvider#endpoints}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Endpoints
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#forbidden_account_ids AwsProvider#forbidden_account_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forbiddenAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ForbiddenAccountIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>ignore_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#ignore_tags AwsProvider#ignore_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreTags", typeJson: "{\"fqn\":\"aws.AwsProviderIgnoreTags\"}", isOptional: true)]
            public aws.IAwsProviderIgnoreTags? IgnoreTags
            {
                get => GetInstanceProperty<aws.IAwsProviderIgnoreTags?>();
            }

            /// <summary>Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#insecure AwsProvider#insecure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Insecure
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The maximum number of times an AWS API request is being executed.</summary>
            /// <remarks>
            /// If the API request still fails, an error is
            /// thrown.
            ///
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#max_retries AwsProvider#max_retries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The profile for API operations. If not set, the default profile created with `aws configure` will be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#profile AwsProvider#profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Profile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set this to true to force the request to use path-style addressing, i.e., http://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will use virtual hosted bucket addressing when possible (http://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#s3_force_path_style AwsProvider#s3_force_path_style}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3ForcePathStyle", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? S3ForcePathStyle
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The secret key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#secret_key AwsProvider#secret_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to the shared credentials file. If not set this defaults to ~/.aws/credentials.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#shared_credentials_file AwsProvider#shared_credentials_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sharedCredentialsFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SharedCredentialsFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_credentials_validation AwsProvider#skip_credentials_validation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipCredentialsValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipCredentialsValidation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Skip getting the supported EC2 platforms. Used by users that don't have ec2:DescribeAccountAttributes permissions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_get_ec2_platforms AwsProvider#skip_get_ec2_platforms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipGetEc2Platforms", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipGetEc2Platforms
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_metadata_api_check AwsProvider#skip_metadata_api_check}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipMetadataApiCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipMetadataApiCheck
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Skip static validation of region name.</summary>
            /// <remarks>
            /// Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
            ///
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_region_validation AwsProvider#skip_region_validation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipRegionValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipRegionValidation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#skip_requesting_account_id AwsProvider#skip_requesting_account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipRequestingAccountId", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipRequestingAccountId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>session token. A session token is only required if you are using temporary security credentials.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#token AwsProvider#token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
