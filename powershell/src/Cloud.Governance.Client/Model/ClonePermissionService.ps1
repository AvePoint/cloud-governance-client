#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ClonePermissionService<PSCustomObject>
#>

function New-ClonePermissionService {
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
        ${SourceUserRestrictionType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TargetUserRestrictionType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CloneOption},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ClonePermissionAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AdditionalCloneOption},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CloneAdditionalOptionAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledRemoveExplicitPermission},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledRemoveUserFromSPGroup},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledDeleteUserPermission},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TransferOptionValueAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsHideTree},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ScopeSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RequestTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DepartmentAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HideRequestSummary},
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
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Department},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LoadDepartmentFromUps},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Departments},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceAdminContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ApproversContainManagerRole},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowServiceInCatalog},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CustomActions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ApprovalProcessId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Details}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ClonePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SelectedNodes" = ${SelectedNodes}
            "UncheckedNodes" = ${UncheckedNodes}
            "SourceUserRestrictionType" = ${SourceUserRestrictionType}
            "TargetUserRestrictionType" = ${TargetUserRestrictionType}
            "CloneOption" = ${CloneOption}
            "ClonePermissionAssignBy" = ${ClonePermissionAssignBy}
            "AdditionalCloneOption" = ${AdditionalCloneOption}
            "CloneAdditionalOptionAssignBy" = ${CloneAdditionalOptionAssignBy}
            "EnabledRemoveExplicitPermission" = ${EnabledRemoveExplicitPermission}
            "EnabledRemoveUserFromSPGroup" = ${EnabledRemoveUserFromSPGroup}
            "EnabledDeleteUserPermission" = ${EnabledDeleteUserPermission}
            "TransferOptionValueAssignBy" = ${TransferOptionValueAssignBy}
            "IsHideTree" = ${IsHideTree}
            "ScopeSettings" = ${ScopeSettings}
            "RequestTemplate" = ${RequestTemplate}
            "DepartmentAssignBy" = ${DepartmentAssignBy}
            "Metadatas" = ${Metadatas}
            "HideRequestSummary" = ${HideRequestSummary}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "Department" = ${Department}
            "LoadDepartmentFromUps" = ${LoadDepartmentFromUps}
            "Departments" = ${Departments}
            "ServiceContact" = ${ServiceContact}
            "ServiceAdminContact" = ${ServiceAdminContact}
            "ApproversContainManagerRole" = ${ApproversContainManagerRole}
            "Status" = ${Status}
            "ShowServiceInCatalog" = ${ShowServiceInCatalog}
            "CustomActions" = ${CustomActions}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LanguageId" = ${LanguageId}
            "CategoryId" = ${CategoryId}
            "Details" = ${Details}
        }

        return $PSO
    }
}

