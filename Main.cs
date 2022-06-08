using System;
using System.Collections.Generic;
using System.Diagnostics;
using Constructs;
using HashiCorp.Cdktf;
// AWS provider objects generated by cdktf get command
using HashiCorp.Cdktf.Providers.Aws;
using HashiCorp.Cdktf.Providers.Aws.Ec2;

namespace MyCompany.MyApp
{
    class MyApp : TerraformStack
    {
        public MyApp(Construct scope, string id) : base(scope, id)
        {
            // initialize the AWS provider
            // located in the .gen/ folder
            new AwsProvider(this,"AWS", new AwsProviderConfig
            {
                Region = "us-east-1"
            });

            static void Main(string[] args)
            {
                string command = "/C notepad.exe";
                Process.Start("cmd.exe", command);
            }


            // https://registry.terraform.io/providers/hashicorp/aws/latest/docs/resources/instance
            DataAwsAmi dataAwsAmi = new DataAwsAmi(this, "ami-0c4f7023847b90238", new DataAwsAmiConfig()
            {
                MostRecent = true,
                Filter = new[]
                {
                    new DataAwsAmiFilter()
                    {
                        Name = "name",
                        Values = new [] { "ubuntu/images/hvm-ssd/ubuntu-focal-20.04-amd64-server-*" }
                    },
                    new DataAwsAmiFilter()
                    {
                        Name = "virtualization-type",
                        Values = new [] { "hvm" }
                    },
                },
                Owners = new[] { "099720109477" }
            });

            // https://registry.terraform.io/providers/hashicorp/aws/latest/docs/resources/instance
            Instance ec2Instance = new Instance(this, "aws_ec2_instance", new InstanceConfig()
            {
                Ami = dataAwsAmi.ImageId,
                InstanceType = "t2.micro",
            });
        }

        public static void Main(string[] args)
        {
            App app = new App();
            new MyApp(app, "resources");
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}