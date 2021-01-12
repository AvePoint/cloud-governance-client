# CreateListSPObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentUrl** | **String** |  | [optional] 
**SiteUrl** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateListSPObject = New-Cloud.Governance.ClientCreateListSPObject  -ParentUrl null `
 -SiteUrl null `
 -SiteId null
```

- Convert the resource to JSON
```powershell
$CreateListSPObject | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

