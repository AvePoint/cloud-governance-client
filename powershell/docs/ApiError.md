# ApiError
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **String** |  | [optional] 
**Message** | **String[]** |  | [optional] 
**RequestId** | **String** |  | [optional] 
**Date** | **System.DateTime** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApiError = New-Cloud.Governance.ClientApiError  -Code null `
 -Message null `
 -RequestId null `
 -Date null
```

- Convert the resource to JSON
```powershell
$ApiError | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

