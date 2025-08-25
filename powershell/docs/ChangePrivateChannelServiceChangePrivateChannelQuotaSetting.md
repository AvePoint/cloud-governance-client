# ChangePrivateChannelServiceChangePrivateChannelQuotaSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to $false]
**ChangePrivateChannelQuotaType** | [**ChangePrivateChannelQuotaType**](ChangePrivateChannelQuotaType.md) |  | [optional] 
**WithinSpecifyValue** | **Int32** |  | [optional] [default to 0]

## Examples

- Prepare the resource
```powershell
$ChangePrivateChannelServiceChangePrivateChannelQuotaSetting = New-Cloud.Governance.ClientChangePrivateChannelServiceChangePrivateChannelQuotaSetting  -IsEnabled null `
 -ChangePrivateChannelQuotaType null `
 -WithinSpecifyValue null
```

- Convert the resource to JSON
```powershell
$ChangePrivateChannelServiceChangePrivateChannelQuotaSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

