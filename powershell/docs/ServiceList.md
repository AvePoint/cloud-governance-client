# ServiceList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Category** | **String** |  | [optional] 
**Contact** | **String** |  | [optional] 
**LanguageId** | **Int32** |  | [optional] [default to 0]
**LanguageSettingIds** | **Int32[]** |  | [optional] 
**Type** | [**ServiceType**](ServiceType.md) |  | [optional] 
**TypeDescription** | **String** |  | [optional] 
**IsQuestionnaire** | **Boolean** |  | [optional] [default to $false]
**QuestionnaireId** | **String** |  | [optional] 
**RankedNumber** | **Int32** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$ServiceList = New-Cloud.Governance.ClientServiceList  -Id null `
 -Name null `
 -Description null `
 -Category null `
 -Contact null `
 -LanguageId null `
 -LanguageSettingIds null `
 -Type null `
 -TypeDescription null `
 -IsQuestionnaire null `
 -QuestionnaireId null `
 -RankedNumber null
```

- Convert the resource to JSON
```powershell
$ServiceList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

