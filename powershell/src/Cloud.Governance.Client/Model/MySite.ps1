#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
MySite<PSCustomObject>
#>

function New-MySite {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FullUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${Size} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${QuotaSize} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "Site",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MySiteType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Classification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Sensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsCommunicationSite} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StorageUsed},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryAdministrator},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AdditionalAdministrator},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PreferredDataLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PreferredDataLocationName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Phase} = "Confirmed",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${PhaseStartTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhaseDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AutoImportProfileId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AutoImportProfileName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsCurrentRenewer} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PhaseAssignees},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${PhaseDueDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => MySite' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "FullUrl" = ${FullUrl}
            "Title" = ${Title}
            "Description" = ${Description}
            "Size" = ${Size}
            "QuotaSize" = ${QuotaSize}
            "Type" = ${Type}
            "MySiteType" = ${MySiteType}
            "Classification" = ${Classification}
            "Sensitivity" = ${Sensitivity}
            "IsCommunicationSite" = ${IsCommunicationSite}
            "CreatedTime" = ${CreatedTime}
            "StorageUsed" = ${StorageUsed}
            "PrimaryAdministrator" = ${PrimaryAdministrator}
            "AdditionalAdministrator" = ${AdditionalAdministrator}
            "PreferredDataLocation" = ${PreferredDataLocation}
            "PreferredDataLocationName" = ${PreferredDataLocationName}
            "Id" = ${Id}
            "Phase" = ${Phase}
            "PhaseStartTime" = ${PhaseStartTime}
            "PhaseDescription" = ${PhaseDescription}
            "AutoImportProfileId" = ${AutoImportProfileId}
            "AutoImportProfileName" = ${AutoImportProfileName}
            "PolicyName" = ${PolicyName}
            "PolicyDescription" = ${PolicyDescription}
            "IsCurrentRenewer" = ${IsCurrentRenewer}
            "PhaseAssignees" = ${PhaseAssignees}
            "PhaseDueDate" = ${PhaseDueDate}
            "Metadatas" = ${Metadatas}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "ErrorMessage" = ${ErrorMessage}
        }

        return $PSO
    }
}

