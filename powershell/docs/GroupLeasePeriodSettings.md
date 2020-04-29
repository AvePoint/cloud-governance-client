# GroupLeasePeriodSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**LeaseType** | [**GroupLeasePeriodType**](GroupLeasePeriodType.md) |  | [optional] [default to null]
**DurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**DurationInterval** | **Int32** |  | [optional] [default to null]
**LeaseExpirationDate** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupLeasePeriodSettings  -IsEnabled null `
 -LeaseType null `
 -DurationType null `
 -DurationInterval null `
 -LeaseExpirationDate null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

