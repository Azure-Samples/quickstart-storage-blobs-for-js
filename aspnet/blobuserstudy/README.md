# Azure Blob Storage SDK Study

Thank you for participating in critical research about the usability of the Azure SDK! This repo contains a template for an ASP.NET application along with instructions to run the template and tasks that will complete the application. As part of the study, the Azure SDK team is reviewing our documentation, SDK design, and user experience. We are not reviewing this study for technical skills or aptitude of our participants. You may be asked for feedback as part of the research process. Do not leave feedback or comments in this repo, as this repo is not actively developed.

## Scenario

Imagine you are a developer at a software company that wants to analyze log data from its mobile application. To analyze the log data, each mobile app will upload logs once a day to a central service written in ASP.NET. This repository is the start of the code for that central service. It is an IIS express application, and it has an endpoint started that accepts a text file. Some test text files are in the `.\logs` folder.

Currently, POST and GET endpoints are prepared in the `Controllers\LogController.cs` file. Refer to [Calling the App](#calling-the-app) to get started.

### Instructions

Complete this application by doing two things:

1. Complete the POST endpoint so that it successfully uploads a log file to blob storage.
2. Complete the GET endpoint so that it returns a list of all uploaded blobs.

## Getting Started

### Prerequisites

To run this scenario, you will need the ASP.NET 5 runtime installed on your local machine. You will also need an Azure Subscription with a storage account.

### Starting the app

To start the app, navigate to the solution directory and run the following commands:

```powershell
dotnet restore
dotnet run
```

### Calling the app

The app listens and responds to web requests on `localhost:3000`. For example, in PowerShell:

to POST a `logs.txt` file:

```powershell
curl http://localhost:3000 -Method POST -Body (Get-Content "..\\logs\\logs01.txt")
```

To GET

```powershell
curl http://localhost:3000 -Method GET
```

## Support

Your recruiter and study scheduler should be able to assist if you need further instructions completing this study; contact them per their instructions. For general inquiries into the Azure SDK, begin by visiting the [Azure SDK repo on GitHub](https://github.com/Azure/azure-sdk).

## Contributing

For details on contributing to this repository, see the [contributing guide](https://github.com/Azure-Samples/quickstart-storage-blobs-for-js/blob/main/CONTRIBUTING.md).

This project welcomes contributions and suggestions. Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, view [Microsoft's CLA](https://cla.microsoft.com).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any other questions or comments.

<!-- ### Community-->
### Reporting security issues and security bugs

Security issues and bugs should be reported privately, via email, to the Microsoft Security Response Center (MSRC) <secure@microsoft.com>. You should receive a response within 24 hours. If for some reason you do not, follow up via email to ensure we received your original message. Further information, including the MSRC PGP key, can be found in the [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue).

### License

This template is licensed under the [MIT](https://github.com/Azure-Samples/quickstart-storage-blobs-for-js/blob/main/LICENSE.md) license.

![Impressions](https://azure-sdk-impressions.azurewebsites.net/api/impressions/quickstart-storage-blobs-for-js%2FREADME.png)