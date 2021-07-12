# WorkspaceReport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**Status** | **String** |  | [optional] 
**Type** | **String** |  | [optional] 
**Url** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**PolicyName** | **String** |  | [optional] 
**PrimaryContact** | **String** |  | [optional] 
**PrimaryContactEmail** | **String** |  | [optional] 
**PrimaryContactDisplayName** | **String** |  | [optional] 
**SecondaryContact** | **String** |  | [optional] 
**SecondaryContactEmail** | **String** |  | [optional] 
**SecondaryContactDisplayName** | **String** |  | [optional] 
**PrimaryAdministrators** | **String** |  | [optional] 
**PrimaryAdministratorDisplayNames** | **String** |  | [optional] 
**AdditionalAdministrators** | **String** |  | [optional] 
**AdditionalAdministratorDisplayNames** | **String** |  | [optional] 
**Phase** | **String** |  | [optional] 
**PhaseAssigneeDisplayNames** | **String** |  | [optional] 
**PhaseAssignees** | **String** |  | [optional] 
**PhaseProfileName** | **String** |  | [optional] 
**PhaseStartTime** | **System.DateTime** |  | [optional] 
**RenewalDueDate** | **System.DateTime** |  | [optional] 
**NextRenewalDate** | **System.DateTime** |  | [optional] 
**Privacy** | **String** |  | [optional] 
**AssociateHubTitle** | **String** |  | [optional] 
**GeoLocation** | **String** |  | [optional] 
**StorageLimit** | **Int64** |  | [optional] [default to 0]
**StorageUsed** | **Double** |  | [optional] 
**SiteSharing** | **String** |  | [optional] 
**GroupSharing** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**ClaimStatus** | **String** |  | [optional] 
**CreatedTime** | **System.DateTime** |  | [optional] 
**LeaseExpirationTime** | **System.DateTime** |  | [optional] 
**InactivityThresholdTime** | **System.DateTime** |  | [optional] 
**Metadata** | **System.Collections.Hashtable** |  | [optional] 
**HasOngoingTasks** | **String** |  | [optional] 
**LastRenewalTime** | **System.DateTime** |  | [optional] 
**LastRenewalBy** | **String** |  | [optional] 
**LastRenewalByEmail** | **String** |  | [optional] 
**LastRenewalByDisplayName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkspaceReport = New-Cloud.Governance.ClientWorkspaceReport  -Id null `
 -Name null `
 -Description null `
 -Status null `
 -Type null `
 -Url null `
 -Email null `
 -PolicyName null `
 -PrimaryContact null `
 -PrimaryContactEmail null `
 -PrimaryContactDisplayName null `
 -SecondaryContact null `
 -SecondaryContactEmail null `
 -SecondaryContactDisplayName null `
 -PrimaryAdministrators null `
 -PrimaryAdministratorDisplayNames null `
 -AdditionalAdministrators null `
 -AdditionalAdministratorDisplayNames null `
 -Phase null `
 -PhaseAssigneeDisplayNames null `
 -PhaseAssignees null `
 -PhaseProfileName null `
 -PhaseStartTime null `
 -RenewalDueDate null `
 -NextRenewalDate null `
 -Privacy null `
 -AssociateHubTitle null `
 -GeoLocation null `
 -StorageLimit null `
 -StorageUsed null `
 -SiteSharing null `
 -GroupSharing null `
 -Classification null `
 -ClaimStatus null `
 -CreatedTime null `
 -LeaseExpirationTime null `
 -InactivityThresholdTime null `
 -Metadata null `
 -HasOngoingTasks null `
 -LastRenewalTime null `
 -LastRenewalBy null `
 -LastRenewalByEmail null `
 -LastRenewalByDisplayName null
```

- Convert the resource to JSON
```powershell
$WorkspaceReport | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

