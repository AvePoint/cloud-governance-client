# ChangeGroupQuotaResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedAnySize** | **Boolean** |  | [optional] [default to $false]
**MinQuotaSize** | **Int64** |  | [optional] [default to 0]
**MaxQuotaSize** | **Int64** |  | [optional] [default to 0]
**CurrentQuotaSize** | **Int64** |  | [optional] [default to 0]
**SharePointSiteSize** | **Double** | current uesd quota | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupQuotaResult = New-Cloud.Governance.ClientChangeGroupQuotaResult  -AllowedAnySize null `
 -MinQuotaSize null `
 -MaxQuotaSize null `
 -CurrentQuotaSize null `
 -SharePointSiteSize null
```

- Convert the resource to JSON
```powershell
$ChangeGroupQuotaResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

