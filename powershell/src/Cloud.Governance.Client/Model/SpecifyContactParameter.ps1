#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SpecifyContactParameter<PSCustomObject>
#>

function New-SpecifyContactParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContactNotifiedEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContactNotifiedEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Workspace}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SpecifyContactParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "PrimaryContactNotifiedEmail" = ${PrimaryContactNotifiedEmail}
            "SecondaryContactNotifiedEmail" = ${SecondaryContactNotifiedEmail}
            "Workspace" = ${Workspace}
        }

        return $PSO
    }
}

<#
SpecifyContactParameter<PSCustomObject>
#>
function ConvertFrom-JsonToSpecifyContactParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SpecifyContactParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SpecifyContactParameter
        $AllProperties = $("PrimaryContact", "SecondaryContact", "PrimaryContactNotifiedEmail", "SecondaryContactNotifiedEmail", "Workspace")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContactNotifiedEmail"))) { #optional property not found
            $PrimaryContactNotifiedEmail = $null
        } else {
            $PrimaryContactNotifiedEmail = $JsonParameters.PSobject.Properties["PrimaryContactNotifiedEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactNotifiedEmail"))) { #optional property not found
            $SecondaryContactNotifiedEmail = $null
        } else {
            $SecondaryContactNotifiedEmail = $JsonParameters.PSobject.Properties["SecondaryContactNotifiedEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Workspace"))) { #optional property not found
            $Workspace = $null
        } else {
            $Workspace = $JsonParameters.PSobject.Properties["Workspace"].value
        }

        $PSO = [PSCustomObject]@{
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "PrimaryContactNotifiedEmail" = ${PrimaryContactNotifiedEmail}
            "SecondaryContactNotifiedEmail" = ${SecondaryContactNotifiedEmail}
            "Workspace" = ${Workspace}
        }

        return $PSO
    }

}

