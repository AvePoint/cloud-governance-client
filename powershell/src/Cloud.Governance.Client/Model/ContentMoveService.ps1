#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ContentMoveService<PSCustomObject>
#>

function New-ContentMoveService {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Method} = "Copy",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action} = "Merge",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CopySettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MoveSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CommonSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ConflictResolutionAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DeleteTypeAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DeleteCheckedFilesAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${FilterPolicyAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MethodAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ActionAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CopySettingAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MoveSettingAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${VersionsAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WorkflowAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InformationRightsManagementAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NullColumnValueAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ModifiedByAndModifiedTimeAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MappingSettingAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${BackupEnvironmentAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RequestTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DepartmentAssignBy} = "BusinessUser",
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
        [String]
        ${Department},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LoadDepartmentFromUps} = $false,
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
        'Creating PSCustomObject: Cloud.Governance.Client => ContentMoveService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Method" = ${Method}
            "Action" = ${Action}
            "CopySettings" = ${CopySettings}
            "MoveSettings" = ${MoveSettings}
            "CommonSettings" = ${CommonSettings}
            "ConflictResolutionAssignBy" = ${ConflictResolutionAssignBy}
            "DeleteTypeAssignBy" = ${DeleteTypeAssignBy}
            "DeleteCheckedFilesAssignBy" = ${DeleteCheckedFilesAssignBy}
            "FilterPolicyAssignBy" = ${FilterPolicyAssignBy}
            "MethodAssignBy" = ${MethodAssignBy}
            "ActionAssignBy" = ${ActionAssignBy}
            "CopySettingAssignBy" = ${CopySettingAssignBy}
            "MoveSettingAssignBy" = ${MoveSettingAssignBy}
            "VersionsAssignBy" = ${VersionsAssignBy}
            "WorkflowAssignBy" = ${WorkflowAssignBy}
            "InformationRightsManagementAssignBy" = ${InformationRightsManagementAssignBy}
            "NullColumnValueAssignBy" = ${NullColumnValueAssignBy}
            "ModifiedByAndModifiedTimeAssignBy" = ${ModifiedByAndModifiedTimeAssignBy}
            "MappingSettingAssignBy" = ${MappingSettingAssignBy}
            "BackupEnvironmentAssignBy" = ${BackupEnvironmentAssignBy}
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
        }

        return $PSO
    }
}

