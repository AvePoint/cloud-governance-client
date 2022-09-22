# Cloud.Governance.Client.Model.ChangeWebContactSubRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**AssignTo** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**ModifiedBy** | **string** |  | [optional] 
**ModifiedByDisplayName** | **string** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**Reason** | **string** |  | [optional] 
**Status** | **int** |  | [optional] [readonly] [default to 0]
**StatusDescription** | **string** |  | [optional] 
**ProgressStatus** | **ApiRequestProgressStatus** |  | [optional] [readonly] 
**ContactChangeSettings** | [**ChangeWebContactByUrlSetting**](ChangeWebContactByUrlSetting.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

