# UserLevelControlSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserLevelControlMode** | [**UserLevelControlMode**](UserLevelControlMode.md) |  | [optional] 
**IsSetRequesterAsDefaultEnabled** | **Boolean** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UserLevelControlSettings = New-Cloud.Governance.ClientUserLevelControlSettings  -UserLevelControlMode null `
 -IsSetRequesterAsDefaultEnabled null
```

- Convert the resource to JSON
```powershell
$UserLevelControlSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

