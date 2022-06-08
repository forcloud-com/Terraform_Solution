using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointKinesisSettings), fullyQualifiedName: "aws.dms.DmsEndpointKinesisSettings")]
    public interface IDmsEndpointKinesisSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#message_format DmsEndpoint#message_format}.</summary>
        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageFormat
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#stream_arn DmsEndpoint#stream_arn}.</summary>
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointKinesisSettings), fullyQualifiedName: "aws.dms.DmsEndpointKinesisSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Dms.IDmsEndpointKinesisSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#message_format DmsEndpoint#message_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageFormat
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

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#stream_arn DmsEndpoint#stream_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
