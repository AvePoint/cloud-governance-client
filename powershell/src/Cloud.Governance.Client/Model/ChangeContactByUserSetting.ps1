#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeContactByUserSetting<PSCustomObject>
#>

function New-ChangeContactByUserSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CurrentUser},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NewUser},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AlternativeUser}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeContactByUserSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "CurrentUser" = ${CurrentUser}
            "NewUser" = ${NewUser}
            "AlternativeUser" = ${AlternativeUser}
        }

        return $PSO
    }
}

<#
ChangeContactByUserSetting<PSCustomObject>
#>
function ConvertFrom-JsonToChangeContactByUserSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeContactByUserSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeContactByUserSetting
        $AllProperties = $("CurrentUser", "NewUser", "AlternativeUser")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CurrentUser"))) { #optional property not found
            $CurrentUser = $null
        } else {
            $CurrentUser = $JsonParameters.PSobject.Properties["CurrentUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NewUser"))) { #optional property not found
            $NewUser = $null
        } else {
            $NewUser = $JsonParameters.PSobject.Properties["NewUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AlternativeUser"))) { #optional property not found
            $AlternativeUser = $null
        } else {
            $AlternativeUser = $JsonParameters.PSobject.Properties["AlternativeUser"].value
        }

        $PSO = [PSCustomObject]@{
            "CurrentUser" = ${CurrentUser}
            "NewUser" = ${NewUser}
            "AlternativeUser" = ${AlternativeUser}
        }

        return $PSO
    }

}

