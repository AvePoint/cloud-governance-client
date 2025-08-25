# ChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MailboxId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo = New-Cloud.Governance.ClientChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo  -MailboxId null `
 -OfficeTenantId null `
 -Name null `
 -Email null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

