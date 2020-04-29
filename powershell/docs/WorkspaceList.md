# WorkspaceList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] [default to null]
**SiteUrl** | **String** |  | [optional] [default to null]
**GroupEmail** | **String** |  | [optional] [default to null]
**TypeDescription** | **String** |  | [optional] [readonly] [default to null]
**PrimaryContact** | **String** |  | [optional] [default to null]
**PrimaryContactEmail** | **String** |  | [optional] [default to null]
**Phase** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] [default to null]
**PhaseDescription** | **String** |  | [optional] [readonly] [default to null]
**IsCurrentRenewer** | **Boolean** |  | [optional] [default to null]
**CreatedTime** | **System.DateTime** |  | [optional] [default to null]
**Status** | [**SiteStatus**](SiteStatus.md) |  | [optional] [default to null]
**AutoImportProfileId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**PendingAction** | **Int32** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientWorkspaceList  -Id null `
 -Name null `
 -Type null `
 -SiteUrl null `
 -GroupEmail null `
 -TypeDescription null `
 -PrimaryContact null `
 -PrimaryContactEmail null `
 -Phase null `
 -PhaseDescription null `
 -IsCurrentRenewer null `
 -CreatedTime null `
 -Status null `
 -AutoImportProfileId null `
 -PendingAction null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

