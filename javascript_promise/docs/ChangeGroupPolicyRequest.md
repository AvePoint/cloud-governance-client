# CgClient.ChangeGroupPolicyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**policy** | [**GuidModel**](GuidModel.md) |  | [optional] 
**originalPolicy** | [**GuidModel**](GuidModel.md) |  | [optional] [readonly] 
**isLeaseEnabled** | **Boolean** |  | [optional] 
**changePolicyConfig** | [**AssignBy**](AssignBy.md) |  | [optional] 
**startDateType** | [**StartDateType**](StartDateType.md) |  | [optional] 
**specifyStartDate** | **Date** |  | [optional] 
**groupId** | **String** |  | [optional] 
**groupName** | **String** |  | [optional] [readonly] 
**groupEmail** | **String** |  | [optional] [readonly] 
**id** | **String** |  | [optional] 
**serviceId** | **String** |  | [optional] 
**department** | **String** |  | [optional] 
**summary** | **String** |  | [optional] 
**notesToApprovers** | **String** |  | [optional] 
**questionnaireId** | **String** |  | [optional] 
**metadatas** | [**[RequestMetadata]**](RequestMetadata.md) |  | [optional] 
**ticketNumber** | **Number** |  | [optional] [readonly] 
**type** | [**ServiceTypeNullable**](ServiceTypeNullable.md) |  | [optional] [readonly] 
**typeDescription** | **String** |  | [optional] [readonly] 
**requester** | **String** |  | [optional] [readonly] 
**status** | [**RequestStatusNullable**](RequestStatusNullable.md) |  | [optional] [readonly] 
**progressStatus** | **Number** |  | [optional] [readonly] 
**progressStatusDescription** | **String** |  | [optional] [readonly] 
**submittedTime** | **Date** |  | [optional] [readonly] 
**lastUpdated** | **Date** |  | [optional] [readonly] 
**createdTime** | **Date** |  | [optional] [readonly] 
**assignTo** | **String** |  | [optional] [readonly] 
**fullPath** | **String** |  | [optional] [readonly] 


