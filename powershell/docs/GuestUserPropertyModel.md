# GuestUserPropertyModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **String** |  | [optional] 
**FirstName** | **String** |  | [optional] 
**LastName** | **String** |  | [optional] 
**UserName** | **String** |  | [optional] 
**UsageLocation** | **String** |  | [optional] 
**UsageLocationDisplayName** | **String** |  | [optional] 
**JobTitle** | **String** |  | [optional] 
**JobDepartment** | **String** |  | [optional] 
**Manager** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**CompanyName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GuestUserPropertyModel = New-Cloud.Governance.ClientGuestUserPropertyModel  -DisplayName null `
 -FirstName null `
 -LastName null `
 -UserName null `
 -UsageLocation null `
 -UsageLocationDisplayName null `
 -JobTitle null `
 -JobDepartment null `
 -Manager null `
 -CompanyName null
```

- Convert the resource to JSON
```powershell
$GuestUserPropertyModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

