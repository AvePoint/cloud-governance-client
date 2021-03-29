# ContentMoveUrlValidationResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | [**ContentMoveSPObject**](ContentMoveSPObject.md) |  | [optional] 
**ListBaseType** | **String** |  | [optional] 
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ContentMoveUrlValidationResult = New-Cloud.Governance.ClientContentMoveUrlValidationResult  -Object null `
 -ListBaseType null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ContentMoveUrlValidationResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

