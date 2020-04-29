# RequestList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServiceId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServiceName** | **String** |  | [optional] [default to null]
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] [default to null]
**ServiceTypeDescription** | **String** |  | [optional] [readonly] [default to null]
**TicketNumber** | **Int32** |  | [optional] [default to null]
**Summary** | **String** |  | [optional] [default to null]
**Status** | [**RequestProgressStatus**](RequestProgressStatus.md) |  | [optional] [default to null]
**ProcessStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] [default to null]
**StatusDescription** | **String** |  | [optional] [readonly] [default to null]
**Modified** | **System.DateTime** |  | [optional] [default to null]
**SubmitStatus** | **Int32** |  | [optional] [default to null]
**Assigned** | **String** |  | [optional] [default to null]
**ServiceAdmin** | **String** |  | [optional] [default to null]
**EnabledCopy** | **Boolean** |  | [optional] [default to null]
**QuestionnaireId** | [**UUID**](UUID.md) |  | [optional] [readonly] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRequestList  -Id null `
 -ServiceId null `
 -ServiceName null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -TicketNumber null `
 -Summary null `
 -Status null `
 -ProcessStatus null `
 -StatusDescription null `
 -Modified null `
 -SubmitStatus null `
 -Assigned null `
 -ServiceAdmin null `
 -EnabledCopy null `
 -QuestionnaireId null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

