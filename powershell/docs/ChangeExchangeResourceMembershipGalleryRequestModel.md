# ChangeExchangeResourceMembershipGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangedGroupInfo** | [**ChangeExchangeResourceSettingsGroupModel**](ChangeExchangeResourceSettingsGroupModel.md) |  | [optional] 
**ChangedGroupOwnership** | [**ChangedMembership**](ChangedMembership.md) |  | [optional] 
**ChangedGroupMembership** | [**ChangedMembership**](ChangedMembership.md) |  | [optional] 
**PredefinedOwnerOrMembers** | [**PredefinedOwnerOrMembers**](PredefinedOwnerOrMembers.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**RequestSensitivityLabel**](RequestSensitivityLabel.md) |  | [optional] 
**Requester** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeExchangeResourceMembershipGalleryRequestModel = New-Cloud.Governance.ClientChangeExchangeResourceMembershipGalleryRequestModel  -ChangedGroupInfo null `
 -ChangedGroupOwnership null `
 -ChangedGroupMembership null `
 -PredefinedOwnerOrMembers null `
 -GalleryType null `
 -GalleryInternalName null `
 -GalleryMetadata null `
 -IsTenantAllowGuest null `
 -RequestSensitivityLabel null `
 -Requester null
```

- Convert the resource to JSON
```powershell
$ChangeExchangeResourceMembershipGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

