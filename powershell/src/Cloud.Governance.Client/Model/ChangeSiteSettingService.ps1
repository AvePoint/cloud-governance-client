#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeSiteSettingService<PSCustomObject>
#>

function New-ChangeSiteSettingService {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeTitle} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeDescription} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangeMetadataSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DeploymentManagerPlanSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeHubSite} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ScopeSettings},
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
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeSiteSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableChangeTitle" = ${EnableChangeTitle}
            "EnableChangeDescription" = ${EnableChangeDescription}
            "ChangeMetadataSettings" = ${ChangeMetadataSettings}
            "DeploymentManagerPlanSettings" = ${DeploymentManagerPlanSettings}
            "EnableChangeHubSite" = ${EnableChangeHubSite}
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
        }

        return $PSO
    }
}

<#
ChangeSiteSettingService<PSCustomObject>
#>
function ConvertFrom-JsonToChangeSiteSettingService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeSiteSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeSiteSettingService
        $AllProperties = $("EnableChangeTitle", "EnableChangeDescription", "ChangeMetadataSettings", "DeploymentManagerPlanSettings", "EnableChangeHubSite", "ScopeSettings", "RequestTemplate", "DepartmentAssignBy", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "Department", "LoadDepartmentFromUps", "Departments", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeTitle"))) { #optional property not found
            $EnableChangeTitle = $null
        } else {
            $EnableChangeTitle = $JsonParameters.PSobject.Properties["EnableChangeTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeDescription"))) { #optional property not found
            $EnableChangeDescription = $null
        } else {
            $EnableChangeDescription = $JsonParameters.PSobject.Properties["EnableChangeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangeMetadataSettings"))) { #optional property not found
            $ChangeMetadataSettings = $null
        } else {
            $ChangeMetadataSettings = $JsonParameters.PSobject.Properties["ChangeMetadataSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeploymentManagerPlanSettings"))) { #optional property not found
            $DeploymentManagerPlanSettings = $null
        } else {
            $DeploymentManagerPlanSettings = $JsonParameters.PSobject.Properties["DeploymentManagerPlanSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeHubSite"))) { #optional property not found
            $EnableChangeHubSite = $null
        } else {
            $EnableChangeHubSite = $JsonParameters.PSobject.Properties["EnableChangeHubSite"].value
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

        $PSO = [PSCustomObject]@{
            "EnableChangeTitle" = ${EnableChangeTitle}
            "EnableChangeDescription" = ${EnableChangeDescription}
            "ChangeMetadataSettings" = ${ChangeMetadataSettings}
            "DeploymentManagerPlanSettings" = ${DeploymentManagerPlanSettings}
            "EnableChangeHubSite" = ${EnableChangeHubSite}
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
        }

        return $PSO
    }

}

