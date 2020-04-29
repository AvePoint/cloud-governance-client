# WorkspaceAuditGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ObjectName** | **String** |  | [optional] [default to null]
**ObjectUrl** | **String** |  | [optional] [default to null]
**ObjectType** | [**AuditObjectType**](AuditObjectType.md) |  | [optional] [default to null]
**ObjectTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**InitiatedBy** | **String** |  | [optional] [default to null]
**InitiatedByDisplayName** | **String** |  | [optional] [default to null]
**Activity** | [**AuditActionType**](AuditActionType.md) |  | [optional] [default to null]
**ActivityDescription** | **String** |  | [optional] [readonly] [default to null]
**ActionTime** | **System.DateTime** |  | [optional] [default to null]
**Status** | [**AutoImportPhase**](AutoImportPhase.md) |  | [optional] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientWorkspaceAuditGridModel  -Id null `
 -ObjectName null `
 -ObjectUrl null `
 -ObjectType null `
 -ObjectTypeDescription null `
 -InitiatedBy null `
 -InitiatedByDisplayName null `
 -Activity null `
 -ActivityDescription null `
 -ActionTime null `
 -Status null `
 -StatusDescription null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

