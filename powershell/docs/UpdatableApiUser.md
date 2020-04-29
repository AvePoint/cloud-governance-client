# UpdatableApiUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **String** |  | [optional] [default to null]
**JobTitle** | **String** |  | [optional] [default to null]
**Id** | **String** |  | [optional] [default to null]
**LoginName** | **String** |  | [optional] [default to null]
**DisplayName** | **String** |  | [optional] [default to null]
**IsGroup** | **Boolean** |  | [optional] [default to null]
**PhysicalDeliveryOfficeName** | **String** |  | [optional] [readonly] [default to null]
**IsOtherTenantUser** | **Boolean** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientUpdatableApiUser  -Email null `
 -JobTitle null `
 -Id null `
 -LoginName null `
 -DisplayName null `
 -IsGroup null `
 -PhysicalDeliveryOfficeName null `
 -IsOtherTenantUser null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

