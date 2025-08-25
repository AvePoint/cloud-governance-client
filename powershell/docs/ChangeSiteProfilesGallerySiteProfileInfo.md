# ChangeSiteProfilesGallerySiteProfileInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Url** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**IsManagedByGAO** | **Boolean** |  | [optional] [default to $false]
**ObjectName** | **String** |  | [optional] 
**ObjectIdentity** | **String** |  | [optional] 
**OriginalPolicyId** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteProfilesGallerySiteProfileInfo = New-Cloud.Governance.ClientChangeSiteProfilesGallerySiteProfileInfo  -Id null `
 -TenantId null `
 -Url null `
 -Title null `
 -IsManagedByGAO null `
 -ObjectName null `
 -ObjectIdentity null `
 -OriginalPolicyId null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteProfilesGallerySiteProfileInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

