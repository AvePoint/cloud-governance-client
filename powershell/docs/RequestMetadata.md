# RequestMetadata
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** | Id of metadata. | [optional] 
**Name** | **String** | Name of metadata. | [optional] 
**BooleanValue** | **Boolean** | Value of Yes/No metadata. | [optional] [default to $false]
**SingleLineOrMultipleLineValue** | **String** | Value of Single/Multiple line of text metadata. | [optional] 
**UpsOrAzureAdValue** | [**LookupValue**](LookupValue.md) | Value of User Profile or Azure AD metadata. | [optional] 
**TermsValue** | [**TermsValue**](TermsValue.md) | Value of Managed metadata metadata. | [optional] 
**UserValue** | [**ApiUser[]**](ApiUser.md) | Value of Person or Group metadata. | [optional] 
**LinkValue** | [**LinkValue**](LinkValue.md) | Value of Hyperlink metadata. | [optional] 
**ChoiceValue** | **String[]** | Value of Choice metadata. | [optional] 
**LookupListValue** | [**LookupListValue**](LookupListValue.md) | Value of Lookup to SharePoint library/list metadata. | [optional] 
**Type** | [**MetadataFieldType**](MetadataFieldType.md) | Type of metadata. | [optional] [readonly] 
**ValueString** | **String** | Display value of metadata. | [optional] [readonly] 
**Value** | **String** | Value of metadata, you can set this value for all metadata types when calling API  Examples:  Yes/No metadata: &quot;&quot;True&quot;&quot;  User Profile or Azure AD metadata: &quot;&quot;user1@example.com&quot;&quot;  Managed metadata metadata: &quot;&quot;term1;term2&quot;&quot;  Person or Group metadata: &quot;&quot;user1@example.com;user2@example.com&quot;&quot;  Hyperlink metadata: &quot;&quot;linktitle;linkaddress&quot;&quot;  Lookup to SharePoint library/list metadata: &quot;&quot;value&quot;&quot;  Choice metadata: &quot;&quot;choice1;choice2&quot;&quot; | [optional] 
**Action** | [**MetadataActionType**](MetadataActionType.md) | Action of metadata, used in change workspace metadata service. | [optional] 

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

