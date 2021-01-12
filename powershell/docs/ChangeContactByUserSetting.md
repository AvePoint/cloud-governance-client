# ChangeContactByUserSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentUser** | [**ApiUser**](ApiUser.md) |  | [optional] 
**NewUser** | [**ApiUser**](ApiUser.md) |  | [optional] 
**AlternativeUser** | [**ApiUser**](ApiUser.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeContactByUserSetting = New-Cloud.Governance.ClientChangeContactByUserSetting  -CurrentUser null `
 -NewUser null `
 -AlternativeUser null
```

- Convert the resource to JSON
```powershell
$ChangeContactByUserSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

