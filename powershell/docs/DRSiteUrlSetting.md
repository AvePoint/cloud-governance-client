# DRSiteUrlSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RootSite** | **String** |  | [optional] 
**ManagedPath** | **String** |  | [optional] 
**Url** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$DRSiteUrlSetting = New-Cloud.Governance.ClientDRSiteUrlSetting  -RootSite null `
 -ManagedPath null `
 -Url null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$DRSiteUrlSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

