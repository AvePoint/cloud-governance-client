# LifecycleActions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSendCancellation** | **Boolean** |  | [optional] [default to $false]
**SendCancellationEmailTemplateId** | **String** |  | [optional] 
**IsNotifyEnabled** | **Boolean** |  | [optional] [default to $false]
**NotifyUsers** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**NotifyEmailTemplateId** | **String** |  | [optional] 
**EntraGroupLifecycleActionType** | [**EntraGroupLifecycleActionType**](EntraGroupLifecycleActionType.md) |  | [optional] 
**ActivityId** | **String** |  | [optional] 
**ActivityType** | **String** |  | [optional] 
**Type** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**RunAfter** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LifecycleActions = New-Cloud.Governance.ClientLifecycleActions  -IsSendCancellation null `
 -SendCancellationEmailTemplateId null `
 -IsNotifyEnabled null `
 -NotifyUsers null `
 -NotifyEmailTemplateId null `
 -EntraGroupLifecycleActionType null `
 -ActivityId null `
 -ActivityType null `
 -Type null `
 -Title null `
 -Description null `
 -RunAfter null
```

- Convert the resource to JSON
```powershell
$LifecycleActions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

