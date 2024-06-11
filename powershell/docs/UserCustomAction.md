# UserCustomAction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebFullUrl** | **String** | The target subsite or site&#39;s root web url which the user custom actions added to. | [optional] 
**Title** | **String** | The display title of the custom action. | [optional] 
**Sequence** | **Int32** | An implementation-specific value that determines the order of the custom action that appears on the page. | [optional] [default to 0]
**ScriptSrc** | **String** | The URI of a file which contains the ECMAScript to execute on the page. | [optional] 
**ScriptBlock** | **String** | the ECMAScript to be executed when the custom action is performed. | [optional] 
**Name** | **String** | The name of the custom action. | [optional] 
**Url** | **String** | The URL, URI, or ECMAScript (JScript, JavaScript) function associated with the action. | [optional] 
**Location** | **String** | The location of the custom action. | [optional] 
**Group** | **String** | An implementation-specific value that determines the position of the custom action in the page | [optional] 
**ImageUrl** | **String** | The URL of the image associated with the custom action. | [optional] 
**Description** | **String** | The description of the custom action. | [optional] 

## Examples

- Prepare the resource
```powershell
$UserCustomAction = New-Cloud.Governance.ClientUserCustomAction  -WebFullUrl null `
 -Title null `
 -Sequence null `
 -ScriptSrc null `
 -ScriptBlock null `
 -Name null `
 -Url null `
 -Location null `
 -Group null `
 -ImageUrl null `
 -Description null
```

- Convert the resource to JSON
```powershell
$UserCustomAction | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

