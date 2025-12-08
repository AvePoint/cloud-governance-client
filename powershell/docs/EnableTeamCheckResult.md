# EnableTeamCheckResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**IsAppliedPolicy** | **Boolean** |  | [optional] [default to $false]
**TeamSiteUrl** | **String** |  | [optional] 
**HasOngoingTask** | **Boolean** |  | [optional] [default to $false]
**IsManagedByGAO** | **Boolean** |  | [optional] [default to $false]
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
$EnableTeamCheckResult = New-Cloud.Governance.ClientEnableTeamCheckResult  -TenantId null `
 -IsAppliedPolicy null `
 -TeamSiteUrl null `
 -HasOngoingTask null `
 -IsManagedByGAO null `
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
$EnableTeamCheckResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

