# ChangePolicyScopeModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Category** | **String** |  | [optional] [default to null]
**CategoryDisplayName** | **String** |  | [optional] [default to null]
**Details** | **String** |  | [optional] [default to null]
**Type** | **Int32** |  | [optional] [default to null]
**Owner** | **String** |  | [optional] [default to null]
**FarmID** | [**UUID**](UUID.md) |  | [optional] [default to null]
**OnlineType** | **Int32** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangePolicyScopeModel  -Title null `
 -Description null `
 -Id null `
 -Category null `
 -CategoryDisplayName null `
 -Details null `
 -Type null `
 -Owner null `
 -FarmID null `
 -OnlineType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

