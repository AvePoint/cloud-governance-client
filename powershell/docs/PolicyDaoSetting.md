# PolicyDaoSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPolicyEnforcerEnabled** | **Boolean** |  | [optional] [default to null]
**PolicyEnforcerProfile** | **String** |  | [optional] [default to null]
**IsDpmEnabled** | **Boolean** |  | [optional] [default to null]
**DpmPlan** | **String** |  | [optional] [default to null]
**IsBackupEnabled** | **Boolean** |  | [optional] [default to null]
**IsAuditingEnabled** | **Boolean** |  | [optional] [default to null]
**IsArchiverEnabled** | **Boolean** |  | [optional] [default to null]
**ArchiverProfile** | **String** |  | [optional] [default to null]
**ArchiverProcessId** | [**UUID**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPolicyDaoSetting  -IsPolicyEnforcerEnabled null `
 -PolicyEnforcerProfile null `
 -IsDpmEnabled null `
 -DpmPlan null `
 -IsBackupEnabled null `
 -IsAuditingEnabled null `
 -IsArchiverEnabled null `
 -ArchiverProfile null `
 -ArchiverProcessId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

