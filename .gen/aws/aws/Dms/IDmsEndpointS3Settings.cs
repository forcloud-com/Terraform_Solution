using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointS3Settings), fullyQualifiedName: "aws.dms.DmsEndpointS3Settings")]
    public interface IDmsEndpointS3Settings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#bucket_folder DmsEndpoint#bucket_folder}.</summary>
        [JsiiProperty(name: "bucketFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketFolder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#bucket_name DmsEndpoint#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#compression_type DmsEndpoint#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#csv_delimiter DmsEndpoint#csv_delimiter}.</summary>
        [JsiiProperty(name: "csvDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CsvDelimiter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#csv_row_delimiter DmsEndpoint#csv_row_delimiter}.</summary>
        [JsiiProperty(name: "csvRowDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CsvRowDelimiter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#external_table_definition DmsEndpoint#external_table_definition}.</summary>
        [JsiiProperty(name: "externalTableDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalTableDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccessRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointS3Settings), fullyQualifiedName: "aws.dms.DmsEndpointS3Settings")]
        internal sealed class _Proxy : DeputyBase, aws.Dms.IDmsEndpointS3Settings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#bucket_folder DmsEndpoint#bucket_folder}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketFolder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#bucket_name DmsEndpoint#bucket_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#compression_type DmsEndpoint#compression_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#csv_delimiter DmsEndpoint#csv_delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "csvDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CsvDelimiter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#csv_row_delimiter DmsEndpoint#csv_row_delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "csvRowDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CsvRowDelimiter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#external_table_definition DmsEndpoint#external_table_definition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalTableDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalTableDefinition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccessRoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
