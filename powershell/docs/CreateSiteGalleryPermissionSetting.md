# CreateSiteGalleryPermissionSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserPermissions** | [**RequestUserWithPermissions[]**](RequestUserWithPermissions.md) |  | [optional] 
**GroupPermissions** | [**RequestGroupWithPermissions[]**](RequestGroupWithPermissions.md) |  | [optional] 
**EnableSendWelcomeEmail** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSiteGalleryPermissionSetting = New-Cloud.Governance.ClientCreateSiteGalleryPermissionSetting  -UserPermissions null `
 -GroupPermissions null `
 -EnableSendWelcomeEmail null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateSiteGalleryPermissionSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

