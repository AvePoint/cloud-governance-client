#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorkspaceList<PSCustomObject>
#>

function New-WorkspaceList {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "Site",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContactEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Phase} = "Confirmed",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhaseDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsCurrentRenewer} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Active",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AutoImportProfileId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${PendingAction} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContactEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Policy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryAdmin},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryAdminEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdditionalAdmin},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdditionalAdminEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GeoLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GeoLocationDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StorageLimit},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StorageUsage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Classification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Privacy} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrivacyDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadata}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WorkspaceList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Type" = ${Type}
            "SiteUrl" = ${SiteUrl}
            "GroupEmail" = ${GroupEmail}
            "TypeDescription" = ${TypeDescription}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactEmail" = ${PrimaryContactEmail}
            "Phase" = ${Phase}
            "PhaseDescription" = ${PhaseDescription}
            "IsCurrentRenewer" = ${IsCurrentRenewer}
            "CreatedTime" = ${CreatedTime}
            "Status" = ${Status}
            "AutoImportProfileId" = ${AutoImportProfileId}
            "PendingAction" = ${PendingAction}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactEmail" = ${SecondaryContactEmail}
            "Policy" = ${Policy}
            "PolicyId" = ${PolicyId}
            "Description" = ${Description}
            "PrimaryAdmin" = ${PrimaryAdmin}
            "PrimaryAdminEmail" = ${PrimaryAdminEmail}
            "AdditionalAdmin" = ${AdditionalAdmin}
            "AdditionalAdminEmail" = ${AdditionalAdminEmail}
            "GeoLocation" = ${GeoLocation}
            "GeoLocationDescription" = ${GeoLocationDescription}
            "StorageLimit" = ${StorageLimit}
            "StorageUsage" = ${StorageUsage}
            "Classification" = ${Classification}
            "Privacy" = ${Privacy}
            "PrivacyDescription" = ${PrivacyDescription}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }
}

