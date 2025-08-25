# LibraryScope
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentWebUrl** | **String** |  | [optional] 
**LibraryUrl** | **String** |  | [optional] 
**LibraryId** | **String** |  | [optional] 
**LibraryName** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$LibraryScope = New-Cloud.Governance.ClientLibraryScope  -ParentWebUrl null `
 -LibraryUrl null `
 -LibraryId null `
 -LibraryName null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$LibraryScope | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

