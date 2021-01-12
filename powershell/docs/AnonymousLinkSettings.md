# AnonymousLinkSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Permisssion** | [**AnnoymouslinkPermissions**](AnnoymouslinkPermissions.md) |  | [optional] 
**ExpirationDate** | **System.DateTime** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AnonymousLinkSettings = New-Cloud.Governance.ClientAnonymousLinkSettings  -Permisssion null `
 -ExpirationDate null
```

- Convert the resource to JSON
```powershell
$AnonymousLinkSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

