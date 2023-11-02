# M365GroupLifecycleActions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSendCancellation** | **Boolean** |  | [optional] [default to $false]
**SendCancellationEmailTemplateId** | **String** |  | [optional] 
**IsNotifyEnabled** | **Boolean** |  | [optional] [default to $false]
**NotifyUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**NotifyEmailTemplateId** | **String** |  | [optional] 
**ActivityType** | **String** |  | [optional] 
**Type** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**RunAfter** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$M365GroupLifecycleActions = New-Cloud.Governance.ClientM365GroupLifecycleActions  -IsSendCancellation null `
 -SendCancellationEmailTemplateId null `
 -IsNotifyEnabled null `
 -NotifyUsers null `
 -NotifyEmailTemplateId null `
 -ActivityType null `
 -Type null `
 -Title null `
 -Description null `
 -RunAfter null
```

- Convert the resource to JSON
```powershell
$M365GroupLifecycleActions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

