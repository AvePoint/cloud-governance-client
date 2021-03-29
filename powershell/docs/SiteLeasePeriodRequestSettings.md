# SiteLeasePeriodRequestSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeaseInterval** | **Int32** |  | [optional] [default to 0]
**LeaseDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**LeaseWarningInterval** | **Int32** |  | [optional] [default to 0]
**LeaseWarningDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteLeasePeriodRequestSettings = New-Cloud.Governance.ClientSiteLeasePeriodRequestSettings  -LeaseInterval null `
 -LeaseDurationType null `
 -LeaseWarningInterval null `
 -LeaseWarningDurationType null
```

- Convert the resource to JSON
```powershell
$SiteLeasePeriodRequestSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

