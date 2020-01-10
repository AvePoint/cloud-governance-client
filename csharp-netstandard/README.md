# Cloud.Governance.Client - the C# library for the Cloud Governance Api

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="installation"></a>
## Installation

```
Install-Package Cloud.Governance.Client
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Example
{
    public class GetMyTasksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://API_BASE_URL";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "Your Client Id");
            
            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "Your Client Secret");
            
            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
            

            var apiInstance = new TasksApi(Configuration.Default);
           
            try
            {
                // get my tasks
                TaskListPageResult result = apiInstance.GetMyTasks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetMyTasks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

## Documentation for API Endpoints

- [**EmailsApi**](docs/EmailsApi.md)
- [**MetadataApi**](docs/MetadataApi.md)
- [**Office365Api**](docs/Office365Api.md)
- [**QuestionnairesApi**](docs/QuestionnairesApi.md)
- [**RequestsApi**](docs/RequestsApi.md)
- [**ServicesApi**](docs/ServicesApi.md)
- [**SettingsApi**](docs/SettingsApi.md)
- [**TasksApi**](docs/TasksApi.md)
- [**UsersApi**](docs/UsersApi.md)
- [**WorkspaceApi**](docs/WorkspaceApi.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

To get Client Id and Client Secret, go to Cloud Governance System setting->API Authentication Management(you must be administrator for Cloud Governance), create a authentication profile, after create a profile, copy the clientid and client secret.

<a name="ClientId"></a>
### ClientId

- **Type**: API key
- **API key parameter name**: clientId
- **Location**: HTTP header

<a name="ClientSecret"></a>
### ClientSecret

- **Type**: API key
- **API key parameter name**: clientSecret
- **Location**: HTTP header

<a name="UserPrincipalName"></a>
### UserPrincipalName

- **Type**: API key
- **API key parameter name**: userPrincipalName
- **Location**: HTTP header

