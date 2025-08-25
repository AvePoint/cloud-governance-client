# SCLifecycleGalleryScLifecycleActionDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LifecycleActionType** | [**SCLifecycleActionType**](SCLifecycleActionType.md) |  | [optional] 
**LockType** | [**SCLifecycleLockType**](SCLifecycleLockType.md) |  | [optional] 
**IsPermanentlyDelete** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$SCLifecycleGalleryScLifecycleActionDetails = New-Cloud.Governance.ClientSCLifecycleGalleryScLifecycleActionDetails  -LifecycleActionType null `
 -LockType null `
 -IsPermanentlyDelete null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$SCLifecycleGalleryScLifecycleActionDetails | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

