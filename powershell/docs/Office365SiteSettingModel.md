# Office365SiteSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SensitivityLabelEnabled** | **Boolean** |  | [optional] [default to $false]
**ClassificationList** | [**GroupClassificationModel[]**](GroupClassificationModel.md) |  | [optional] 
**SensitivityLabelList** | [**SensitivityLabelModel[]**](SensitivityLabelModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$Office365SiteSettingModel = New-Cloud.Governance.ClientOffice365SiteSettingModel  -SensitivityLabelEnabled null `
 -ClassificationList null `
 -SensitivityLabelList null
```

- Convert the resource to JSON
```powershell
$Office365SiteSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

