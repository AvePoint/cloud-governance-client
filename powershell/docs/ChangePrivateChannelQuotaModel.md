# ChangePrivateChannelQuotaModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to $false]
**ChangePrivateChannelQuotaType** | [**ChangePrivateChannelQuotaType**](ChangePrivateChannelQuotaType.md) |  | [optional] 
**WithinSpecifyValue** | **Int32** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$ChangePrivateChannelQuotaModel = New-Cloud.Governance.ClientChangePrivateChannelQuotaModel  -IsEnabled null `
 -ChangePrivateChannelQuotaType null `
 -WithinSpecifyValue null
```

- Convert the resource to JSON
```powershell
$ChangePrivateChannelQuotaModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

