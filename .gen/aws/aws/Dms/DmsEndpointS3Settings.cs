using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiByValue(fqn: "aws.dms.DmsEndpointS3Settings")]
    public class DmsEndpointS3Settings : aws.Dms.IDmsEndpointS3Settings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#bucket_folder DmsEndpoint#bucket_folder}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketFolder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketFolder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#bucket_name DmsEndpoint#bucket_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#compression_type DmsEndpoint#compression_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#csv_delimiter DmsEndpoint#csv_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "csvDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CsvDelimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#csv_row_delimiter DmsEndpoint#csv_row_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "csvRowDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CsvRowDelimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#external_table_definition DmsEndpoint#external_table_definition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalTableDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalTableDefinition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccessRoleArn
        {
            get;
            set;
        }
    }
}
