# SharingExpireSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpireType** | [**CommonSharingExpirationType**](CommonSharingExpirationType.md) |  | [optional] 
**ExpirationInDays** | **Int32** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$SharingExpireSettingModel = New-Cloud.Governance.ClientSharingExpireSettingModel  -ExpireType null `
 -ExpirationInDays null
```

- Convert the resource to JSON
```powershell
$SharingExpireSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

