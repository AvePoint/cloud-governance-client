# ApplyPolicyInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**ApplyPolicyStatus**](ApplyPolicyStatus.md) |  | [optional] [default to null]
**LastChangeTime** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApplyPolicyInfo  -Status null `
 -LastChangeTime null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

