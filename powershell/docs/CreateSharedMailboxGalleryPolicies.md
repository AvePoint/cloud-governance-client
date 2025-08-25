# CreateSharedMailboxGalleryPolicies
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharingPolicy** | **String** |  | [optional] 
**RoleAssignmentPolicy** | **String** |  | [optional] 
**RetentionPolicy** | **String** |  | [optional] 
**AddressBookPolicy** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateSharedMailboxGalleryPolicies = New-Cloud.Governance.ClientCreateSharedMailboxGalleryPolicies  -SharingPolicy null `
 -RoleAssignmentPolicy null `
 -RetentionPolicy null `
 -AddressBookPolicy null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateSharedMailboxGalleryPolicies | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

