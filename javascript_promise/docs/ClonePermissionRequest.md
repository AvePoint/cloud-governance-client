# CgClient.ClonePermissionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**urls** | **[String]** |  | [optional] 
**sourceUser** | [**ApiUser**](ApiUser.md) |  | [optional] 
**targetUser** | [**ApiUser**](ApiUser.md) |  | [optional] 
**cloneOption** | [**ClonePermissionOption**](ClonePermissionOption.md) |  | [optional] 
**additionalCloneOption** | [**ClonePermissionAdditionalOption**](ClonePermissionAdditionalOption.md) |  | [optional] 
**enabledRemoveExplicitPermission** | **Boolean** |  | [optional] 
**enabledRemoveUserFromSPGroup** | **Boolean** |  | [optional] 
**enabledDeleteUserPermission** | **Boolean** |  | [optional] 
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


