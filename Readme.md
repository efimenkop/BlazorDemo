# Blazor Sample Application

What is [Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.1)

## Local development

### Prerequisites
* Install [Docker desktop](https://www.docker.com/products/docker-desktop)
* Install [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)
* Clone repository
```cmd
git clone https://github.com/efimenkop/BlazorDemo
```
### Running locally
Open `BlazorDemo.sln` in Visual Studio and hit `F5`

*OR*
```cmd
dotnet run
```

### Running tests
In Visual Studio **Test** -> **Run All Tests**

*OR*
```cmd
dotnet run --project BlazorDemo\BlazorDemo.csproj
```


## Deploying to [AWS Fargate](https://aws.amazon.com/fargate/) with [copilot](https://aws.amazon.com/blogs/containers/introducing-aws-copilot/)

The AWS Copilot CLI is a tool for developers to create, release and manage production ready containerized applications on Amazon ECS and AWS Fargate. From getting started, pushing to a test environment and releasing to production, Copilot helps you through the entire life of your app development.

### Prerequisites
* Create AWS account
* Install [AWS CLI](https://aws.amazon.com/cli/)
* Install [AWS copilot]([copilot](https://aws.amazon.com/blogs/containers/introducing-aws-copilot/))\*

\* if you're on **Windows**: download [`copilot-windows-v0.3.0.exe`](https://github.com/aws/copilot-cli/releases/download/v0.3.0/copilot-windows-v0.3.0.exe) and move it to solution folder

**Windows**

```cmd
.\copilot-windows-v0.3.0.exe init --app blazorapp ^
--svc blazor-demo ^
--svc-type 'Load Balanced Web Service' ^
--dockerfile 'Dockerfile' ^
--deploy
```

**Linux**

```sh
copilot init --app blazorapp \
--svc blazor-demo \
--svc-type 'Load Balanced Web Service' \
--dockerfile 'Dockerfile' \
--deploy
```