# SPPrincipal
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Int32** |  | [optional] [default to null]
**LoginName** | **String** |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**PrincipalType** | [**SPPrincipalType**](SPPrincipalType.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSPPrincipal  -Id null `
 -LoginName null `
 -Name null `
 -PrincipalType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

