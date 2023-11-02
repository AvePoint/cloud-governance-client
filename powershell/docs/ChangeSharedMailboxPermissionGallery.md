# ChangeSharedMailboxPermissionGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangedSharedMailboxInfo** | [**ChangeSharedMailboxModel**](ChangeSharedMailboxModel.md) |  | [optional] 
**ChangedMembers** | [**ChangedMembership**](ChangedMembership.md) |  | [optional] 
**ChangedSendAs** | [**ChangedMembership**](ChangedMembership.md) |  | [optional] 
**ChangedSendOnBehalf** | [**ChangedMembership**](ChangedMembership.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSharedMailboxPermissionGallery = New-Cloud.Governance.ClientChangeSharedMailboxPermissionGallery  -ChangedSharedMailboxInfo null `
 -ChangedMembers null `
 -ChangedSendAs null `
 -ChangedSendOnBehalf null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null
```

- Convert the resource to JSON
```powershell
$ChangeSharedMailboxPermissionGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

