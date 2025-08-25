# SharePointListMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListUrl** | **String** |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**PropertyType** | **String** |  | [optional] 
**Property** | **String** |  | [optional] 
**PropertyName** | **String** |  | [optional] 
**IsAdditionalColumnEnabled** | **Boolean** |  | [optional] [default to $false]
**MatchedMetadataId** | **String** |  | [optional] 
**MatchedMetadataName** | **String** |  | [optional] 
**AdditionalColumn** | **String** |  | [optional] 
**AdditionalColumnType** | **String** |  | [optional] 
**AdditionalColumnName** | **String** |  | [optional] 
**Value** | [**SharePointListMetadataSettingsValue**](SharePointListMetadataSettingsValue.md) |  | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$SharePointListMetadataSettings = New-Cloud.Governance.ClientSharePointListMetadataSettings  -ListUrl null `
 -WebUrl null `
 -PropertyType null `
 -Property null `
 -PropertyName null `
 -IsAdditionalColumnEnabled null `
 -MatchedMetadataId null `
 -MatchedMetadataName null `
 -AdditionalColumn null `
 -AdditionalColumnType null `
 -AdditionalColumnName null `
 -Value null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the resource to JSON
```powershell
$SharePointListMetadataSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