<#
WorkspaceList<PSCustomObject>
#>
function ConvertFrom-JsonToWorkspaceList {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorkspaceList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorkspaceList
        $AllProperties = $("Id", "Name", "Type", "SiteUrl", "GroupEmail", "TypeDescription", "PrimaryContact", "PrimaryContactEmail", "Phase", "PhaseDescription", "IsCurrentRenewer", "CreatedTime", "Status", "AutoImportProfileId", "PendingAction", "SecondaryContact", "SecondaryContactEmail", "Policy", "PolicyId", "Description", "PrimaryAdmin", "PrimaryAdminEmail", "AdditionalAdmin", "AdditionalAdminEmail", "GeoLocation", "GeoLocationDescription", "StorageLimit", "StorageUsage", "Classification", "Privacy", "PrivacyDescription", "Metadata")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrl"))) { #optional property not found
            $SiteUrl = $null
        } else {
            $SiteUrl = $JsonParameters.PSobject.Properties["SiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupEmail"))) { #optional property not found
            $GroupEmail = $null
        } else {
            $GroupEmail = $JsonParameters.PSobject.Properties["GroupEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TypeDescription"))) { #optional property not found
            $TypeDescription = $null
        } else {
            $TypeDescription = $JsonParameters.PSobject.Properties["TypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContactEmail"))) { #optional property not found
            $PrimaryContactEmail = $null
        } else {
            $PrimaryContactEmail = $JsonParameters.PSobject.Properties["PrimaryContactEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Phase"))) { #optional property not found
            $Phase = $null
        } else {
            $Phase = $JsonParameters.PSobject.Properties["Phase"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseDescription"))) { #optional property not found
            $PhaseDescription = $null
        } else {
            $PhaseDescription = $JsonParameters.PSobject.Properties["PhaseDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsCurrentRenewer"))) { #optional property not found
            $IsCurrentRenewer = $null
        } else {
            $IsCurrentRenewer = $JsonParameters.PSobject.Properties["IsCurrentRenewer"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedTime"))) { #optional property not found
            $CreatedTime = $null
        } else {
            $CreatedTime = $JsonParameters.PSobject.Properties["CreatedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoImportProfileId"))) { #optional property not found
            $AutoImportProfileId = $null
        } else {
            $AutoImportProfileId = $JsonParameters.PSobject.Properties["AutoImportProfileId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PendingAction"))) { #optional property not found
            $PendingAction = $null
        } else {
            $PendingAction = $JsonParameters.PSobject.Properties["PendingAction"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactEmail"))) { #optional property not found
            $SecondaryContactEmail = $null
        } else {
            $SecondaryContactEmail = $JsonParameters.PSobject.Properties["SecondaryContactEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Policy"))) { #optional property not found
            $Policy = $null
        } else {
            $Policy = $JsonParameters.PSobject.Properties["Policy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyId"))) { #optional property not found
            $PolicyId = $null
        } else {
            $PolicyId = $JsonParameters.PSobject.Properties["PolicyId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdmin"))) { #optional property not found
            $PrimaryAdmin = $null
        } else {
            $PrimaryAdmin = $JsonParameters.PSobject.Properties["PrimaryAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdminEmail"))) { #optional property not found
            $PrimaryAdminEmail = $null
        } else {
            $PrimaryAdminEmail = $JsonParameters.PSobject.Properties["PrimaryAdminEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalAdmin"))) { #optional property not found
            $AdditionalAdmin = $null
        } else {
            $AdditionalAdmin = $JsonParameters.PSobject.Properties["AdditionalAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalAdminEmail"))) { #optional property not found
            $AdditionalAdminEmail = $null
        } else {
            $AdditionalAdminEmail = $JsonParameters.PSobject.Properties["AdditionalAdminEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GeoLocation"))) { #optional property not found
            $GeoLocation = $null
        } else {
            $GeoLocation = $JsonParameters.PSobject.Properties["GeoLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GeoLocationDescription"))) { #optional property not found
            $GeoLocationDescription = $null
        } else {
            $GeoLocationDescription = $JsonParameters.PSobject.Properties["GeoLocationDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StorageLimit"))) { #optional property not found
            $StorageLimit = $null
        } else {
            $StorageLimit = $JsonParameters.PSobject.Properties["StorageLimit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StorageUsage"))) { #optional property not found
            $StorageUsage = $null
        } else {
            $StorageUsage = $JsonParameters.PSobject.Properties["StorageUsage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Classification"))) { #optional property not found
            $Classification = $null
        } else {
            $Classification = $JsonParameters.PSobject.Properties["Classification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Privacy"))) { #optional property not found
            $Privacy = $null
        } else {
            $Privacy = $JsonParameters.PSobject.Properties["Privacy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrivacyDescription"))) { #optional property not found
            $PrivacyDescription = $null
        } else {
            $PrivacyDescription = $JsonParameters.PSobject.Properties["PrivacyDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadata"))) { #optional property not found
            $Metadata = $null
        } else {
            $Metadata = $JsonParameters.PSobject.Properties["Metadata"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Type" = ${Type}
            "SiteUrl" = ${SiteUrl}
            "GroupEmail" = ${GroupEmail}
            "TypeDescription" = ${TypeDescription}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactEmail" = ${PrimaryContactEmail}
            "Phase" = ${Phase}
            "PhaseDescription" = ${PhaseDescription}
            "IsCurrentRenewer" = ${IsCurrentRenewer}
            "CreatedTime" = ${CreatedTime}
            "Status" = ${Status}
            "AutoImportProfileId" = ${AutoImportProfileId}
            "PendingAction" = ${PendingAction}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactEmail" = ${SecondaryContactEmail}
            "Policy" = ${Policy}
            "PolicyId" = ${PolicyId}
            "Description" = ${Description}
            "PrimaryAdmin" = ${PrimaryAdmin}
            "PrimaryAdminEmail" = ${PrimaryAdminEmail}
            "AdditionalAdmin" = ${AdditionalAdmin}
            "AdditionalAdminEmail" = ${AdditionalAdminEmail}
            "GeoLocation" = ${GeoLocation}
            "GeoLocationDescription" = ${GeoLocationDescription}
            "StorageLimit" = ${StorageLimit}
            "StorageUsage" = ${StorageUsage}
            "Classification" = ${Classification}
            "Privacy" = ${Privacy}
            "PrivacyDescription" = ${PrivacyDescription}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }

}

