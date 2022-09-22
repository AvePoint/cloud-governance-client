# Cloud.Governance.Client.Model.CreateGuestUserSubRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**UserProperties** | [**GuestUserPropertyModel**](GuestUserPropertyModel.md) |  | [optional] 
**WelcomeEmailMessage** | **string** |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**InviteGroups** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**OneTimeSettings** | [**GuestUserRequestOneTimeRenewalSettingModel**](GuestUserRequestOneTimeRenewalSettingModel.md) |  | [optional] 
**Metadatas** | [**List&lt;RequestMetadata&gt;**](RequestMetadata.md) |  | [optional] 
**ProcessStatus** | **ApiRequestProgressStatus** |  | [optional] [readonly] 
**AssignTo** | [**List&lt;ApiUser&gt;**](ApiUser.md) |  | [optional] 
**ModifiedBy** | **string** |  | [optional] 
**ModifiedByDisplayName** | **string** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

