# cg-client

JavaScript API client for AvePoint Cloud Governance

## Installation

### For [Node.js](https://nodejs.org/)

#### npm

```shell
npm install cg-client --save
```

### For browser

The library also works in the browser environment via npm and [browserify](http://browserify.org/). After following the above steps with Node.js and installing browserify with `npm install -g browserify`, perform the following (assuming *main.js* is your entry file, that's to say your javascript file where you actually use this library):

```shell
browserify main.js > bundle.js
```

Then include *bundle.js* in the HTML pages.

### Webpack Configuration

Using Webpack you may encounter the following error: "Module not found: Error:
Cannot resolve module", most certainly you should disable AMD loader. Add/merge
the following section to your webpack config:

```javascript
module: {
  rules: [
    {
      parser: {
        amd: false
      }
    }
  ]
}
```

## Getting Started

Please follow the [installation](#installation) instruction and execute the following JS code:

```javascript
var CgClient = require('cg-client');
var defaultClient = CgClient.ApiClient.instance;
defaultClient.basePath = "API BASE URL";

// Configure API key authorization: ClientId
var ClientId = defaultClient.authentications['ClientId'];
ClientId.apiKey = 'clientid';

// Configure API key authorization: ClientSecret
var ClientSecret = defaultClient.authentications['ClientSecret'];
ClientSecret.apiKey = 'clientsecret';

// Configure API key authorization: UserPrincipalName
var UserPrincipalName = defaultClient.authentications['UserPrincipalName'];
UserPrincipalName.apiKey = 'userprincipalname';

var api = new CgClient.EmailsApi()
var type = new CgClient.EmailTemplateType(); // {EmailTemplateType} 
api.getEmailTemplate(type).then(function(data) {
  console.log('API called successfully. Returned data: ' + data);
}, function(error) {
  console.error(error);
});
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

## Documentation for Authorization

To get Client Id and Client Secret, go to Cloud Governance System setting->API Authentication Management(you must be administrator for Cloud Governance), create a authentication profile, after create a profile, copy the clientid and client secret.


### ClientId


- **Type**: API key
- **API key parameter name**: clientId
- **Location**: HTTP header



### ClientSecret


- **Type**: API key
- **API key parameter name**: clientSecret
- **Location**: HTTP header



### UserPrincipalName


- **Type**: API key
- **API key parameter name**: userPrincipalName
- **Location**: HTTP header

