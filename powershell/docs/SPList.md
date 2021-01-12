# SPList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Url** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**IsLibrary** | **Boolean** |  | [optional] 
**IsOnQuickLaunch** | **Boolean** |  | [optional] 
**IsEnableModeration** | **Boolean** |  | [optional] 
**IsEnableVersioning** | **Boolean** |  | [optional] 
**IsEnableMinorVersion** | **Boolean** |  | [optional] 
**MajorVersionLimit** | **Int32** |  | [optional] 
**MajorWithMinorVersionsLimit** | **Int32** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SPList = New-Cloud.Governance.ClientSPList  -Id null `
 -Title null `
 -Url null `
 -Description null `
 -IsLibrary null `
 -IsOnQuickLaunch null `
 -IsEnableModeration null `
 -IsEnableVersioning null `
 -IsEnableMinorVersion null `
 -MajorVersionLimit null `
 -MajorWithMinorVersionsLimit null
```

- Convert the resource to JSON
```powershell
$SPList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

