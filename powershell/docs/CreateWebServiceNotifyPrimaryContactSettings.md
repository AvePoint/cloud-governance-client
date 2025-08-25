# CreateWebServiceNotifyPrimaryContactSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** |  | [optional] [default to $false]
**SeletedItem** | **String** |  | [optional] 
**AllItems** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateWebServiceNotifyPrimaryContactSettings = New-Cloud.Governance.ClientCreateWebServiceNotifyPrimaryContactSettings  -Enabled null `
 -SeletedItem null `
 -AllItems null
```

- Convert the resource to JSON
```powershell
$CreateWebServiceNotifyPrimaryContactSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

