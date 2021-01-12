# GuestUserPropertyModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **String** |  | [optional] 
**FirstName** | **String** |  | [optional] 
**LastName** | **String** |  | [optional] 
**UserName** | **String** |  | [optional] 
**UsageLocation** | **String** |  | [optional] 
**JobTitle** | **String** |  | [optional] 
**JobDepartment** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GuestUserPropertyModel = New-Cloud.Governance.ClientGuestUserPropertyModel  -DisplayName null `
 -FirstName null `
 -LastName null `
 -UserName null `
 -UsageLocation null `
 -JobTitle null `
 -JobDepartment null
```

- Convert the resource to JSON
```powershell
$GuestUserPropertyModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

