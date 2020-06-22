# Amazon EventBridge - Producer/Consumer Example (.NET Core)

This application example creates 2 type of function in AWS Lambda - Producer and Consumer. And some EventBridge rules to route events to proper consumer.

The example shows ATM transaction event and routing based on location. It also does filtering such that only approved transaction are passed.

```bash
.
├── consumer
│   ├── aws-lambda-tools-defaults.json
│   ├── Consumer.csproj
│   ├── Event.cs
│   ├── Function.cs
│   └── Readme.md
├── producer
│   ├── aws-lambda-tools-defaults.json
│   ├── Function.cs
│   ├── Producer.csproj
│   ├── Readme.md
│   └── SampleEvents.cs
├── LICENSE
├── README.md
└── template.yml
```

## Requirements
- AWS Account
- AWS CLI installed and configured to use AWS Account
- AWS SAM CLI
- [.NET Core 3.1 or later](https://dotnet.microsoft.com/download)

## Instruction
```bash
  $ sam deploy --guided
```
Enter stack name, default region and allow SAM to create roles with required permissions