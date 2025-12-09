# FunStuffSettingResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowGiphy** | **Boolean** |  | [optional] [default to $false]
**GiphyContentRating** | [**ChangeTemplateGiphyRatingType**](ChangeTemplateGiphyRatingType.md) |  | [optional] 
**AllowStickersAndMemes** | **Boolean** |  | [optional] [default to $false]
**AllowCustomMemes** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$FunStuffSettingResult = New-Cloud.Governance.ClientFunStuffSettingResult  -AllowGiphy null `
 -GiphyContentRating null `
 -AllowStickersAndMemes null `
 -AllowCustomMemes null
```

- Convert the resource to JSON
```powershell
$FunStuffSettingResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

