# ChangeSharedMailboxPermissionGallery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangedSharedMailboxInfo** | [**ChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo**](ChangeSharedMailboxPermissionGalleryChangedSharedMailboxInfo.md) |  | [optional] 
**ChangedMembers** | [**ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership**](ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership.md) |  | [optional] 
**ChangedSendAs** | [**ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership**](ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership.md) |  | [optional] 
**ChangedSendOnBehalf** | [**ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership**](ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSharedMailboxPermissionGallery = New-Cloud.Governance.ClientChangeSharedMailboxPermissionGallery  -ChangedSharedMailboxInfo null `
 -ChangedMembers null `
 -ChangedSendAs null `
 -ChangedSendOnBehalf null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$ChangeSharedMailboxPermissionGallery | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

