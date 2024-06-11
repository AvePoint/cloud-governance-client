# ChangeSiteProfileOngoingActionModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HandleOngoingType** | [**HandleOngoingType**](HandleOngoingType.md) |  | [optional] 
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | [**GuidModel**](GuidModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteProfileOngoingActionModel = New-Cloud.Governance.ClientChangeSiteProfileOngoingActionModel  -HandleOngoingType null `
 -IsSendCancelEmail null `
 -CancelEmailTemplateId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteProfileOngoingActionModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

