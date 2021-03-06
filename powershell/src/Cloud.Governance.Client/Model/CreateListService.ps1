#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateListService<PSCustomObject>
#>

function New-CreateListService {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableNavigation} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultListType} = "Library",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${VersionSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ListTemplateSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UrlSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowBreakPermissionInheritance} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PermissionSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ScopeSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ListVersionAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ListTemplateAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NavigationAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ListTypeAssignBy} = "BusinessUser",
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
        'Creating PSCustomObject: Cloud.Governance.Client => CreateListService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableNavigation" = ${EnableNavigation}
            "DefaultListType" = ${DefaultListType}
            "VersionSettings" = ${VersionSettings}
            "ListTemplateSettings" = ${ListTemplateSettings}
            "UrlSettings" = ${UrlSettings}
            "AllowBreakPermissionInheritance" = ${AllowBreakPermissionInheritance}
            "PermissionSettings" = ${PermissionSettings}
            "ScopeSettings" = ${ScopeSettings}
            "ListVersionAssignBy" = ${ListVersionAssignBy}
            "ListTemplateAssignBy" = ${ListTemplateAssignBy}
            "NavigationAssignBy" = ${NavigationAssignBy}
            "ListTypeAssignBy" = ${ListTypeAssignBy}
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
CreateListService<PSCustomObject>
#>
function ConvertFrom-JsonToCreateListService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateListService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateListService
        $AllProperties = $("EnableNavigation", "DefaultListType", "VersionSettings", "ListTemplateSettings", "UrlSettings", "AllowBreakPermissionInheritance", "PermissionSettings", "ScopeSettings", "ListVersionAssignBy", "ListTemplateAssignBy", "NavigationAssignBy", "ListTypeAssignBy", "RequestTemplate", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableNavigation"))) { #optional property not found
            $EnableNavigation = $null
        } else {
            $EnableNavigation = $JsonParameters.PSobject.Properties["EnableNavigation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultListType"))) { #optional property not found
            $DefaultListType = $null
        } else {
            $DefaultListType = $JsonParameters.PSobject.Properties["DefaultListType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VersionSettings"))) { #optional property not found
            $VersionSettings = $null
        } else {
            $VersionSettings = $JsonParameters.PSobject.Properties["VersionSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListTemplateSettings"))) { #optional property not found
            $ListTemplateSettings = $null
        } else {
            $ListTemplateSettings = $JsonParameters.PSobject.Properties["ListTemplateSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UrlSettings"))) { #optional property not found
            $UrlSettings = $null
        } else {
            $UrlSettings = $JsonParameters.PSobject.Properties["UrlSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowBreakPermissionInheritance"))) { #optional property not found
            $AllowBreakPermissionInheritance = $null
        } else {
            $AllowBreakPermissionInheritance = $JsonParameters.PSobject.Properties["AllowBreakPermissionInheritance"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionSettings"))) { #optional property not found
            $PermissionSettings = $null
        } else {
            $PermissionSettings = $JsonParameters.PSobject.Properties["PermissionSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScopeSettings"))) { #optional property not found
            $ScopeSettings = $null
        } else {
            $ScopeSettings = $JsonParameters.PSobject.Properties["ScopeSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListVersionAssignBy"))) { #optional property not found
            $ListVersionAssignBy = $null
        } else {
            $ListVersionAssignBy = $JsonParameters.PSobject.Properties["ListVersionAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListTemplateAssignBy"))) { #optional property not found
            $ListTemplateAssignBy = $null
        } else {
            $ListTemplateAssignBy = $JsonParameters.PSobject.Properties["ListTemplateAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NavigationAssignBy"))) { #optional property not found
            $NavigationAssignBy = $null
        } else {
            $NavigationAssignBy = $JsonParameters.PSobject.Properties["NavigationAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListTypeAssignBy"))) { #optional property not found
            $ListTypeAssignBy = $null
        } else {
            $ListTypeAssignBy = $JsonParameters.PSobject.Properties["ListTypeAssignBy"].value
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
            "EnableNavigation" = ${EnableNavigation}
            "DefaultListType" = ${DefaultListType}
            "VersionSettings" = ${VersionSettings}
            "ListTemplateSettings" = ${ListTemplateSettings}
            "UrlSettings" = ${UrlSettings}
            "AllowBreakPermissionInheritance" = ${AllowBreakPermissionInheritance}
            "PermissionSettings" = ${PermissionSettings}
            "ScopeSettings" = ${ScopeSettings}
            "ListVersionAssignBy" = ${ListVersionAssignBy}
            "ListTemplateAssignBy" = ${ListTemplateAssignBy}
            "NavigationAssignBy" = ${NavigationAssignBy}
            "ListTypeAssignBy" = ${ListTypeAssignBy}
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

