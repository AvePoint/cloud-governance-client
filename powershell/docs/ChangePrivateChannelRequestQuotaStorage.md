# ChangePrivateChannelRequestQuotaStorage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangeValue** | **Int64** |  | [optional] [default to 0]
**OriginalValue** | **Int64** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$ChangePrivateChannelRequestQuotaStorage = New-Cloud.Governance.ClientChangePrivateChannelRequestQuotaStorage  -ChangeValue null `
 -OriginalValue null
```

- Convert the resource to JSON
```powershell
$ChangePrivateChannelRequestQuotaStorage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

