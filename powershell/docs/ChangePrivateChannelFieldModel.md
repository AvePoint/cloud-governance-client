# ChangePrivateChannelFieldModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangePrivateChannelFieldName** | [**ChangePrivateChannelFieldName**](ChangePrivateChannelFieldName.md) | Change PrivateChannel field name | [optional] 
**IsEnabled** | **Boolean** | Is enabled | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$ChangePrivateChannelFieldModel = New-Cloud.Governance.ClientChangePrivateChannelFieldModel  -ChangePrivateChannelFieldName null `
 -IsEnabled null
```

- Convert the resource to JSON
```powershell
$ChangePrivateChannelFieldModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

