# ChangeGroupQuotaResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedAnySize** | **Boolean** |  | [optional] [default to null]
**MinQuotaSize** | **Int64** |  | [optional] [default to null]
**MaxQuotaSize** | **Int64** |  | [optional] [default to null]
**CurrentQuotaSize** | **Int64** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientChangeGroupQuotaResult  -AllowedAnySize null `
 -MinQuotaSize null `
 -MaxQuotaSize null `
 -CurrentQuotaSize null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

