# SiteClassificationAndSensitivityLabel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SensitivityLabel** | [**SiteSensitivityLabel**](SiteSensitivityLabel.md) |  | [optional] 
**Classification** | [**SiteClassification**](SiteClassification.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$SiteClassificationAndSensitivityLabel = New-Cloud.Governance.ClientSiteClassificationAndSensitivityLabel  -SensitivityLabel null `
 -Classification null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$SiteClassificationAndSensitivityLabel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

