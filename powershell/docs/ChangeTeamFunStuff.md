# ChangeTeamFunStuff
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowGiphy** | **Boolean** |  | [optional] [default to $false]
**GiphyContentRating** | [**ChangeTemplateGiphyRatingType**](ChangeTemplateGiphyRatingType.md) |  | [optional] 
**AllowStickersAndMemes** | **Boolean** |  | [optional] [default to $false]
**AllowCustomMemes** | **Boolean** |  | [optional] [default to $false]
**OriginalAllowGiphy** | **Boolean** |  | [optional] [default to $false]
**OriginalGiphyContentRating** | [**ChangeTemplateGiphyRatingType**](ChangeTemplateGiphyRatingType.md) |  | [optional] 
**OriginalAllowStickersAndMemes** | **Boolean** |  | [optional] [default to $false]
**OriginalAllowCustomMemes** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeTeamFunStuff = New-Cloud.Governance.ClientChangeTeamFunStuff  -AllowGiphy null `
 -GiphyContentRating null `
 -AllowStickersAndMemes null `
 -AllowCustomMemes null `
 -OriginalAllowGiphy null `
 -OriginalGiphyContentRating null `
 -OriginalAllowStickersAndMemes null `
 -OriginalAllowCustomMemes null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeTeamFunStuff | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

