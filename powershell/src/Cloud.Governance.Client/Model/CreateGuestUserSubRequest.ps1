#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateGuestUserSubRequest<PSCustomObject>
#>

function New-CreateGuestUserSubRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserProperties},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WelcomeEmailMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${InviteGroups},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OneTimeSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AssignTo}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CreateGuestUserSubRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "UserProperties" = ${UserProperties}
            "WelcomeEmailMessage" = ${WelcomeEmailMessage}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "InviteGroups" = ${InviteGroups}
            "OneTimeSettings" = ${OneTimeSettings}
            "Metadatas" = ${Metadatas}
            "AssignTo" = ${AssignTo}
        }

        return $PSO
    }
}

<#
CreateGuestUserSubRequest<PSCustomObject>
#>
function ConvertFrom-JsonToCreateGuestUserSubRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateGuestUserSubRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateGuestUserSubRequest
        $AllProperties = $("Id", "UserProperties", "WelcomeEmailMessage", "PrimaryContact", "SecondaryContact", "InviteGroups", "OneTimeSettings", "Metadatas", "ProcessStatus", "AssignTo")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserProperties"))) { #optional property not found
            $UserProperties = $null
        } else {
            $UserProperties = $JsonParameters.PSobject.Properties["UserProperties"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WelcomeEmailMessage"))) { #optional property not found
            $WelcomeEmailMessage = $null
        } else {
            $WelcomeEmailMessage = $JsonParameters.PSobject.Properties["WelcomeEmailMessage"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InviteGroups"))) { #optional property not found
            $InviteGroups = $null
        } else {
            $InviteGroups = $JsonParameters.PSobject.Properties["InviteGroups"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OneTimeSettings"))) { #optional property not found
            $OneTimeSettings = $null
        } else {
            $OneTimeSettings = $JsonParameters.PSobject.Properties["OneTimeSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProcessStatus"))) { #optional property not found
            $ProcessStatus = $null
        } else {
            $ProcessStatus = $JsonParameters.PSobject.Properties["ProcessStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignTo"))) { #optional property not found
            $AssignTo = $null
        } else {
            $AssignTo = $JsonParameters.PSobject.Properties["AssignTo"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "UserProperties" = ${UserProperties}
            "WelcomeEmailMessage" = ${WelcomeEmailMessage}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "InviteGroups" = ${InviteGroups}
            "OneTimeSettings" = ${OneTimeSettings}
            "Metadatas" = ${Metadatas}
            "ProcessStatus" = ${ProcessStatus}
            "AssignTo" = ${AssignTo}
        }

        return $PSO
    }

}

