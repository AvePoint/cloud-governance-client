# RootSiteWithManagedPaths
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RootSite** | **String** |  | [optional] 
**ManagedPaths** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RootSiteWithManagedPaths = New-Cloud.Governance.ClientRootSiteWithManagedPaths  -RootSite null `
 -ManagedPaths null
```

- Convert the resource to JSON
```powershell
$RootSiteWithManagedPaths | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

