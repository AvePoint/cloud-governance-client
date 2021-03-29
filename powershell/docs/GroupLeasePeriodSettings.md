# GroupLeasePeriodSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to $false]
**LeaseType** | [**GroupLeasePeriodType**](GroupLeasePeriodType.md) |  | [optional] 
**DurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**DurationInterval** | **Int32** |  | [optional] [default to 0]
**LeaseExpirationDate** | **System.DateTime** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GroupLeasePeriodSettings = New-Cloud.Governance.ClientGroupLeasePeriodSettings  -IsEnabled null `
 -LeaseType null `
 -DurationType null `
 -DurationInterval null `
 -LeaseExpirationDate null
```

- Convert the resource to JSON
```powershell
$GroupLeasePeriodSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

