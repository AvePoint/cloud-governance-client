# PolicyChangeLifecycleItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsDefineChangeToPolicies** | **Boolean** |  | [optional] [default to null]
**SelectedPoliciesForChangePolicy** | **String** |  | [optional] [default to null]
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**IsDefaultProcess** | **Boolean** |  | [optional] [default to null]
**ProcessId** | [**UUID**](UUID.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPolicyChangeLifecycleItem  -IsDefineChangeToPolicies null `
 -SelectedPoliciesForChangePolicy null `
 -IsEnabled null `
 -IsDefaultProcess null `
 -ProcessId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