<#
ContentMoveService<PSCustomObject>
#>
function ConvertFrom-JsonToContentMoveService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ContentMoveService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ContentMoveService
        $AllProperties = $("Method", "Action", "CopySettings", "MoveSettings", "CommonSettings", "ConflictResolutionAssignBy", "DeleteTypeAssignBy", "DeleteCheckedFilesAssignBy", "FilterPolicyAssignBy", "MethodAssignBy", "ActionAssignBy", "CopySettingAssignBy", "MoveSettingAssignBy", "VersionsAssignBy", "WorkflowAssignBy", "InformationRightsManagementAssignBy", "NullColumnValueAssignBy", "ModifiedByAndModifiedTimeAssignBy", "MappingSettingAssignBy", "BackupEnvironmentAssignBy", "RequestTemplate", "DepartmentAssignBy", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "Department", "LoadDepartmentFromUps", "Departments", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Method"))) { #optional property not found
            $Method = $null
        } else {
            $Method = $JsonParameters.PSobject.Properties["Method"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CopySettings"))) { #optional property not found
            $CopySettings = $null
        } else {
            $CopySettings = $JsonParameters.PSobject.Properties["CopySettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MoveSettings"))) { #optional property not found
            $MoveSettings = $null
        } else {
            $MoveSettings = $JsonParameters.PSobject.Properties["MoveSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CommonSettings"))) { #optional property not found
            $CommonSettings = $null
        } else {
            $CommonSettings = $JsonParameters.PSobject.Properties["CommonSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConflictResolutionAssignBy"))) { #optional property not found
            $ConflictResolutionAssignBy = $null
        } else {
            $ConflictResolutionAssignBy = $JsonParameters.PSobject.Properties["ConflictResolutionAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeleteTypeAssignBy"))) { #optional property not found
            $DeleteTypeAssignBy = $null
        } else {
            $DeleteTypeAssignBy = $JsonParameters.PSobject.Properties["DeleteTypeAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeleteCheckedFilesAssignBy"))) { #optional property not found
            $DeleteCheckedFilesAssignBy = $null
        } else {
            $DeleteCheckedFilesAssignBy = $JsonParameters.PSobject.Properties["DeleteCheckedFilesAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FilterPolicyAssignBy"))) { #optional property not found
            $FilterPolicyAssignBy = $null
        } else {
            $FilterPolicyAssignBy = $JsonParameters.PSobject.Properties["FilterPolicyAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MethodAssignBy"))) { #optional property not found
            $MethodAssignBy = $null
        } else {
            $MethodAssignBy = $JsonParameters.PSobject.Properties["MethodAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ActionAssignBy"))) { #optional property not found
            $ActionAssignBy = $null
        } else {
            $ActionAssignBy = $JsonParameters.PSobject.Properties["ActionAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CopySettingAssignBy"))) { #optional property not found
            $CopySettingAssignBy = $null
        } else {
            $CopySettingAssignBy = $JsonParameters.PSobject.Properties["CopySettingAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MoveSettingAssignBy"))) { #optional property not found
            $MoveSettingAssignBy = $null
        } else {
            $MoveSettingAssignBy = $JsonParameters.PSobject.Properties["MoveSettingAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VersionsAssignBy"))) { #optional property not found
            $VersionsAssignBy = $null
        } else {
            $VersionsAssignBy = $JsonParameters.PSobject.Properties["VersionsAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WorkflowAssignBy"))) { #optional property not found
            $WorkflowAssignBy = $null
        } else {
            $WorkflowAssignBy = $JsonParameters.PSobject.Properties["WorkflowAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InformationRightsManagementAssignBy"))) { #optional property not found
            $InformationRightsManagementAssignBy = $null
        } else {
            $InformationRightsManagementAssignBy = $JsonParameters.PSobject.Properties["InformationRightsManagementAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NullColumnValueAssignBy"))) { #optional property not found
            $NullColumnValueAssignBy = $null
        } else {
            $NullColumnValueAssignBy = $JsonParameters.PSobject.Properties["NullColumnValueAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ModifiedByAndModifiedTimeAssignBy"))) { #optional property not found
            $ModifiedByAndModifiedTimeAssignBy = $null
        } else {
            $ModifiedByAndModifiedTimeAssignBy = $JsonParameters.PSobject.Properties["ModifiedByAndModifiedTimeAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MappingSettingAssignBy"))) { #optional property not found
            $MappingSettingAssignBy = $null
        } else {
            $MappingSettingAssignBy = $JsonParameters.PSobject.Properties["MappingSettingAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BackupEnvironmentAssignBy"))) { #optional property not found
            $BackupEnvironmentAssignBy = $null
        } else {
            $BackupEnvironmentAssignBy = $JsonParameters.PSobject.Properties["BackupEnvironmentAssignBy"].value
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

        $PSO = [PSCustomObject]@{
            "Method" = ${Method}
            "Action" = ${Action}
            "CopySettings" = ${CopySettings}
            "MoveSettings" = ${MoveSettings}
            "CommonSettings" = ${CommonSettings}
            "ConflictResolutionAssignBy" = ${ConflictResolutionAssignBy}
            "DeleteTypeAssignBy" = ${DeleteTypeAssignBy}
            "DeleteCheckedFilesAssignBy" = ${DeleteCheckedFilesAssignBy}
            "FilterPolicyAssignBy" = ${FilterPolicyAssignBy}
            "MethodAssignBy" = ${MethodAssignBy}
            "ActionAssignBy" = ${ActionAssignBy}
            "CopySettingAssignBy" = ${CopySettingAssignBy}
            "MoveSettingAssignBy" = ${MoveSettingAssignBy}
            "VersionsAssignBy" = ${VersionsAssignBy}
            "WorkflowAssignBy" = ${WorkflowAssignBy}
            "InformationRightsManagementAssignBy" = ${InformationRightsManagementAssignBy}
            "NullColumnValueAssignBy" = ${NullColumnValueAssignBy}
            "ModifiedByAndModifiedTimeAssignBy" = ${ModifiedByAndModifiedTimeAssignBy}
            "MappingSettingAssignBy" = ${MappingSettingAssignBy}
            "BackupEnvironmentAssignBy" = ${BackupEnvironmentAssignBy}
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
        }

        return $PSO
    }

}

