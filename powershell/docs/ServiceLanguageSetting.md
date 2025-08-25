# ServiceLanguageSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LanguageId** | **Int32** |  | [optional] [default to 0]
**IsEnabled** | **Boolean** |  | [optional] [default to $false]
**Displayname** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ServiceLanguageSetting = New-Cloud.Governance.ClientServiceLanguageSetting  -LanguageId null `
 -IsEnabled null `
 -Displayname null `
 -Description null
```

- Convert the resource to JSON
```powershell
$ServiceLanguageSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

