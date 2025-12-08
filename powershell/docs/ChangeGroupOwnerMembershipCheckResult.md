# ChangeGroupOwnerMembershipCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableChangeMembershipAssignment** | **Boolean** |  | [optional] [default to $false]
**IsDynamicMembership** | **Boolean** |  | [optional] [default to $false]
**DynamicMembershipRules** | [**DynamicGroupRule[]**](DynamicGroupRule.md) |  | [optional] 
**AllowAddGuestUser** | **Boolean** |  | [optional] [default to $false]
**IsEnableTeam** | **Boolean** |  | [optional] [default to $false]
**IsGCCH** | **Boolean** |  | [optional] [default to $false]
**SiteUrl** | **String** |  | [optional] 
**Visibility** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**ExternalSharingProfileName** | **String** |  | [optional] 
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**AssignedLabels** | [**AssignedLabel**](AssignedLabel.md) |  | [optional] 
**WorkspaceTypeWithValidated** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeGroupOwnerMembershipCheckResult = New-Cloud.Governance.ClientChangeGroupOwnerMembershipCheckResult  -EnableChangeMembershipAssignment null `
 -IsDynamicMembership null `
 -DynamicMembershipRules null `
 -AllowAddGuestUser null `
 -IsEnableTeam null `
 -IsGCCH null `
 -SiteUrl null `
 -Visibility null `
 -Classification null `
 -ExternalSharingProfileName null `
 -Metadatas null `
 -AssignedLabels null `
 -WorkspaceTypeWithValidated null `
 -Owners null `
 -Members null `
 -PrimaryContact null `
 -SecondaryContact null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeGroupOwnerMembershipCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

