# ChangeGroupTeamPicture
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlobName** | **String** |  | [optional] 
**FileName** | **String** |  | [optional] 
**FileUri** | **String** |  | [optional] 
**ChangePictureOptionType** | [**ChangePictureOptionType**](ChangePictureOptionType.md) |  | [optional] 
**IsDeleteInRequest** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupTeamPicture = New-Cloud.Governance.ClientChangeGroupTeamPicture  -BlobName null `
 -FileName null `
 -FileUri null `
 -ChangePictureOptionType null `
 -IsDeleteInRequest null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeGroupTeamPicture | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

