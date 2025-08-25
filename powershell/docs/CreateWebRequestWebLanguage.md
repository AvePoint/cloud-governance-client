# CreateWebRequestWebLanguage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] [default to 0]
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateWebRequestWebLanguage = New-Cloud.Governance.ClientCreateWebRequestWebLanguage  -Id null `
 -Name null `
 -Description null
```

- Convert the resource to JSON
```powershell
$CreateWebRequestWebLanguage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

