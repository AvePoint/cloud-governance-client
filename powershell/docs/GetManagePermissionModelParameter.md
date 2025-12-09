# GetManagePermissionModelParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **String** |  | [optional] 
**NodeType** | [**NodeType**](NodeType.md) |  | [optional] 
**SiteId** | **String** |  | [optional] 
**ExternalSharingOptions** | [**ExternalSharingOptions**](ExternalSharingOptions.md) |  | [optional] 
**ManagePermissionSettingActivityId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GetManagePermissionModelParameter = New-Cloud.Governance.ClientGetManagePermissionModelParameter  -Uri null `
 -NodeType null `
 -SiteId null `
 -ExternalSharingOptions null `
 -ManagePermissionSettingActivityId null
```

- Convert the resource to JSON
```powershell
$GetManagePermissionModelParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

