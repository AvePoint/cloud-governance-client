# ChangeSiteSettingServiceChangeMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to $false]
**EnableAddOrDelete** | **Boolean** |  | [optional] [default to $false]
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSettingServiceChangeMetadataSettings = New-Cloud.Governance.ClientChangeSiteSettingServiceChangeMetadataSettings  -IsEnabled null `
 -EnableAddOrDelete null `
 -Metadatas null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingServiceChangeMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

