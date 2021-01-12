# ChangeSiteQuotaSettings
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
$ChangeSiteQuotaSettings = New-Cloud.Governance.ClientChangeSiteQuotaSettings  -AllowedAnySize null `
 -MinQuotaSize null `
 -MaxQuotaSize null `
 -CurrentQuotaSize null
```

- Convert the resource to JSON
```powershell
$ChangeSiteQuotaSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

