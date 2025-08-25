# CreateGuestUserRequestUserProperties
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
**Manager** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**CompanyName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateGuestUserRequestUserProperties = New-Cloud.Governance.ClientCreateGuestUserRequestUserProperties  -DisplayName null `
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
$CreateGuestUserRequestUserProperties | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

