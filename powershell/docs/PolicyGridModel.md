# PolicyGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Type** | [**PolicyType**](PolicyType.md) |  | [optional] [default to null]
**Status** | [**CommonStatus**](CommonStatus.md) |  | [optional] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]
**LastModifiedTime** | **System.DateTime** |  | [optional] [default to null]
**CreatedByDisplayName** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientPolicyGridModel  -Id null `
 -Name null `
 -Type null `
 -Status null `
 -StatusDescription null `
 -LastModifiedTime null `
 -CreatedByDisplayName null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

