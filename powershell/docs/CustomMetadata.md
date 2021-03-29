# CustomMetadata
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Type** | [**MetadataFieldType**](MetadataFieldType.md) |  | [optional] 
**DisplayType** | [**DisplayInReportType**](DisplayInReportType.md) |  | [optional] 
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**EnableTextValidation** | **Boolean** |  | [optional] [default to $false]
**TextValidationRule** | [**TextValidationRuleRef**](TextValidationRuleRef.md) |  | [optional] 
**BooleanMetadataSettings** | [**BooleanMetadataSettings**](BooleanMetadataSettings.md) |  | [optional] 
**TermsMetadataSettings** | [**TermsMetadataSettings**](TermsMetadataSettings.md) |  | [optional] 
**UserMetadataSettings** | [**UserMetadataSettings**](UserMetadataSettings.md) |  | [optional] 
**UserProfileMetadataSettings** | [**UserProfileMetadataSettings**](UserProfileMetadataSettings.md) |  | [optional] 
**AzureAdMetadataSettings** | [**AzureAdMetadataSettings**](AzureAdMetadataSettings.md) |  | [optional] 
**ChoiceMetadataSettings** | [**ChoiceMetadataSettings**](ChoiceMetadataSettings.md) |  | [optional] 
**LinkMetadataSettings** | [**LinkMetadataSettings**](LinkMetadataSettings.md) |  | [optional] 
**SingleLineOrMultipleLineMetadataSettings** | [**SingleLineOrMultipleLineMetadataSettings**](SingleLineOrMultipleLineMetadataSettings.md) |  | [optional] 
**SharePointListMetadataSettings** | [**SharePointListMetadataSettings**](SharePointListMetadataSettings.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CustomMetadata = New-Cloud.Governance.ClientCustomMetadata  -Id null `
 -Name null `
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

