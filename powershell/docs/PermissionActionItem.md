# PermissionActionItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] [default to null]
**IdInSharepoint** | **String** |  | [optional] [default to null]
**AccountType** | [**PrincipalType**](PrincipalType.md) |  | [optional] [default to null]
**AccountTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**DisplayName** | **String** |  | [optional] [default to null]
**Level** | **String** |  | [optional] [default to null]
**LevelDescription** | **String** |  | [optional] [default to null]
**MemberOf** | **String** |  | [optional] [default to null]
**Path** | **String** |  | [optional] [default to null]
**PermissionLevel** | **String** |  | [optional] [default to null]
**SharePointGroup** | **String** |  | [optional] [default to null]
**TitleName** | **String** |  | [optional] [default to null]
**UserOrGroup** | **String** |  | [optional] [default to null]
**MemberId** | **Int32** |  | [optional] [default to null]
**ParentId** | **String** |  | [optional] [default to null]
**ParentAccountType** | **Int32** |  | [optional] [default to null]
**ActionType** | [**PermissionActionType**](PermissionActionType.md) |  | [optional] [default to null]
**AccessType** | [**UserAccessType**](UserAccessType.md) |  | [optional] [default to null]
**AccessTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**IsSiteAdministrator** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPermissionActionItem  -Id null `
 -IdInSharepoint null `
 -AccountType null `
 -AccountTypeDescription null `
 -DisplayName null `
 -Level null `
 -LevelDescription null `
 -MemberOf null `
 -Path null `
 -PermissionLevel null `
 -SharePointGroup null `
 -TitleName null `
 -UserOrGroup null `
 -MemberId null `
 -ParentId null `
 -ParentAccountType null `
 -ActionType null `
 -AccessType null `
 -AccessTypeDescription null `
 -IsSiteAdministrator null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

