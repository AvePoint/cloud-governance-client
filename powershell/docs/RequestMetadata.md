# RequestMetadata
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**BooleanValue** | **Boolean** |  | [optional] 
**SingleLineOrMultipleLineValue** | **String** |  | [optional] 
**UpsOrAzureAdValue** | [**LookupValue**](LookupValue.md) |  | [optional] 
**TermsValue** | [**TermsValue**](TermsValue.md) |  | [optional] 
**UserValue** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**LinkValue** | [**LinkValue**](LinkValue.md) |  | [optional] 
**ChoiceValue** | **String[]** |  | [optional] 
**LookupListValue** | [**LookupListValue**](LookupListValue.md) |  | [optional] 
**Type** | [**MetadataFieldType**](MetadataFieldType.md) |  | [optional] [readonly] 
**ValueString** | **String** |  | [optional] [readonly] 
**Value** | **String** |  | [optional] 
**Action** | [**MetadataActionType**](MetadataActionType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RequestMetadata = New-Cloud.Governance.ClientRequestMetadata  -Id null `
 -Name null `
 -BooleanValue null `
 -SingleLineOrMultipleLineValue null `
 -UpsOrAzureAdValue null `
 -TermsValue null `
 -UserValue null `
 -LinkValue null `
 -ChoiceValue null `
 -LookupListValue null `
 -Type null `
 -ValueString null `
 -Value null `
 -Action null
```

- Convert the resource to JSON
```powershell
$RequestMetadata | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

