#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CopyMoveSettingAssignBy<PSCustomObject>
#>

function New-CopyMoveSettingAssignBy {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ConfigurationAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecurityAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ContentAssignBy}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CopyMoveSettingAssignBy' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ConfigurationAssignBy" = ${ConfigurationAssignBy}
            "SecurityAssignBy" = ${SecurityAssignBy}
            "ContentAssignBy" = ${ContentAssignBy}
        }

        return $PSO
    }
}

<#
CopyMoveSettingAssignBy<PSCustomObject>
#>
function ConvertFrom-JsonToCopyMoveSettingAssignBy {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CopyMoveSettingAssignBy' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CopyMoveSettingAssignBy
        $AllProperties = $("ConfigurationAssignBy", "SecurityAssignBy", "ContentAssignBy")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConfigurationAssignBy"))) { #optional property not found
            $ConfigurationAssignBy = $null
        } else {
            $ConfigurationAssignBy = $JsonParameters.PSobject.Properties["ConfigurationAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecurityAssignBy"))) { #optional property not found
            $SecurityAssignBy = $null
        } else {
            $SecurityAssignBy = $JsonParameters.PSobject.Properties["SecurityAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ContentAssignBy"))) { #optional property not found
            $ContentAssignBy = $null
        } else {
            $ContentAssignBy = $JsonParameters.PSobject.Properties["ContentAssignBy"].value
        }

        $PSO = [PSCustomObject]@{
            "ConfigurationAssignBy" = ${ConfigurationAssignBy}
            "SecurityAssignBy" = ${SecurityAssignBy}
            "ContentAssignBy" = ${ContentAssignBy}
        }

        return $PSO
    }

}

