# PermissionChangedActionItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**GroupChanges** | **String** |  | [optional] [default to null]
**PermissionChanges** | **String** |  | [optional] [default to null]
**AccountType** | [**PrincipalType**](PrincipalType.md) |  | [optional] [default to null]
**AccountTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**ActionType** | [**PermissionActionType**](PermissionActionType.md) |  | [optional] [default to null]
**ActionTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**ChangedBy** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**ObjectTitle** | **String** |  | [optional] [default to null]
**ObjectUrl** | **String** |  | [optional] [default to null]
**ObjectType** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPermissionChangedActionItem  -Id null `
 -Name null `
 -GroupChanges null `
 -PermissionChanges null `
 -AccountType null `
 -AccountTypeDescription null `
 -ActionType null `
 -ActionTypeDescription null `
 -ChangedBy null `
 -ObjectTitle null `
 -ObjectUrl null `
 -ObjectType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

