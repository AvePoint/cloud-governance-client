# Cloud.Governance.Client.Model.UserCustomAction
Represents a custom action associated with a Web site, or subsite.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebFullUrl** | **string** | The target subsite or site&#39;s root web url which the user custom actions added to. | 
**Title** | **string** | The display title of the custom action. | [optional] 
**Sequence** | **int** | An implementation-specific value that determines the order of the custom action that appears on the page. | [optional] [default to 0]
**ScriptSrc** | **string** | The URI of a file which contains the ECMAScript to execute on the page. | [optional] 
**ScriptBlock** | **string** | the ECMAScript to be executed when the custom action is performed. | [optional] 
**Name** | **string** | The name of the custom action. | 
**Url** | **string** | The URL, URI, or ECMAScript (JScript, JavaScript) function associated with the action. | [optional] 
**Location** | **string** | The location of the custom action. | 
**Group** | **string** | An implementation-specific value that determines the position of the custom action in the page | [optional] 
**ImageUrl** | **string** | The URL of the image associated with the custom action. | [optional] 
**Description** | **string** | The description of the custom action. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

