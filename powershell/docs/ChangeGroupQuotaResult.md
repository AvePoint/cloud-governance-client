# ChangeGroupQuotaResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedAnySize** | **Boolean** |  | [optional] 
**MinQuotaSize** | **Int64** |  | [optional] 
**MaxQuotaSize** | **Int64** |  | [optional] 
**CurrentQuotaSize** | **Int64** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupQuotaResult = New-Cloud.Governance.ClientChangeGroupQuotaResult  -AllowedAnySize null `
 -MinQuotaSize null `
 -MaxQuotaSize null `
 -CurrentQuotaSize null
```

- Convert the resource to JSON
```powershell
$ChangeGroupQuotaResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

