# RequestMetadata
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [readonly] [default to null]
**BooleanValue** | **Boolean** |  | [optional] [default to null]
**SingleLineOrMultipleLineValue** | **String** |  | [optional] [default to null]
**UpsOrAzureAdValue** | [**LookupValue**](LookupValue.md) |  | [optional] [default to null]
**TermsValue** | [**TermsValue**](TermsValue.md) |  | [optional] [default to null]
**UserValue** | [**ApiUser[]**](ApiUser.md) |  | [optional] [default to null]
**LinkValue** | [**LinkValue**](LinkValue.md) |  | [optional] [default to null]
**ChoiceValue** | **String[]** |  | [optional] [default to null]
**Type** | [**MetadataFieldTypeNullable**](MetadataFieldTypeNullable.md) |  | [optional] [readonly] [default to null]
**ValueString** | **String** |  | [optional] [readonly] [default to null]
**Action** | [**MetadataActionType**](MetadataActionType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRequestMetadata  -Id null `
 -Name null `
 -BooleanValue null `
 -SingleLineOrMultipleLineValue null `
 -UpsOrAzureAdValue null `
 -TermsValue null `
 -UserValue null `
 -LinkValue null `
 -ChoiceValue null `
 -Type null `
 -ValueString null `
 -Action null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

