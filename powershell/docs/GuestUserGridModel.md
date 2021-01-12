# GuestUserGridModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**Mail** | **String** |  | [optional] 
**PrimaryContact** | **String** |  | [optional] 
**PrimaryContactDisplayName** | **String** |  | [optional] 
**SecondaryContact** | **String** |  | [optional] 
**SecondaryContactDisplayName** | **String** |  | [optional] 
**Status** | [**GuestUserStatus**](GuestUserStatus.md) |  | [optional] 
**StatusDescription** | **String** |  | [optional] 
**ProfileName** | **String** |  | [optional] 
**NextRenewalDate** | **System.DateTime** |  | [optional] 
**Metadata** | [**ReportMetadata[]**](ReportMetadata.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GuestUserGridModel = New-Cloud.Governance.ClientGuestUserGridModel  -Id null `
 -DisplayName null `
 -Mail null `
 -PrimaryContact null `
 -PrimaryContactDisplayName null `
 -SecondaryContact null `
 -SecondaryContactDisplayName null `
 -Status null `
 -StatusDescription null `
 -ProfileName null `
 -NextRenewalDate null `
 -Metadata null
```

- Convert the resource to JSON
```powershell
$GuestUserGridModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

