# ChangeWebContactSubRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**AssignTo** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**Reason** | **String** |  | [optional] 
**Status** | **Int32** |  | [optional] [readonly] [default to 0]
**StatusDescription** | **String** |  | [optional] 
**ProgressStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] [readonly] 
**ContactChangeSettings** | [**ChangeWebContactByUrlSetting**](ChangeWebContactByUrlSetting.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeWebContactSubRequest = New-Cloud.Governance.ClientChangeWebContactSubRequest  -Id null `
 -AssignTo null `
 -Reason null `
 -Status null `
 -StatusDescription null `
 -ProgressStatus null `
 -ContactChangeSettings null
```

- Convert the resource to JSON
```powershell
$ChangeWebContactSubRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

