#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateGuestUserService<PSCustomObject>
#>

function New-CreateGuestUserService {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInviteOwnersGroup},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInviteContactGroup},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContactAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContactAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableOnTimeRenewal},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${OneTimeDuration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OneTimeDurationType},
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
        'Creating PSCustomObject: Cloud.Governance.Client => CreateGuestUserService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "TenantId" = ${TenantId}
            "EnableInviteOwnersGroup" = ${EnableInviteOwnersGroup}
            "EnableInviteContactGroup" = ${EnableInviteContactGroup}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "EnableOnTimeRenewal" = ${EnableOnTimeRenewal}
            "OneTimeDuration" = ${OneTimeDuration}
            "OneTimeDurationType" = ${OneTimeDurationType}
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
CreateGuestUserService<PSCustomObject>
#>
function ConvertFrom-JsonToCreateGuestUserService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateGuestUserService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateGuestUserService
        $AllProperties = $("TenantId", "EnableInviteOwnersGroup", "EnableInviteContactGroup", "PrimaryContact", "PrimaryContactAssignBy", "SecondaryContact", "SecondaryContactAssignBy", "EnableOnTimeRenewal", "OneTimeDuration", "OneTimeDurationType", "RequestTemplate", "DepartmentAssignBy", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "Department", "LoadDepartmentFromUps", "Departments", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId", "Details")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInviteOwnersGroup"))) { #optional property not found
            $EnableInviteOwnersGroup = $null
        } else {
            $EnableInviteOwnersGroup = $JsonParameters.PSobject.Properties["EnableInviteOwnersGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInviteContactGroup"))) { #optional property not found
            $EnableInviteContactGroup = $null
        } else {
            $EnableInviteContactGroup = $JsonParameters.PSobject.Properties["EnableInviteContactGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContactAssignBy"))) { #optional property not found
            $PrimaryContactAssignBy = $null
        } else {
            $PrimaryContactAssignBy = $JsonParameters.PSobject.Properties["PrimaryContactAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactAssignBy"))) { #optional property not found
            $SecondaryContactAssignBy = $null
        } else {
            $SecondaryContactAssignBy = $JsonParameters.PSobject.Properties["SecondaryContactAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableOnTimeRenewal"))) { #optional property not found
            $EnableOnTimeRenewal = $null
        } else {
            $EnableOnTimeRenewal = $JsonParameters.PSobject.Properties["EnableOnTimeRenewal"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OneTimeDuration"))) { #optional property not found
            $OneTimeDuration = $null
        } else {
            $OneTimeDuration = $JsonParameters.PSobject.Properties["OneTimeDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OneTimeDurationType"))) { #optional property not found
            $OneTimeDurationType = $null
        } else {
            $OneTimeDurationType = $JsonParameters.PSobject.Properties["OneTimeDurationType"].value
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
            "TenantId" = ${TenantId}
            "EnableInviteOwnersGroup" = ${EnableInviteOwnersGroup}
            "EnableInviteContactGroup" = ${EnableInviteContactGroup}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "EnableOnTimeRenewal" = ${EnableOnTimeRenewal}
            "OneTimeDuration" = ${OneTimeDuration}
            "OneTimeDurationType" = ${OneTimeDurationType}
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

