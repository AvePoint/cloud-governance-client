#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateWebService<PSCustomObject>
#>

function New-CreateWebService {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ScopeSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${WebLanguages},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${LanguageIdsAndTemplates},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TemplateIdsAndPermissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PermissionSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${UseUniquePermissions} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DeploymentManagerPlanSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${YammerGroupSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TemplateStoreUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AppSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NotifyPrimaryContactSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NotifySecondaryContactSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultPrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultSecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOnQuickLaunch} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOnTopLinkBar} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsNavigationInheritance} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${DefaultWebLanguage} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ScopeAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WebLanguageAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TemplateAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NavigationInheritanceAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NavigationAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContactAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContactAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PermissionAssignBy} = "BusinessUser",
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
        'Creating PSCustomObject: Cloud.Governance.Client => CreateWebService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ScopeSettings" = ${ScopeSettings}
            "WebLanguages" = ${WebLanguages}
            "LanguageIdsAndTemplates" = ${LanguageIdsAndTemplates}
            "TemplateIdsAndPermissions" = ${TemplateIdsAndPermissions}
            "PermissionSettings" = ${PermissionSettings}
            "UseUniquePermissions" = ${UseUniquePermissions}
            "DeploymentManagerPlanSettings" = ${DeploymentManagerPlanSettings}
            "YammerGroupSettings" = ${YammerGroupSettings}
            "TemplateStoreUrl" = ${TemplateStoreUrl}
            "AppSettings" = ${AppSettings}
            "NotifyPrimaryContactSettings" = ${NotifyPrimaryContactSettings}
            "NotifySecondaryContactSettings" = ${NotifySecondaryContactSettings}
            "DefaultPrimaryContact" = ${DefaultPrimaryContact}
            "DefaultSecondaryContact" = ${DefaultSecondaryContact}
            "IsOnQuickLaunch" = ${IsOnQuickLaunch}
            "IsOnTopLinkBar" = ${IsOnTopLinkBar}
            "IsNavigationInheritance" = ${IsNavigationInheritance}
            "DefaultWebLanguage" = ${DefaultWebLanguage}
            "ScopeAssignBy" = ${ScopeAssignBy}
            "WebLanguageAssignBy" = ${WebLanguageAssignBy}
            "TemplateAssignBy" = ${TemplateAssignBy}
            "NavigationInheritanceAssignBy" = ${NavigationInheritanceAssignBy}
            "NavigationAssignBy" = ${NavigationAssignBy}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "PermissionAssignBy" = ${PermissionAssignBy}
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
CreateWebService<PSCustomObject>
#>
function ConvertFrom-JsonToCreateWebService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateWebService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateWebService
        $AllProperties = $("ScopeSettings", "WebLanguages", "LanguageIdsAndTemplates", "TemplateIdsAndPermissions", "PermissionSettings", "UseUniquePermissions", "DeploymentManagerPlanSettings", "YammerGroupSettings", "TemplateStoreUrl", "AppSettings", "NotifyPrimaryContactSettings", "NotifySecondaryContactSettings", "DefaultPrimaryContact", "DefaultSecondaryContact", "IsOnQuickLaunch", "IsOnTopLinkBar", "IsNavigationInheritance", "DefaultWebLanguage", "ScopeAssignBy", "WebLanguageAssignBy", "TemplateAssignBy", "NavigationInheritanceAssignBy", "NavigationAssignBy", "PrimaryContactAssignBy", "SecondaryContactAssignBy", "PermissionAssignBy", "RequestTemplate", "DepartmentAssignBy", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "Department", "LoadDepartmentFromUps", "Departments", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScopeSettings"))) { #optional property not found
            $ScopeSettings = $null
        } else {
            $ScopeSettings = $JsonParameters.PSobject.Properties["ScopeSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebLanguages"))) { #optional property not found
            $WebLanguages = $null
        } else {
            $WebLanguages = $JsonParameters.PSobject.Properties["WebLanguages"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageIdsAndTemplates"))) { #optional property not found
            $LanguageIdsAndTemplates = $null
        } else {
            $LanguageIdsAndTemplates = $JsonParameters.PSobject.Properties["LanguageIdsAndTemplates"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateIdsAndPermissions"))) { #optional property not found
            $TemplateIdsAndPermissions = $null
        } else {
            $TemplateIdsAndPermissions = $JsonParameters.PSobject.Properties["TemplateIdsAndPermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionSettings"))) { #optional property not found
            $PermissionSettings = $null
        } else {
            $PermissionSettings = $JsonParameters.PSobject.Properties["PermissionSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UseUniquePermissions"))) { #optional property not found
            $UseUniquePermissions = $null
        } else {
            $UseUniquePermissions = $JsonParameters.PSobject.Properties["UseUniquePermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeploymentManagerPlanSettings"))) { #optional property not found
            $DeploymentManagerPlanSettings = $null
        } else {
            $DeploymentManagerPlanSettings = $JsonParameters.PSobject.Properties["DeploymentManagerPlanSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "YammerGroupSettings"))) { #optional property not found
            $YammerGroupSettings = $null
        } else {
            $YammerGroupSettings = $JsonParameters.PSobject.Properties["YammerGroupSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateStoreUrl"))) { #optional property not found
            $TemplateStoreUrl = $null
        } else {
            $TemplateStoreUrl = $JsonParameters.PSobject.Properties["TemplateStoreUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AppSettings"))) { #optional property not found
            $AppSettings = $null
        } else {
            $AppSettings = $JsonParameters.PSobject.Properties["AppSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NotifyPrimaryContactSettings"))) { #optional property not found
            $NotifyPrimaryContactSettings = $null
        } else {
            $NotifyPrimaryContactSettings = $JsonParameters.PSobject.Properties["NotifyPrimaryContactSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NotifySecondaryContactSettings"))) { #optional property not found
            $NotifySecondaryContactSettings = $null
        } else {
            $NotifySecondaryContactSettings = $JsonParameters.PSobject.Properties["NotifySecondaryContactSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultPrimaryContact"))) { #optional property not found
            $DefaultPrimaryContact = $null
        } else {
            $DefaultPrimaryContact = $JsonParameters.PSobject.Properties["DefaultPrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultSecondaryContact"))) { #optional property not found
            $DefaultSecondaryContact = $null
        } else {
            $DefaultSecondaryContact = $JsonParameters.PSobject.Properties["DefaultSecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsOnQuickLaunch"))) { #optional property not found
            $IsOnQuickLaunch = $null
        } else {
            $IsOnQuickLaunch = $JsonParameters.PSobject.Properties["IsOnQuickLaunch"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsOnTopLinkBar"))) { #optional property not found
            $IsOnTopLinkBar = $null
        } else {
            $IsOnTopLinkBar = $JsonParameters.PSobject.Properties["IsOnTopLinkBar"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsNavigationInheritance"))) { #optional property not found
            $IsNavigationInheritance = $null
        } else {
            $IsNavigationInheritance = $JsonParameters.PSobject.Properties["IsNavigationInheritance"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultWebLanguage"))) { #optional property not found
            $DefaultWebLanguage = $null
        } else {
            $DefaultWebLanguage = $JsonParameters.PSobject.Properties["DefaultWebLanguage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScopeAssignBy"))) { #optional property not found
            $ScopeAssignBy = $null
        } else {
            $ScopeAssignBy = $JsonParameters.PSobject.Properties["ScopeAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebLanguageAssignBy"))) { #optional property not found
            $WebLanguageAssignBy = $null
        } else {
            $WebLanguageAssignBy = $JsonParameters.PSobject.Properties["WebLanguageAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateAssignBy"))) { #optional property not found
            $TemplateAssignBy = $null
        } else {
            $TemplateAssignBy = $JsonParameters.PSobject.Properties["TemplateAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NavigationInheritanceAssignBy"))) { #optional property not found
            $NavigationInheritanceAssignBy = $null
        } else {
            $NavigationInheritanceAssignBy = $JsonParameters.PSobject.Properties["NavigationInheritanceAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NavigationAssignBy"))) { #optional property not found
            $NavigationAssignBy = $null
        } else {
            $NavigationAssignBy = $JsonParameters.PSobject.Properties["NavigationAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContactAssignBy"))) { #optional property not found
            $PrimaryContactAssignBy = $null
        } else {
            $PrimaryContactAssignBy = $JsonParameters.PSobject.Properties["PrimaryContactAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactAssignBy"))) { #optional property not found
            $SecondaryContactAssignBy = $null
        } else {
            $SecondaryContactAssignBy = $JsonParameters.PSobject.Properties["SecondaryContactAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionAssignBy"))) { #optional property not found
            $PermissionAssignBy = $null
        } else {
            $PermissionAssignBy = $JsonParameters.PSobject.Properties["PermissionAssignBy"].value
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
            "ScopeSettings" = ${ScopeSettings}
            "WebLanguages" = ${WebLanguages}
            "LanguageIdsAndTemplates" = ${LanguageIdsAndTemplates}
            "TemplateIdsAndPermissions" = ${TemplateIdsAndPermissions}
            "PermissionSettings" = ${PermissionSettings}
            "UseUniquePermissions" = ${UseUniquePermissions}
            "DeploymentManagerPlanSettings" = ${DeploymentManagerPlanSettings}
            "YammerGroupSettings" = ${YammerGroupSettings}
            "TemplateStoreUrl" = ${TemplateStoreUrl}
            "AppSettings" = ${AppSettings}
            "NotifyPrimaryContactSettings" = ${NotifyPrimaryContactSettings}
            "NotifySecondaryContactSettings" = ${NotifySecondaryContactSettings}
            "DefaultPrimaryContact" = ${DefaultPrimaryContact}
            "DefaultSecondaryContact" = ${DefaultSecondaryContact}
            "IsOnQuickLaunch" = ${IsOnQuickLaunch}
            "IsOnTopLinkBar" = ${IsOnTopLinkBar}
            "IsNavigationInheritance" = ${IsNavigationInheritance}
            "DefaultWebLanguage" = ${DefaultWebLanguage}
            "ScopeAssignBy" = ${ScopeAssignBy}
            "WebLanguageAssignBy" = ${WebLanguageAssignBy}
            "TemplateAssignBy" = ${TemplateAssignBy}
            "NavigationInheritanceAssignBy" = ${NavigationInheritanceAssignBy}
            "NavigationAssignBy" = ${NavigationAssignBy}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "PermissionAssignBy" = ${PermissionAssignBy}
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

