# SiteLeasePeriodServiceSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeasePeriodAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**LeaseWarningAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] [default to null]
**LeaseEnabled** | **Boolean** |  | [optional] [default to null]
**LeaseWarningEnabled** | **Boolean** |  | [optional] [default to null]
**ApprovalProcessId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**LeaseInterval** | **Int32** |  | [optional] [default to null]
**LeaseDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]
**LeaseWarningInterval** | **Int32** |  | [optional] [default to null]
**LeaseWarningDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSiteLeasePeriodServiceSettings  -LeasePeriodAssignBy null `
 -LeaseWarningAssignBy null `
 -LeaseEnabled null `
 -LeaseWarningEnabled null `
 -ApprovalProcessId null `
 -LeaseInterval null `
 -LeaseDurationType null `
 -LeaseWarningInterval null `
 -LeaseWarningDurationType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

