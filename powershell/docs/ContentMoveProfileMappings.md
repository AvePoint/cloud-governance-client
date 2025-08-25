# ContentMoveProfileMappings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnMapping** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**ContentTypeMapping** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**UserMapping** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 
**LanguageMapping** | [**AzureAdMetadataSettingsOffice365Tenant**](AzureAdMetadataSettingsOffice365Tenant.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ContentMoveProfileMappings = New-Cloud.Governance.ClientContentMoveProfileMappings  -ColumnMapping null `
 -ContentTypeMapping null `
 -UserMapping null `
 -LanguageMapping null
```

- Convert the resource to JSON
```powershell
$ContentMoveProfileMappings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

