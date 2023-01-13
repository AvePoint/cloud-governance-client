# Cloud.Governance.Client.Model.RequestMetadata
Metadata model of request.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Id of metadata. | [optional] 
**Name** | **string** | Name of metadata. | [optional] 
**DisplayName** | **string** |  | [optional] 
**BooleanValue** | **bool?** | Value of Yes/No metadata. | [optional] [default to false]
**SingleLineOrMultipleLineValue** | **string** | Value of Single/Multiple line of text metadata. | [optional] 
**UpsOrAzureAdValue** | [**LookupValue**](LookupValue.md) | Value of User Profile or Azure AD metadata. | [optional] 
**TermsValue** | [**TermsValue**](TermsValue.md) | Value of Managed metadata metadata. | [optional] 
**UserValue** | [**List&lt;ApiUser&gt;**](ApiUser.md) | Value of Person or Group metadata. | [optional] 
**LinkValue** | [**LinkValue**](LinkValue.md) | Value of Hyperlink metadata. | [optional] 
**ChoiceValue** | **List&lt;string&gt;** | Value of Choice metadata. | [optional] 
**LookupListValue** | [**LookupListValue**](LookupListValue.md) | Value of Lookup to SharePoint library/list metadata. | [optional] 
**Type** | **MetadataFieldType** | Type of metadata. | [optional] [readonly] 
**ValueString** | **string** | Display value of metadata. | [optional] [readonly] 
**ValueDisplayString** | **string** | Display value of metadata for show in the page.             The customer maybe depend the valueString to do something, so we need a new property for show in the page             GAO-43948 | [optional] 
**Value** | **string** | Value of metadata, you can set this value for all metadata types when calling API             Examples:             Yes/No metadata: \&quot;True\&quot;             User Profile or Azure AD metadata: \&quot;user1@example.com\&quot;             Managed metadata metadata: \&quot;term1;term2\&quot;             Person or Group metadata: \&quot;user1@example.com;user2@example.com\&quot;             Hyperlink metadata: \&quot;linktitle;linkaddress\&quot;             Lookup to SharePoint library/list metadata: \&quot;value\&quot;             Choice metadata: \&quot;choice1;choice2\&quot; | [optional] 
**Action** | **MetadataActionType** | Action of metadata, used in change workspace metadata service. | [optional] 
**AllowReferenceAsRoleInApprovalProcess** | **bool** | Whether the metadata is allowed to be referenced as a variable role that can be selected in an approval process. | [optional] [default to false]
**ActivityId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

