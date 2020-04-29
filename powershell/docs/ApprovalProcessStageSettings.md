# ApprovalProcessStageSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsAutoApproveWhenRequesterIsApprover** | **Boolean** |  | [optional] [default to null]
**IsEnableAutoApproval** | **Boolean** |  | [optional] [default to null]
**IsAutoApproveWhenRequesterInSpecifiedSecurityGroup** | **Boolean** |  | [optional] [default to null]
**SpecifiedSecurityGroup** | [**ApiUser**](ApiUser.md) |  | [optional] [default to null]
**StageCount** | **Int32** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientApprovalProcessStageSettings  -IsAutoApproveWhenRequesterIsApprover null `
 -IsEnableAutoApproval null `
 -IsAutoApproveWhenRequesterInSpecifiedSecurityGroup null `
 -SpecifiedSecurityGroup null `
 -StageCount null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