<#
MySite<PSCustomObject>
#>
function ConvertFrom-JsonToMySite {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => MySite' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in MySite
        $AllProperties = $("FullUrl", "Title", "Description", "Size", "QuotaSize", "Type", "MySiteType", "Classification", "Sensitivity", "IsCommunicationSite", "CreatedTime", "StorageUsed", "PrimaryAdministrator", "AdditionalAdministrator", "PreferredDataLocation", "PreferredDataLocationName", "Id", "Phase", "PhaseStartTime", "PhaseDescription", "AutoImportProfileId", "AutoImportProfileName", "PolicyName", "PolicyDescription", "IsCurrentRenewer", "PhaseAssignees", "PhaseDueDate", "Metadatas", "PrimaryContact", "SecondaryContact", "ErrorMessage")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FullUrl"))) { #optional property not found
            $FullUrl = $null
        } else {
            $FullUrl = $JsonParameters.PSobject.Properties["FullUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Size"))) { #optional property not found
            $Size = $null
        } else {
            $Size = $JsonParameters.PSobject.Properties["Size"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "QuotaSize"))) { #optional property not found
            $QuotaSize = $null
        } else {
            $QuotaSize = $JsonParameters.PSobject.Properties["QuotaSize"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MySiteType"))) { #optional property not found
            $MySiteType = $null
        } else {
            $MySiteType = $JsonParameters.PSobject.Properties["MySiteType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Classification"))) { #optional property not found
            $Classification = $null
        } else {
            $Classification = $JsonParameters.PSobject.Properties["Classification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sensitivity"))) { #optional property not found
            $Sensitivity = $null
        } else {
            $Sensitivity = $JsonParameters.PSobject.Properties["Sensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsCommunicationSite"))) { #optional property not found
            $IsCommunicationSite = $null
        } else {
            $IsCommunicationSite = $JsonParameters.PSobject.Properties["IsCommunicationSite"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedTime"))) { #optional property not found
            $CreatedTime = $null
        } else {
            $CreatedTime = $JsonParameters.PSobject.Properties["CreatedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StorageUsed"))) { #optional property not found
            $StorageUsed = $null
        } else {
            $StorageUsed = $JsonParameters.PSobject.Properties["StorageUsed"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdministrator"))) { #optional property not found
            $PrimaryAdministrator = $null
        } else {
            $PrimaryAdministrator = $JsonParameters.PSobject.Properties["PrimaryAdministrator"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalAdministrator"))) { #optional property not found
            $AdditionalAdministrator = $null
        } else {
            $AdditionalAdministrator = $JsonParameters.PSobject.Properties["AdditionalAdministrator"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PreferredDataLocation"))) { #optional property not found
            $PreferredDataLocation = $null
        } else {
            $PreferredDataLocation = $JsonParameters.PSobject.Properties["PreferredDataLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PreferredDataLocationName"))) { #optional property not found
            $PreferredDataLocationName = $null
        } else {
            $PreferredDataLocationName = $JsonParameters.PSobject.Properties["PreferredDataLocationName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Phase"))) { #optional property not found
            $Phase = $null
        } else {
            $Phase = $JsonParameters.PSobject.Properties["Phase"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseStartTime"))) { #optional property not found
            $PhaseStartTime = $null
        } else {
            $PhaseStartTime = $JsonParameters.PSobject.Properties["PhaseStartTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseDescription"))) { #optional property not found
            $PhaseDescription = $null
        } else {
            $PhaseDescription = $JsonParameters.PSobject.Properties["PhaseDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoImportProfileId"))) { #optional property not found
            $AutoImportProfileId = $null
        } else {
            $AutoImportProfileId = $JsonParameters.PSobject.Properties["AutoImportProfileId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoImportProfileName"))) { #optional property not found
            $AutoImportProfileName = $null
        } else {
            $AutoImportProfileName = $JsonParameters.PSobject.Properties["AutoImportProfileName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyName"))) { #optional property not found
            $PolicyName = $null
        } else {
            $PolicyName = $JsonParameters.PSobject.Properties["PolicyName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyDescription"))) { #optional property not found
            $PolicyDescription = $null
        } else {
            $PolicyDescription = $JsonParameters.PSobject.Properties["PolicyDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsCurrentRenewer"))) { #optional property not found
            $IsCurrentRenewer = $null
        } else {
            $IsCurrentRenewer = $JsonParameters.PSobject.Properties["IsCurrentRenewer"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseAssignees"))) { #optional property not found
            $PhaseAssignees = $null
        } else {
            $PhaseAssignees = $JsonParameters.PSobject.Properties["PhaseAssignees"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseDueDate"))) { #optional property not found
            $PhaseDueDate = $null
        } else {
            $PhaseDueDate = $JsonParameters.PSobject.Properties["PhaseDueDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMessage"))) { #optional property not found
            $ErrorMessage = $null
        } else {
            $ErrorMessage = $JsonParameters.PSobject.Properties["ErrorMessage"].value
        }

        $PSO = [PSCustomObject]@{
            "FullUrl" = ${FullUrl}
            "Title" = ${Title}
            "Description" = ${Description}
            "Size" = ${Size}
            "QuotaSize" = ${QuotaSize}
            "Type" = ${Type}
            "MySiteType" = ${MySiteType}
            "Classification" = ${Classification}
            "Sensitivity" = ${Sensitivity}
            "IsCommunicationSite" = ${IsCommunicationSite}
            "CreatedTime" = ${CreatedTime}
            "StorageUsed" = ${StorageUsed}
            "PrimaryAdministrator" = ${PrimaryAdministrator}
            "AdditionalAdministrator" = ${AdditionalAdministrator}
            "PreferredDataLocation" = ${PreferredDataLocation}
            "PreferredDataLocationName" = ${PreferredDataLocationName}
            "Id" = ${Id}
            "Phase" = ${Phase}
            "PhaseStartTime" = ${PhaseStartTime}
            "PhaseDescription" = ${PhaseDescription}
            "AutoImportProfileId" = ${AutoImportProfileId}
            "AutoImportProfileName" = ${AutoImportProfileName}
            "PolicyName" = ${PolicyName}
            "PolicyDescription" = ${PolicyDescription}
            "IsCurrentRenewer" = ${IsCurrentRenewer}
            "PhaseAssignees" = ${PhaseAssignees}
            "PhaseDueDate" = ${PhaseDueDate}
            "Metadatas" = ${Metadatas}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "ErrorMessage" = ${ErrorMessage}
        }

        return $PSO
    }

}

