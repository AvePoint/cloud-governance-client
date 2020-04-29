# CustomMetadata
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Type** | [**MetadataFieldType**](MetadataFieldType.md) |  | [optional] [default to null]
**DisplayType** | [**DisplayInReportType**](DisplayInReportType.md) |  | [optional] [default to null]
**AssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**EnableTextValidation** | **Boolean** |  | [optional] [default to null]
**TextValidationRule** | [**TextValidationRuleRef**](TextValidationRuleRef.md) |  | [optional] [default to null]
**BooleanMetadataSettings** | [**BooleanMetadataSettings**](BooleanMetadataSettings.md) |  | [optional] [default to null]
**TermsMetadataSettings** | [**TermsMetadataSettings**](TermsMetadataSettings.md) |  | [optional] [default to null]
**UserMetadataSettings** | [**UserMetadataSettings**](UserMetadataSettings.md) |  | [optional] [default to null]
**UserProfileMetadataSettings** | [**UserProfileMetadataSettings**](UserProfileMetadataSettings.md) |  | [optional] [default to null]
**AzureAdMetadataSettings** | [**AzureAdMetadataSettings**](AzureAdMetadataSettings.md) |  | [optional] [default to null]
**ChoiceMetadataSettings** | [**ChoiceMetadataSettings**](ChoiceMetadataSettings.md) |  | [optional] [default to null]
**LinkMetadataSettings** | [**LinkMetadataSettings**](LinkMetadataSettings.md) |  | [optional] [default to null]
**SingleLineOrMultipleLineMetadataSettings** | [**SingleLineOrMultipleLineMetadataSettings**](SingleLineOrMultipleLineMetadataSettings.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientCustomMetadata  -Id null `
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
 -SingleLineOrMultipleLineMetadataSettings null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

