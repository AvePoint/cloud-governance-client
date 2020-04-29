# ClonePermissionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Urls** | **String[]** |  | [optional] [default to null]
**SourceUser** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**TargetUser** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**CloneOption** | [**ClonePermissionOption**](ClonePermissionOption.md) |  | [optional] [default to null]
**AdditionalCloneOption** | [**ClonePermissionAdditionalOption**](ClonePermissionAdditionalOption.md) |  | [optional] [default to null]
**EnabledRemoveExplicitPermission** | **Boolean** |  | [optional] [default to null]
**EnabledRemoveUserFromSPGroup** | **Boolean** |  | [optional] [default to null]
**EnabledDeleteUserPermission** | **Boolean** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServiceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Department** | **String** |  | [optional] [default to null]
**Summary** | **String** |  | [optional] [default to null]
**NotesToApprovers** | **String** |  | [optional] [default to null]
**QuestionnaireId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
**TicketNumber** | **Int32** |  | [optional] [readonly] [default to null]
**Type** | [**ServiceTypeNullable**](ServiceTypeNullable.md) |  | [optional] [readonly] [default to null]
**TypeDescription** | **String** |  | [optional] [readonly] [default to null]
**Requester** | **String** |  | [optional] [readonly] [default to null]
**Status** | [**RequestStatusNullable**](RequestStatusNullable.md) |  | [optional] [readonly] [default to null]
**ProgressStatus** | **Int32** |  | [optional] [readonly] [default to null]
**ProgressStatusDescription** | **String** |  | [optional] [readonly] [default to null]
**SubmittedTime** | **System.DateTime** |  | [optional] [readonly] [default to null]
**LastUpdated** | **System.DateTime** |  | [optional] [readonly] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [readonly] [default to null]
**AssignTo** | **String** |  | [optional] [readonly] [default to null]
**FullPath** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientClonePermissionRequest  -Urls null `
 -SourceUser null `
 -TargetUser null `
 -CloneOption null `
 -AdditionalCloneOption null `
 -EnabledRemoveExplicitPermission null `
 -EnabledRemoveUserFromSPGroup null `
 -EnabledDeleteUserPermission null `
 -Id null `
 -ServiceId null `
 -Department null `
 -Summary null `
 -NotesToApprovers null `
 -QuestionnaireId null `
 -Metadatas null `
 -TicketNumber null `
 -Type null `
 -TypeDescription null `
 -Requester null `
 -Status null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -SubmittedTime null `
 -LastUpdated null `
 -CreatedTime null `
 -AssignTo null `
 -FullPath null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

