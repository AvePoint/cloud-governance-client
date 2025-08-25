# CreateSharedMailboxGallerySentItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CopySendAs** | **Boolean** |  | [optional] [default to $false]
**CopySendOnBehalf** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSharedMailboxGallerySentItems = New-Cloud.Governance.ClientCreateSharedMailboxGallerySentItems  -CopySendAs null `
 -CopySendOnBehalf null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateSharedMailboxGallerySentItems | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

