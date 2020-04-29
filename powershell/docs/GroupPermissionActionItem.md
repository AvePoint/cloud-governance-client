# GroupPermissionActionItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**InstanceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Type** | [**RecertificationActionType**](RecertificationActionType.md) |  | [optional] [default to null]
**TaskId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ActionType** | [**PermissionActionType**](PermissionActionType.md) |  | [optional] [default to null]
**DisplayName** | **String** |  | [optional] [default to null]
**IdentityName** | **String** |  | [optional] [default to null]
**PermissionLevel** | **String** |  | [optional] [default to null]
**PermissionIds** | **Int32[]** |  | [optional] [default to null]
**MemberId** | **Int32** |  | [optional] [default to null]
**TitleName** | **String** |  | [optional] [default to null]
**Path** | **String** |  | [optional] [default to null]
**SharePointGroup** | **String** |  | [optional] [default to null]
**ParentId** | **String** |  | [optional] [default to null]
**IdInSharepoint** | **String** |  | [optional] [default to null]
**Level** | **Int32** |  | [optional] [default to null]
**LevelDescription** | **String** |  | [optional] [default to null]
**AccountType** | [**PrincipalType**](PrincipalType.md) |  | [optional] [default to null]
**AccountTypeDescription** | **String** |  | [optional] [default to null]
**AccessType** | [**UserAccessType**](UserAccessType.md) |  | [optional] [default to null]
**AccessTypeDescription** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupPermissionActionItem  -Id null `
 -InstanceId null `
 -Type null `
 -TaskId null `
 -ActionType null `
 -DisplayName null `
 -IdentityName null `
 -PermissionLevel null `
 -PermissionIds null `
 -MemberId null `
 -TitleName null `
 -Path null `
 -SharePointGroup null `
 -ParentId null `
 -IdInSharepoint null `
 -Level null `
 -LevelDescription null `
 -AccountType null `
 -AccountTypeDescription null `
 -AccessType null `
 -AccessTypeDescription null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

