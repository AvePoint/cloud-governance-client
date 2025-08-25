# AzureAdMetadataSettingsOffice365Tenant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** | Object ID | [optional] 
**Name** | **String** | Object name | [optional] 
**Description** | **String** | Object description | [optional] 

## Examples

- Prepare the resource
```powershell
$AzureAdMetadataSettingsOffice365Tenant = New-Cloud.Governance.ClientAzureAdMetadataSettingsOffice365Tenant  -Id null `
 -Name null `
 -Description null
```

- Convert the resource to JSON
```powershell
$AzureAdMetadataSettingsOffice365Tenant | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

