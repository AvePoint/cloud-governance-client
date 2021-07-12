#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangePermissionService<PSCustomObject>
#>

function New-ChangePermissionService {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedNodes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${UncheckedNodes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserRestrictionType} = "AnyUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PermissionChangedType} = "RemovePermission",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PermissionChangedTypeAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledExcludePermissions} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ExcludedPermissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ReviewTaskEmailTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ScopeSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${StageCount} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RequestTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HideRequestSummary} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceAdminContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ApproversContainManagerRole} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Inactive",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowServiceInCatalog} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CustomActions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ApprovalProcessId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageId} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SelectedNodes" = ${SelectedNodes}
            "UncheckedNodes" = ${UncheckedNodes}
            "UserRestrictionType" = ${UserRestrictionType}
            "PermissionChangedType" = ${PermissionChangedType}
            "PermissionChangedTypeAssignBy" = ${PermissionChangedTypeAssignBy}
            "EnabledExcludePermissions" = ${EnabledExcludePermissions}
            "ExcludedPermissions" = ${ExcludedPermissions}
            "ReviewTaskEmailTemplate" = ${ReviewTaskEmailTemplate}
            "ScopeSettings" = ${ScopeSettings}
            "StageCount" = ${StageCount}
            "RequestTemplate" = ${RequestTemplate}
            "Metadatas" = ${Metadatas}
            "HideRequestSummary" = ${HideRequestSummary}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "ServiceContact" = ${ServiceContact}
            "ServiceAdminContact" = ${ServiceAdminContact}
            "ApproversContainManagerRole" = ${ApproversContainManagerRole}
            "Status" = ${Status}
            "ShowServiceInCatalog" = ${ShowServiceInCatalog}
            "CustomActions" = ${CustomActions}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LanguageId" = ${LanguageId}
            "CategoryId" = ${CategoryId}
        }

        return $PSO
    }
}

<#
ChangePermissionService<PSCustomObject>
#>
function ConvertFrom-JsonToChangePermissionService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangePermissionService
        $AllProperties = $("SelectedNodes", "UncheckedNodes", "UserRestrictionType", "PermissionChangedType", "PermissionChangedTypeAssignBy", "EnabledExcludePermissions", "ExcludedPermissions", "ReviewTaskEmailTemplate", "ScopeSettings", "StageCount", "RequestTemplate", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedNodes"))) { #optional property not found
            $SelectedNodes = $null
        } else {
            $SelectedNodes = $JsonParameters.PSobject.Properties["SelectedNodes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UncheckedNodes"))) { #optional property not found
            $UncheckedNodes = $null
        } else {
            $UncheckedNodes = $JsonParameters.PSobject.Properties["UncheckedNodes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserRestrictionType"))) { #optional property not found
            $UserRestrictionType = $null
        } else {
            $UserRestrictionType = $JsonParameters.PSobject.Properties["UserRestrictionType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionChangedType"))) { #optional property not found
            $PermissionChangedType = $null
        } else {
            $PermissionChangedType = $JsonParameters.PSobject.Properties["PermissionChangedType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionChangedTypeAssignBy"))) { #optional property not found
            $PermissionChangedTypeAssignBy = $null
        } else {
            $PermissionChangedTypeAssignBy = $JsonParameters.PSobject.Properties["PermissionChangedTypeAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledExcludePermissions"))) { #optional property not found
            $EnabledExcludePermissions = $null
        } else {
            $EnabledExcludePermissions = $JsonParameters.PSobject.Properties["EnabledExcludePermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExcludedPermissions"))) { #optional property not found
            $ExcludedPermissions = $null
        } else {
            $ExcludedPermissions = $JsonParameters.PSobject.Properties["ExcludedPermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ReviewTaskEmailTemplate"))) { #optional property not found
            $ReviewTaskEmailTemplate = $null
        } else {
            $ReviewTaskEmailTemplate = $JsonParameters.PSobject.Properties["ReviewTaskEmailTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScopeSettings"))) { #optional property not found
            $ScopeSettings = $null
        } else {
            $ScopeSettings = $JsonParameters.PSobject.Properties["ScopeSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StageCount"))) { #optional property not found
            $StageCount = $null
        } else {
            $StageCount = $JsonParameters.PSobject.Properties["StageCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestTemplate"))) { #optional property not found
            $RequestTemplate = $null
        } else {
            $RequestTemplate = $JsonParameters.PSobject.Properties["RequestTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HideRequestSummary"))) { #optional property not found
            $HideRequestSummary = $null
        } else {
            $HideRequestSummary = $JsonParameters.PSobject.Properties["HideRequestSummary"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceContact"))) { #optional property not found
            $ServiceContact = $null
        } else {
            $ServiceContact = $JsonParameters.PSobject.Properties["ServiceContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceAdminContact"))) { #optional property not found
            $ServiceAdminContact = $null
        } else {
            $ServiceAdminContact = $JsonParameters.PSobject.Properties["ServiceAdminContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApproversContainManagerRole"))) { #optional property not found
            $ApproversContainManagerRole = $null
        } else {
            $ApproversContainManagerRole = $JsonParameters.PSobject.Properties["ApproversContainManagerRole"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowServiceInCatalog"))) { #optional property not found
            $ShowServiceInCatalog = $null
        } else {
            $ShowServiceInCatalog = $JsonParameters.PSobject.Properties["ShowServiceInCatalog"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CustomActions"))) { #optional property not found
            $CustomActions = $null
        } else {
            $CustomActions = $JsonParameters.PSobject.Properties["CustomActions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApprovalProcessId"))) { #optional property not found
            $ApprovalProcessId = $null
        } else {
            $ApprovalProcessId = $JsonParameters.PSobject.Properties["ApprovalProcessId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageId"))) { #optional property not found
            $LanguageId = $null
        } else {
            $LanguageId = $JsonParameters.PSobject.Properties["LanguageId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CategoryId"))) { #optional property not found
            $CategoryId = $null
        } else {
            $CategoryId = $JsonParameters.PSobject.Properties["CategoryId"].value
        }

        $PSO = [PSCustomObject]@{
            "SelectedNodes" = ${SelectedNodes}
            "UncheckedNodes" = ${UncheckedNodes}
            "UserRestrictionType" = ${UserRestrictionType}
            "PermissionChangedType" = ${PermissionChangedType}
            "PermissionChangedTypeAssignBy" = ${PermissionChangedTypeAssignBy}
            "EnabledExcludePermissions" = ${EnabledExcludePermissions}
            "ExcludedPermissions" = ${ExcludedPermissions}
            "ReviewTaskEmailTemplate" = ${ReviewTaskEmailTemplate}
            "ScopeSettings" = ${ScopeSettings}
            "StageCount" = ${StageCount}
            "RequestTemplate" = ${RequestTemplate}
            "Metadatas" = ${Metadatas}
            "HideRequestSummary" = ${HideRequestSummary}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "ServiceContact" = ${ServiceContact}
            "ServiceAdminContact" = ${ServiceAdminContact}
            "ApproversContainManagerRole" = ${ApproversContainManagerRole}
            "Status" = ${Status}
            "ShowServiceInCatalog" = ${ShowServiceInCatalog}
            "CustomActions" = ${CustomActions}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LanguageId" = ${LanguageId}
            "CategoryId" = ${CategoryId}
        }

        return $PSO
    }

}

