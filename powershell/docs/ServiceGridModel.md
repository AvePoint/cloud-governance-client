# ServiceGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**Language** | **Int32** |  | [optional] 
**ModifiedTime** | **System.DateTime** |  | [optional] 
**CreatedByDisplayName** | **String** |  | [optional] 
**CreatedBy** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ServiceGridModel = New-Cloud.Governance.ClientServiceGridModel  -Id null `
 -Description null `
 -Name null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -Status null `
 -StatusDescription null `
 -Language null `
 -ModifiedTime null `
 -CreatedByDisplayName null `
 -CreatedBy null
```

- Convert the resource to JSON
```powershell
$ServiceGridModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

