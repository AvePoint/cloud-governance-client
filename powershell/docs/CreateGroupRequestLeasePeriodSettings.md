# CreateGroupRequestLeasePeriodSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** | Whether group extend lease is enabled after expiration | [optional] [default to $false]
**LeaseType** | [**GroupLeasePeriodType**](GroupLeasePeriodType.md) | Group lease period extension type | [optional] 
**DurationType** | [**ApiDurationType**](ApiDurationType.md) | Duration type of the group lease period | [optional] 
**DurationInterval** | **Int32** | Group lease period | [optional] [default to 0]
**LeaseExpirationDate** | **System.DateTime** | Group lease expiration date and time | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateGroupRequestLeasePeriodSettings = New-Cloud.Governance.ClientCreateGroupRequestLeasePeriodSettings  -IsEnabled null `
 -LeaseType null `
 -DurationType null `
 -DurationInterval null `
 -LeaseExpirationDate null
```

- Convert the resource to JSON
```powershell
$CreateGroupRequestLeasePeriodSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

