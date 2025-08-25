# ChangeExchangeResourceMembershipGalleryRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangedGroupInfo** | [**ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupInfo**](ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupInfo.md) |  | [optional] 
**ChangedGroupOwnership** | [**ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership**](ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership.md) |  | [optional] 
**ChangedGroupMembership** | [**ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership**](ChangeExchangeResourceMembershipGalleryRequestModelChangedGroupOwnership.md) |  | [optional] 
**PredefinedOwnerOrMembers** | [**ChangeExchangeResourceMembershipGalleryRequestModelPredefinedOwnerOrMembers**](ChangeExchangeResourceMembershipGalleryRequestModelPredefinedOwnerOrMembers.md) |  | [optional] 
**GalleryType** | **String** |  | [optional] 
**GalleryInternalName** | **String** |  | [optional] 
**GalleryMetadata** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**IsTenantAllowGuest** | **Boolean** |  | [optional] [default to $false]
**RequestSensitivityLabel** | [**ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel**](ChangeExchangeResourceMembershipGalleryRequestModelRequestSensitivityLabel.md) |  | [optional] 

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
 -RequestSensitivityLabel null
```

- Convert the resource to JSON
```powershell
$ChangeExchangeResourceMembershipGalleryRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

