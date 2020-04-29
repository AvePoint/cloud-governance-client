# SiteLeasePeriodRequestSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeaseInterval** | **Int32** |  | [optional] [default to null]
**LeaseDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**LeaseWarningInterval** | **Int32** |  | [optional] [default to null]
**LeaseWarningDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteLeasePeriodRequestSettings  -LeaseInterval null `
 -LeaseDurationType null `
 -LeaseWarningInterval null `
 -LeaseWarningDurationType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