<#
ClonePermissionService<PSCustomObject>
#>
function ConvertFrom-JsonToClonePermissionService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ClonePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ClonePermissionService
        $AllProperties = $("SelectedNodes", "UncheckedNodes", "SourceUserRestrictionType", "TargetUserRestrictionType", "CloneOption", "ClonePermissionAssignBy", "AdditionalCloneOption", "CloneAdditionalOptionAssignBy", "EnabledRemoveExplicitPermission", "EnabledRemoveUserFromSPGroup", "EnabledDeleteUserPermission", "TransferOptionValueAssignBy", "IsHideTree", "ScopeSettings", "RequestTemplate", "DepartmentAssignBy", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "Department", "LoadDepartmentFromUps", "Departments", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId", "Details")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SourceUserRestrictionType"))) { #optional property not found
            $SourceUserRestrictionType = $null
        } else {
            $SourceUserRestrictionType = $JsonParameters.PSobject.Properties["SourceUserRestrictionType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TargetUserRestrictionType"))) { #optional property not found
            $TargetUserRestrictionType = $null
        } else {
            $TargetUserRestrictionType = $JsonParameters.PSobject.Properties["TargetUserRestrictionType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CloneOption"))) { #optional property not found
            $CloneOption = $null
        } else {
            $CloneOption = $JsonParameters.PSobject.Properties["CloneOption"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClonePermissionAssignBy"))) { #optional property not found
            $ClonePermissionAssignBy = $null
        } else {
            $ClonePermissionAssignBy = $JsonParameters.PSobject.Properties["ClonePermissionAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalCloneOption"))) { #optional property not found
            $AdditionalCloneOption = $null
        } else {
            $AdditionalCloneOption = $JsonParameters.PSobject.Properties["AdditionalCloneOption"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CloneAdditionalOptionAssignBy"))) { #optional property not found
            $CloneAdditionalOptionAssignBy = $null
        } else {
            $CloneAdditionalOptionAssignBy = $JsonParameters.PSobject.Properties["CloneAdditionalOptionAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledRemoveExplicitPermission"))) { #optional property not found
            $EnabledRemoveExplicitPermission = $null
        } else {
            $EnabledRemoveExplicitPermission = $JsonParameters.PSobject.Properties["EnabledRemoveExplicitPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledRemoveUserFromSPGroup"))) { #optional property not found
            $EnabledRemoveUserFromSPGroup = $null
        } else {
            $EnabledRemoveUserFromSPGroup = $JsonParameters.PSobject.Properties["EnabledRemoveUserFromSPGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledDeleteUserPermission"))) { #optional property not found
            $EnabledDeleteUserPermission = $null
        } else {
            $EnabledDeleteUserPermission = $JsonParameters.PSobject.Properties["EnabledDeleteUserPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TransferOptionValueAssignBy"))) { #optional property not found
            $TransferOptionValueAssignBy = $null
        } else {
            $TransferOptionValueAssignBy = $JsonParameters.PSobject.Properties["TransferOptionValueAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsHideTree"))) { #optional property not found
            $IsHideTree = $null
        } else {
            $IsHideTree = $JsonParameters.PSobject.Properties["IsHideTree"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScopeSettings"))) { #optional property not found
            $ScopeSettings = $null
        } else {
            $ScopeSettings = $JsonParameters.PSobject.Properties["ScopeSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestTemplate"))) { #optional property not found
            $RequestTemplate = $null
        } else {
            $RequestTemplate = $JsonParameters.PSobject.Properties["RequestTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DepartmentAssignBy"))) { #optional property not found
            $DepartmentAssignBy = $null
        } else {
            $DepartmentAssignBy = $JsonParameters.PSobject.Properties["DepartmentAssignBy"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Department"))) { #optional property not found
            $Department = $null
        } else {
            $Department = $JsonParameters.PSobject.Properties["Department"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LoadDepartmentFromUps"))) { #optional property not found
            $LoadDepartmentFromUps = $null
        } else {
            $LoadDepartmentFromUps = $JsonParameters.PSobject.Properties["LoadDepartmentFromUps"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Departments"))) { #optional property not found
            $Departments = $null
        } else {
            $Departments = $JsonParameters.PSobject.Properties["Departments"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Details"))) { #optional property not found
            $Details = $null
        } else {
            $Details = $JsonParameters.PSobject.Properties["Details"].value
        }

        $PSO = [PSCustomObject]@{
            "SelectedNodes" = ${SelectedNodes}
            "UncheckedNodes" = ${UncheckedNodes}
            "SourceUserRestrictionType" = ${SourceUserRestrictionType}
            "TargetUserRestrictionType" = ${TargetUserRestrictionType}
            "CloneOption" = ${CloneOption}
            "ClonePermissionAssignBy" = ${ClonePermissionAssignBy}
            "AdditionalCloneOption" = ${AdditionalCloneOption}
            "CloneAdditionalOptionAssignBy" = ${CloneAdditionalOptionAssignBy}
            "EnabledRemoveExplicitPermission" = ${EnabledRemoveExplicitPermission}
            "EnabledRemoveUserFromSPGroup" = ${EnabledRemoveUserFromSPGroup}
            "EnabledDeleteUserPermission" = ${EnabledDeleteUserPermission}
            "TransferOptionValueAssignBy" = ${TransferOptionValueAssignBy}
            "IsHideTree" = ${IsHideTree}
            "ScopeSettings" = ${ScopeSettings}
            "RequestTemplate" = ${RequestTemplate}
            "DepartmentAssignBy" = ${DepartmentAssignBy}
            "Metadatas" = ${Metadatas}
            "HideRequestSummary" = ${HideRequestSummary}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "Department" = ${Department}
            "LoadDepartmentFromUps" = ${LoadDepartmentFromUps}
            "Departments" = ${Departments}
            "ServiceContact" = ${ServiceContact}
            "ServiceAdminContact" = ${ServiceAdminContact}
            "ApproversContainManagerRole" = ${ApproversContainManagerRole}
            "Status" = ${Status}
            "ShowServiceInCatalog" = ${ShowServiceInCatalog}
            "CustomActions" = ${CustomActions}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LanguageId" = ${LanguageId}
            "CategoryId" = ${CategoryId}
            "Details" = ${Details}
        }

        return $PSO
    }

}

