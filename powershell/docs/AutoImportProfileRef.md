# AutoImportProfileRef
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ObjectName** | **String** |  | [optional] [default to null]
**NotesToPrimaryContact** | **String** |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**DefaultSecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**DefaultPolicyId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Departments** | **String[]** |  | [optional] [default to null]
**Policies** | [**PolicyRef[]**](PolicyRef.md) |  | [optional] [default to null]
**LoadDepartmentFromUps** | **Boolean** |  | [optional] [default to null]
**IsLastStep** | **Boolean** |  | [optional] [default to null]
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAutoImportProfileRef  -Id null `
 -ObjectName null `
 -NotesToPrimaryContact null `
 -Name null `
 -Description null `
 -DefaultSecondaryContact null `
 -DefaultPolicyId null `
 -Departments null `
 -Policies null `
 -LoadDepartmentFromUps null `
 -IsLastStep null `
 -Metadatas null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

