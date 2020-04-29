# RenewProfileRef
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsLastStage** | **Boolean** |  | [optional] [default to null]
**ConfirmMessage** | **String** |  | [optional] [default to null]
**ObjectTitle** | **String** |  | [optional] [default to null]
**EnableContactRenewal** | **Boolean** |  | [optional] [default to null]
**EnablePermissionRenewal** | **Boolean** |  | [optional] [default to null]
**EnableMetadataRenewal** | **Boolean** |  | [optional] [default to null]
**EnableReassign** | **Boolean** |  | [optional] [default to null]
**EnableDeletion** | **Boolean** |  | [optional] [default to null]
**EnableArchival** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRenewProfileRef  -IsLastStage null `
 -ConfirmMessage null `
 -ObjectTitle null `
 -EnableContactRenewal null `
 -EnablePermissionRenewal null `
 -EnableMetadataRenewal null `
 -EnableReassign null `
 -EnableDeletion null `
 -EnableArchival null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

