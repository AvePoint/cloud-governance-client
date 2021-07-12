# Cloud.Governance.Client.Model.GroupLeasePeriodSettings
Group lease period settings model
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **bool** | Whether group extend lease is enabled after expiration | [optional] [default to false]
**LeaseType** | **GroupLeasePeriodType** | Group lease period extension type | [optional] 
**DurationType** | **ApiDurationType** | Duration type of the group lease period | [optional] 
**DurationInterval** | **int** | Group lease period | [optional] [default to 0]
**LeaseExpirationDate** | **DateTime?** | Group lease expiration date and time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

