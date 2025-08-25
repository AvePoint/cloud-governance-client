# InviteMultipleGuestRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **String** |  | [optional] 
**DownloadFileName** | **String** |  | [optional] 
**ResultFileName** | **String** |  | [optional] 
**MonitorId** | **String** |  | [optional] 
**IsGenerateReport** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$InviteMultipleGuestRequestModel = New-Cloud.Governance.ClientInviteMultipleGuestRequestModel  -FileName null `
 -DownloadFileName null `
 -ResultFileName null `
 -MonitorId null `
 -IsGenerateReport null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$InviteMultipleGuestRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

