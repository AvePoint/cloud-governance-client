# AzureADGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ObjectId** | **String** |  | [optional] [default to null]
**TenantId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**GroupName** | **String** |  | [optional] [default to null]
**Email** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Privacy** | **Boolean** |  | [optional] [default to null]
**Subscribe** | **Boolean** |  | [optional] [default to null]
**OutsideSender** | **Boolean** |  | [optional] [default to null]
**Language** | **String** |  | [optional] [default to null]
**Classification** | **String** |  | [optional] [default to null]
**SharePointSiteUrl** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAzureADGroup  -Id null `
 -ObjectId null `
 -TenantId null `
 -GroupName null `
 -Email null `
 -Description null `
 -Privacy null `
 -Subscribe null `
 -OutsideSender null `
 -Language null `
 -Classification null `
 -SharePointSiteUrl null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

