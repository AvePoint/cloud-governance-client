#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GuestUserGridModel<PSCustomObject>
#>

function New-GuestUserGridModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Mail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContactDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContactDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Active",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProfileName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${NextRenewalDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadata}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GuestUserGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "DisplayName" = ${DisplayName}
            "Mail" = ${Mail}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactDisplayName" = ${PrimaryContactDisplayName}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactDisplayName" = ${SecondaryContactDisplayName}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "ProfileName" = ${ProfileName}
            "NextRenewalDate" = ${NextRenewalDate}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }
}

<#
GuestUserGridModel<PSCustomObject>
#>
function ConvertFrom-JsonToGuestUserGridModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GuestUserGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GuestUserGridModel
        $AllProperties = $("Id", "DisplayName", "Mail", "PrimaryContact", "PrimaryContactDisplayName", "SecondaryContact", "SecondaryContactDisplayName", "Status", "StatusDescription", "ProfileName", "NextRenewalDate", "Metadata")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Mail"))) { #optional property not found
            $Mail = $null
        } else {
            $Mail = $JsonParameters.PSobject.Properties["Mail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContactDisplayName"))) { #optional property not found
            $PrimaryContactDisplayName = $null
        } else {
            $PrimaryContactDisplayName = $JsonParameters.PSobject.Properties["PrimaryContactDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactDisplayName"))) { #optional property not found
            $SecondaryContactDisplayName = $null
        } else {
            $SecondaryContactDisplayName = $JsonParameters.PSobject.Properties["SecondaryContactDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StatusDescription"))) { #optional property not found
            $StatusDescription = $null
        } else {
            $StatusDescription = $JsonParameters.PSobject.Properties["StatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProfileName"))) { #optional property not found
            $ProfileName = $null
        } else {
            $ProfileName = $JsonParameters.PSobject.Properties["ProfileName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NextRenewalDate"))) { #optional property not found
            $NextRenewalDate = $null
        } else {
            $NextRenewalDate = $JsonParameters.PSobject.Properties["NextRenewalDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadata"))) { #optional property not found
            $Metadata = $null
        } else {
            $Metadata = $JsonParameters.PSobject.Properties["Metadata"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "DisplayName" = ${DisplayName}
            "Mail" = ${Mail}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactDisplayName" = ${PrimaryContactDisplayName}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactDisplayName" = ${SecondaryContactDisplayName}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "ProfileName" = ${ProfileName}
            "NextRenewalDate" = ${NextRenewalDate}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }

}

