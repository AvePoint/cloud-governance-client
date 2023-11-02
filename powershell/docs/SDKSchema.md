# SDKSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreateGroupGallery** | [**CreateGroupGallery**](CreateGroupGallery.md) |  | [optional] 
**CreateTeamGallery** | [**CreateTeamGallery**](CreateTeamGallery.md) | This is create team gallery model class inside DynamicRequest.ActivityGalleries | [optional] 

## Examples

- Prepare the resource
```powershell
$SDKSchema = New-Cloud.Governance.ClientSDKSchema  -CreateGroupGallery null `
 -CreateTeamGallery null
```

- Convert the resource to JSON
```powershell
$SDKSchema | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

