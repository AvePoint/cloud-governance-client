# RecertificationProfileGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Type** | [**RecertificationObjectType**](RecertificationObjectType.md) |  | [optional] [default to null]
**Category** | **String** |  | [optional] [default to null]
**ModifiedTime** | **System.DateTime** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRecertificationProfileGridModel  -Id null `
 -Name null `
 -Description null `
 -Type null `
 -Category null `
 -ModifiedTime null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

