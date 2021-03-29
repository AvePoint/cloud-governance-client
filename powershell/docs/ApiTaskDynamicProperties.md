# ApiTaskDynamicProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**None** | [**AnyType**](.md) |  | [optional] 
**PrimaryContact** | [**AnyType**](.md) |  | [optional] 
**SecondaryContact** | [**AnyType**](.md) |  | [optional] 
**SiteId** | [**AnyType**](.md) |  | [optional] 
**SiteUrl** | [**AnyType**](.md) |  | [optional] 
**GroupName** | [**AnyType**](.md) |  | [optional] 
**ExpirationDate** | [**AnyType**](.md) |  | [optional] 
**GroupOwners** | [**AnyType**](.md) |  | [optional] 
**AutoTaskActionHistories** | [**AnyType**](.md) |  | [optional] 
**InactivityThresholdDate** | [**AnyType**](.md) |  | [optional] 
**GroupEmail** | [**AnyType**](.md) |  | [optional] 
**GroupId** | [**AnyType**](.md) |  | [optional] 
**PolicyName** | [**AnyType**](.md) |  | [optional] 
**PrimaryAdministrator** | [**AnyType**](.md) |  | [optional] 
**SiteTemplate** | [**AnyType**](.md) |  | [optional] 
**SiteTitle** | [**AnyType**](.md) |  | [optional] 
**SiteDescription** | [**AnyType**](.md) |  | [optional] 
**Requester** | [**AnyType**](.md) |  | [optional] 
**IsTeam** | [**AnyType**](.md) |  | [optional] 
**IsYammer** | [**AnyType**](.md) |  | [optional] 
**GroupOwnersStr** | [**AnyType**](.md) |  | [optional] 
**TenantId** | [**AnyType**](.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApiTaskDynamicProperties = New-Cloud.Governance.ClientApiTaskDynamicProperties  -None null `
 -PrimaryContact null `
 -SecondaryContact null `
 -SiteId null `
 -SiteUrl null `
 -GroupName null `
 -ExpirationDate null `
 -GroupOwners null `
 -AutoTaskActionHistories null `
 -InactivityThresholdDate null `
 -GroupEmail null `
 -GroupId null `
 -PolicyName null `
 -PrimaryAdministrator null `
 -SiteTemplate null `
 -SiteTitle null `
 -SiteDescription null `
 -Requester null `
 -IsTeam null `
 -IsYammer null `
 -GroupOwnersStr null `
 -TenantId null
```

- Convert the resource to JSON
```powershell
$ApiTaskDynamicProperties | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

