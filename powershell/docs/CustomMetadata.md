# CustomMetadata
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**MetadataFieldType**](MetadataFieldType.md) |  | [optional] 
**DisplayType** | [**DisplayInReportType**](DisplayInReportType.md) |  | [optional] 
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**EnableTextValidation** | **Boolean** |  | [optional] [default to $false]
**TextValidationRule** | [**CreateListUrlSettingsTextValidationRule**](CreateListUrlSettingsTextValidationRule.md) |  | [optional] 
**BooleanMetadataSettings** | [**CustomMetadataBooleanMetadataSettings**](CustomMetadataBooleanMetadataSettings.md) |  | [optional] 
**TermsMetadataSettings** | [**CustomMetadataTermsMetadataSettings**](CustomMetadataTermsMetadataSettings.md) |  | [optional] 
**UserMetadataSettings** | [**CustomMetadataUserMetadataSettings**](CustomMetadataUserMetadataSettings.md) |  | [optional] 
**UserProfileMetadataSettings** | [**CustomMetadataUserProfileMetadataSettings**](CustomMetadataUserProfileMetadataSettings.md) |  | [optional] 
**AzureAdMetadataSettings** | [**CustomMetadataAzureAdMetadataSettings**](CustomMetadataAzureAdMetadataSettings.md) |  | [optional] 
**NonAzureAdMetadataSettings** | [**CustomMetadataNonAzureAdMetadataSettings**](CustomMetadataNonAzureAdMetadataSettings.md) |  | [optional] 
**ChoiceMetadataSettings** | [**CustomMetadataChoiceMetadataSettings**](CustomMetadataChoiceMetadataSettings.md) |  | [optional] 
**LinkMetadataSettings** | [**CustomMetadataLinkMetadataSettings**](CustomMetadataLinkMetadataSettings.md) |  | [optional] 
**SingleLineOrMultipleLineMetadataSettings** | [**CustomMetadataSingleLineOrMultipleLineMetadataSettings**](CustomMetadataSingleLineOrMultipleLineMetadataSettings.md) |  | [optional] 
**SharePointListMetadataSettings** | [**CustomMetadataSharePointListMetadataSettings**](CustomMetadataSharePointListMetadataSettings.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CustomMetadata = New-Cloud.Governance.ClientCustomMetadata  -Id null `
 -Name null `
 -DisplayName null `
 -Description null `
 -Type null `
 -DisplayType null `
 -AssignBy null `
 -EnableTextValidation null `
 -TextValidationRule null `
 -BooleanMetadataSettings null `
 -TermsMetadataSettings null `
 -UserMetadataSettings null `
 -UserProfileMetadataSettings null `
 -AzureAdMetadataSettings null `
 -NonAzureAdMetadataSettings null `
 -ChoiceMetadataSettings null `
 -LinkMetadataSettings null `
 -SingleLineOrMultipleLineMetadataSettings null `
 -SharePointListMetadataSettings null
```

- Convert the resource to JSON
```powershell
$CustomMetadata | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

