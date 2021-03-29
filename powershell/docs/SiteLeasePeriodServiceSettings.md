# SiteLeasePeriodServiceSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeasePeriodAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**LeaseWarningAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**LeaseEnabled** | **Boolean** |  | [optional] [default to $false]
**LeaseWarningEnabled** | **Boolean** |  | [optional] [default to $false]
**ApprovalProcessId** | **String** |  | [optional] 
**LeaseInterval** | **Int32** |  | [optional] [default to 0]
**LeaseDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 
**LeaseWarningInterval** | **Int32** |  | [optional] [default to 0]
**LeaseWarningDurationType** | [**ApiDurationType**](ApiDurationType.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteLeasePeriodServiceSettings = New-Cloud.Governance.ClientSiteLeasePeriodServiceSettings  -LeasePeriodAssignBy null `
 -LeaseWarningAssignBy null `
 -LeaseEnabled null `
 -LeaseWarningEnabled null `
 -ApprovalProcessId null `
 -LeaseInterval null `
 -LeaseDurationType null `
 -LeaseWarningInterval null `
 -LeaseWarningDurationType null
```

- Convert the resource to JSON
```powershell
$SiteLeasePeriodServiceSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

