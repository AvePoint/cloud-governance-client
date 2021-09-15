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
        ${EnableInviteOwnersGroup} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInviteContactGroup} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddToGroups} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContactAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContactAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Manager},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ManagerAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableOnTimeRenewal} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${OneTimeDuration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OneTimeDurationType} = "Day",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PeoplePickerFilterProfileId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableDomainList} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DomainListType} = "AllowSpecificDomainList",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Domains},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UsageLocationAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${JobTitleAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${JobDepartmentAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WelcomeEmailMessageAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UsageLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${JobTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${JobDepartment},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WelcomeEmailMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DisplayNameAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${FirstNameAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LastNameAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RequestTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInviteMultiple} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CompanyName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CompanyNameAssignBy} = "BusinessUser",
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
        'Creating PSCustomObject: Cloud.Governance.Client => CreateGuestUserService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "TenantId" = ${TenantId}
            "EnableInviteOwnersGroup" = ${EnableInviteOwnersGroup}
            "EnableInviteContactGroup" = ${EnableInviteContactGroup}
            "EnableAddToGroups" = ${EnableAddToGroups}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "Manager" = ${Manager}
            "ManagerAssignBy" = ${ManagerAssignBy}
            "EnableOnTimeRenewal" = ${EnableOnTimeRenewal}
            "OneTimeDuration" = ${OneTimeDuration}
            "OneTimeDurationType" = ${OneTimeDurationType}
            "PeoplePickerFilterProfileId" = ${PeoplePickerFilterProfileId}
            "EnableDomainList" = ${EnableDomainList}
            "DomainListType" = ${DomainListType}
            "Domains" = ${Domains}
            "UsageLocationAssignBy" = ${UsageLocationAssignBy}
            "JobTitleAssignBy" = ${JobTitleAssignBy}
            "JobDepartmentAssignBy" = ${JobDepartmentAssignBy}
            "WelcomeEmailMessageAssignBy" = ${WelcomeEmailMessageAssignBy}
            "UsageLocation" = ${UsageLocation}
            "JobTitle" = ${JobTitle}
            "JobDepartment" = ${JobDepartment}
            "WelcomeEmailMessage" = ${WelcomeEmailMessage}
            "DisplayNameAssignBy" = ${DisplayNameAssignBy}
            "FirstNameAssignBy" = ${FirstNameAssignBy}
            "LastNameAssignBy" = ${LastNameAssignBy}
            "RequestTemplate" = ${RequestTemplate}
            "EnableInviteMultiple" = ${EnableInviteMultiple}
            "CompanyName" = ${CompanyName}
            "CompanyNameAssignBy" = ${CompanyNameAssignBy}
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
        $AllProperties = $("TenantId", "EnableInviteOwnersGroup", "EnableInviteContactGroup", "EnableAddToGroups", "PrimaryContact", "PrimaryContactAssignBy", "SecondaryContact", "SecondaryContactAssignBy", "Manager", "ManagerAssignBy", "EnableOnTimeRenewal", "OneTimeDuration", "OneTimeDurationType", "PeoplePickerFilterProfileId", "EnableDomainList", "DomainListType", "Domains", "UsageLocationAssignBy", "JobTitleAssignBy", "JobDepartmentAssignBy", "WelcomeEmailMessageAssignBy", "UsageLocation", "JobTitle", "JobDepartment", "WelcomeEmailMessage", "DisplayNameAssignBy", "FirstNameAssignBy", "LastNameAssignBy", "RequestTemplate", "EnableInviteMultiple", "CompanyName", "CompanyNameAssignBy", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAddToGroups"))) { #optional property not found
            $EnableAddToGroups = $null
        } else {
            $EnableAddToGroups = $JsonParameters.PSobject.Properties["EnableAddToGroups"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Manager"))) { #optional property not found
            $Manager = $null
        } else {
            $Manager = $JsonParameters.PSobject.Properties["Manager"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ManagerAssignBy"))) { #optional property not found
            $ManagerAssignBy = $null
        } else {
            $ManagerAssignBy = $JsonParameters.PSobject.Properties["ManagerAssignBy"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PeoplePickerFilterProfileId"))) { #optional property not found
            $PeoplePickerFilterProfileId = $null
        } else {
            $PeoplePickerFilterProfileId = $JsonParameters.PSobject.Properties["PeoplePickerFilterProfileId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableDomainList"))) { #optional property not found
            $EnableDomainList = $null
        } else {
            $EnableDomainList = $JsonParameters.PSobject.Properties["EnableDomainList"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DomainListType"))) { #optional property not found
            $DomainListType = $null
        } else {
            $DomainListType = $JsonParameters.PSobject.Properties["DomainListType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Domains"))) { #optional property not found
            $Domains = $null
        } else {
            $Domains = $JsonParameters.PSobject.Properties["Domains"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UsageLocationAssignBy"))) { #optional property not found
            $UsageLocationAssignBy = $null
        } else {
            $UsageLocationAssignBy = $JsonParameters.PSobject.Properties["UsageLocationAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobTitleAssignBy"))) { #optional property not found
            $JobTitleAssignBy = $null
        } else {
            $JobTitleAssignBy = $JsonParameters.PSobject.Properties["JobTitleAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobDepartmentAssignBy"))) { #optional property not found
            $JobDepartmentAssignBy = $null
        } else {
            $JobDepartmentAssignBy = $JsonParameters.PSobject.Properties["JobDepartmentAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WelcomeEmailMessageAssignBy"))) { #optional property not found
            $WelcomeEmailMessageAssignBy = $null
        } else {
            $WelcomeEmailMessageAssignBy = $JsonParameters.PSobject.Properties["WelcomeEmailMessageAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UsageLocation"))) { #optional property not found
            $UsageLocation = $null
        } else {
            $UsageLocation = $JsonParameters.PSobject.Properties["UsageLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobTitle"))) { #optional property not found
            $JobTitle = $null
        } else {
            $JobTitle = $JsonParameters.PSobject.Properties["JobTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobDepartment"))) { #optional property not found
            $JobDepartment = $null
        } else {
            $JobDepartment = $JsonParameters.PSobject.Properties["JobDepartment"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WelcomeEmailMessage"))) { #optional property not found
            $WelcomeEmailMessage = $null
        } else {
            $WelcomeEmailMessage = $JsonParameters.PSobject.Properties["WelcomeEmailMessage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayNameAssignBy"))) { #optional property not found
            $DisplayNameAssignBy = $null
        } else {
            $DisplayNameAssignBy = $JsonParameters.PSobject.Properties["DisplayNameAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FirstNameAssignBy"))) { #optional property not found
            $FirstNameAssignBy = $null
        } else {
            $FirstNameAssignBy = $JsonParameters.PSobject.Properties["FirstNameAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastNameAssignBy"))) { #optional property not found
            $LastNameAssignBy = $null
        } else {
            $LastNameAssignBy = $JsonParameters.PSobject.Properties["LastNameAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestTemplate"))) { #optional property not found
            $RequestTemplate = $null
        } else {
            $RequestTemplate = $JsonParameters.PSobject.Properties["RequestTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInviteMultiple"))) { #optional property not found
            $EnableInviteMultiple = $null
        } else {
            $EnableInviteMultiple = $JsonParameters.PSobject.Properties["EnableInviteMultiple"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CompanyName"))) { #optional property not found
            $CompanyName = $null
        } else {
            $CompanyName = $JsonParameters.PSobject.Properties["CompanyName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CompanyNameAssignBy"))) { #optional property not found
            $CompanyNameAssignBy = $null
        } else {
            $CompanyNameAssignBy = $JsonParameters.PSobject.Properties["CompanyNameAssignBy"].value
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
            "TenantId" = ${TenantId}
            "EnableInviteOwnersGroup" = ${EnableInviteOwnersGroup}
            "EnableInviteContactGroup" = ${EnableInviteContactGroup}
            "EnableAddToGroups" = ${EnableAddToGroups}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "Manager" = ${Manager}
            "ManagerAssignBy" = ${ManagerAssignBy}
            "EnableOnTimeRenewal" = ${EnableOnTimeRenewal}
            "OneTimeDuration" = ${OneTimeDuration}
            "OneTimeDurationType" = ${OneTimeDurationType}
            "PeoplePickerFilterProfileId" = ${PeoplePickerFilterProfileId}
            "EnableDomainList" = ${EnableDomainList}
            "DomainListType" = ${DomainListType}
            "Domains" = ${Domains}
            "UsageLocationAssignBy" = ${UsageLocationAssignBy}
            "JobTitleAssignBy" = ${JobTitleAssignBy}
            "JobDepartmentAssignBy" = ${JobDepartmentAssignBy}
            "WelcomeEmailMessageAssignBy" = ${WelcomeEmailMessageAssignBy}
            "UsageLocation" = ${UsageLocation}
            "JobTitle" = ${JobTitle}
            "JobDepartment" = ${JobDepartment}
            "WelcomeEmailMessage" = ${WelcomeEmailMessage}
            "DisplayNameAssignBy" = ${DisplayNameAssignBy}
            "FirstNameAssignBy" = ${FirstNameAssignBy}
            "LastNameAssignBy" = ${LastNameAssignBy}
            "RequestTemplate" = ${RequestTemplate}
            "EnableInviteMultiple" = ${EnableInviteMultiple}
            "CompanyName" = ${CompanyName}
            "CompanyNameAssignBy" = ${CompanyNameAssignBy}
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

