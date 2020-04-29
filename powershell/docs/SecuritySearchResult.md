# SecuritySearchResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [default to null]
**DisplayName** | **String** |  | [optional] [readonly] [default to null]
**IdentityName** | **String** |  | [optional] [readonly] [default to null]
**ObjectUrl** | **String** |  | [optional] [readonly] [default to null]
**ObjectTitle** | **String** |  | [optional] [readonly] [default to null]
**ObjectType** | **String** |  | [optional] [default to null]
**ObjectTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**AccountType** | **String** |  | [optional] [readonly] [default to null]
**AccountTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**SharePointGroup** | **String** |  | [optional] [readonly] [default to null]
**PermissionLevels** | **String** |  | [optional] [readonly] [default to null]
**Action** | [**ApprovalAction**](ApprovalAction.md) |  | [optional] [default to null]
**AccessType** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSecuritySearchResult  -Id null `
 -DisplayName null `
 -IdentityName null `
 -ObjectUrl null `
 -ObjectTitle null `
 -ObjectType null `
 -ObjectTypeDescription null `
 -AccountType null `
 -AccountTypeDescription null `
 -SharePointGroup null `
 -PermissionLevels null `
 -Action null `
 -AccessType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

