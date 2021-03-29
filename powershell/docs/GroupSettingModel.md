# GroupSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupName** | **String** |  | [optional] 
**GroupDescription** | **String** |  | [optional] 
**GroupEmailAddress** | **String** |  | [optional] 
**Owners** | **String** |  | [optional] 
**Members** | **String** |  | [optional] 
**GroupDuration** | **Int32** |  | [optional] [default to 0]
**EmailSubject** | **String** |  | [optional] 
**EmailBody** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GroupSettingModel = New-Cloud.Governance.ClientGroupSettingModel  -GroupName null `
 -GroupDescription null `
 -GroupEmailAddress null `
 -Owners null `
 -Members null `
 -GroupDuration null `
 -EmailSubject null `
 -EmailBody null
```

- Convert the resource to JSON
```powershell
$GroupSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

