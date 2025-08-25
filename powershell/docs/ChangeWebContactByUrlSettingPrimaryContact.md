# ChangeWebContactByUrlSettingPrimaryContact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeValue** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**OriginalValue** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeWebContactByUrlSettingPrimaryContact = New-Cloud.Governance.ClientChangeWebContactByUrlSettingPrimaryContact  -ChangeValue null `
 -OriginalValue null
```

- Convert the resource to JSON
```powershell
$ChangeWebContactByUrlSettingPrimaryContact | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

