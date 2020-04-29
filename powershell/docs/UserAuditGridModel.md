# UserAuditGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | [**EventObject**](EventObject.md) |  | [optional] [default to null]
**ObjectDescription** | **String** |  | [optional] [readonly] [default to null]
**ObjectType** | [**EventObjectType**](EventObjectType.md) |  | [optional] [default to null]
**ObjectTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**InstanceName** | **String** |  | [optional] [default to null]
**CreatedBy** | **String** |  | [optional] [default to null]
**Created** | **System.DateTime** |  | [optional] [default to null]
**Action** | [**EventAction**](EventAction.md) |  | [optional] [default to null]
**ActionDescription** | **String** |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientUserAuditGridModel  -Object null `
 -ObjectDescription null `
 -ObjectType null `
 -ObjectTypeDescription null `
 -InstanceName null `
 -CreatedBy null `
 -Created null `
 -Action null `
 -ActionDescription null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

