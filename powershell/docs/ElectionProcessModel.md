# ElectionProcessModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnablePrimarySiteContact** | **Boolean** |  | [optional] [default to null]
**EnableSecondarySiteContact** | **Boolean** |  | [optional] [default to null]
**EnablePrimarySiteAdministrator** | **Boolean** |  | [optional] [default to null]
**EnableAdministratorGroupUser** | **Boolean** |  | [optional] [default to null]
**AdministratorGroupUserCount** | **Int32** |  | [optional] [default to null]
**EnableMainPermissionUsers** | **Boolean** |  | [optional] [default to null]
**MainPermissionLevel** | [**UUID**](UUID.md) |  | [optional] [default to null]
**MainPermissionUserCount** | **Int32** |  | [optional] [default to null]
**EnableAlternativePermissionUsers** | **Boolean** |  | [optional] [default to null]
**AlternativePermissionLevel** | [**UUID**](UUID.md) |  | [optional] [default to null]
**AlternativPermissionUserCount** | **Int32** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientElectionProcessModel  -EnablePrimarySiteContact null `
 -EnableSecondarySiteContact null `
 -EnablePrimarySiteAdministrator null `
 -EnableAdministratorGroupUser null `
 -AdministratorGroupUserCount null `
 -EnableMainPermissionUsers null `
 -MainPermissionLevel null `
 -MainPermissionUserCount null `
 -EnableAlternativePermissionUsers null `
 -AlternativePermissionLevel null `
 -AlternativPermissionUserCount null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

