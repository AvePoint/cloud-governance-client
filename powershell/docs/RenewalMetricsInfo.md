# RenewalMetricsInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**ObjectName** | **String** |  | [optional] 
**TriggerTime** | **System.DateTime** |  | [optional] 
**SubmittedTime** | **System.DateTime** |  | [optional] 
**CompletedTime** | **System.DateTime** |  | [optional] 
**RemovedOrDemotedOwnerCount** | **Int32** |  | [optional] [default to 0]
**RemovedExternalUserCount** | **Int32** |  | [optional] [default to 0]
**RemovedInternalUserCount** | **Int32** |  | [optional] [default to 0]
**RemovedOrDemotedPrivateChannelOwnerCount** | **Int32** |  | [optional] [default to 0]
**RemovedPrivateChannelMemberCount** | **Int32** |  | [optional] [default to 0]
**RemovedOrDemotedSharedChannelOwnerCount** | **Int32** |  | [optional] [default to 0]
**RemovedSharedChannelMemberCount** | **Int32** |  | [optional] [default to 0]
**RemovedSiteAdminCount** | **Int32** |  | [optional] [default to 0]
**RemovedInternalUserFromOwnersOrFullControlCount** | **Int32** |  | [optional] [default to 0]
**RemovedInternalUserFromSPGroupCount** | **Int32** |  | [optional] [default to 0]
**RemovedExternalUserFromOwnersOrFullControlCount** | **Int32** |  | [optional] [default to 0]
**RemovedExternalUserFromSPGroupCount** | **Int32** |  | [optional] [default to 0]
**RemovedInternalUserFromUniqueDirectAccessCount** | **Int32** |  | [optional] [default to 0]
**RemovedExternalUserFromUniqueDirectAccessCount** | **Int32** |  | [optional] [default to 0]
**RemovedSharingLinkCount** | **Int32** |  | [optional] [default to 0]
**TaskAssigneeSkipCount** | **Int32** |  | [optional] [default to 0]
**TaskAssigneeTriggerRenewalAction** | **String** |  | [optional] 
**IsDeletedByEscalation** | **Boolean** |  | [optional] [default to $false]
**Owners** | **String** |  | [optional] 
**StorageSize** | **Int64** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$RenewalMetricsInfo = New-Cloud.Governance.ClientRenewalMetricsInfo  -ObjectId null `
 -ObjectUrl null `
 -ObjectName null `
 -TriggerTime null `
 -SubmittedTime null `
 -CompletedTime null `
 -RemovedOrDemotedOwnerCount null `
 -RemovedExternalUserCount null `
 -RemovedInternalUserCount null `
 -RemovedOrDemotedPrivateChannelOwnerCount null `
 -RemovedPrivateChannelMemberCount null `
 -RemovedOrDemotedSharedChannelOwnerCount null `
 -RemovedSharedChannelMemberCount null `
 -RemovedSiteAdminCount null `
 -RemovedInternalUserFromOwnersOrFullControlCount null `
 -RemovedInternalUserFromSPGroupCount null `
 -RemovedExternalUserFromOwnersOrFullControlCount null `
 -RemovedExternalUserFromSPGroupCount null `
 -RemovedInternalUserFromUniqueDirectAccessCount null `
 -RemovedExternalUserFromUniqueDirectAccessCount null `
 -RemovedSharingLinkCount null `
 -TaskAssigneeSkipCount null `
 -TaskAssigneeTriggerRenewalAction null `
 -IsDeletedByEscalation null `
 -Owners null `
 -StorageSize null
```

- Convert the resource to JSON
```powershell
$RenewalMetricsInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

