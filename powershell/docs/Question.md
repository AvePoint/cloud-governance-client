# Question
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Type** | [**QuestionaireType**](QuestionaireType.md) |  | [optional] [default to null]
**Content** | **String** |  | [optional] [default to null]
**ContentHtml** | **String** |  | [optional] [default to null]
**Values** | **String[]** |  | [optional] [default to null]
**DefaultValue** | **String** |  | [optional] [default to null]
**TermSettings** | [**TermsMetadataSettings**](TermsMetadataSettings.md) |  | [optional] [default to null]
**IsMapToMetadata** | **Boolean** |  | [optional] [default to null]
**ReferenceMetadata** | **String** |  | [optional] [default to null]
**ReferenceMetadataName** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientQuestion  -Id null `
 -Type null `
 -Content null `
 -ContentHtml null `
 -Values null `
 -DefaultValue null `
 -TermSettings null `
 -IsMapToMetadata null `
 -ReferenceMetadata null `
 -ReferenceMetadataName null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

