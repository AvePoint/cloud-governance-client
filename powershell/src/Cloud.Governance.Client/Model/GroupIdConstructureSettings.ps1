#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GroupIdConstructureSettings<PSCustomObject>
#>

function New-GroupIdConstructureSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RuleType} = "ConstructGroupId",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAutoSequenceNumber} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AutoSequenceNumber},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Prefixs},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Suffixs}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GroupIdConstructureSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "RuleType" = ${RuleType}
            "EnableAutoSequenceNumber" = ${EnableAutoSequenceNumber}
            "AutoSequenceNumber" = ${AutoSequenceNumber}
            "Enabled" = ${Enabled}
            "AssignBy" = ${AssignBy}
            "Prefixs" = ${Prefixs}
            "Suffixs" = ${Suffixs}
        }

        return $PSO
    }
}

<#
GroupIdConstructureSettings<PSCustomObject>
#>
function ConvertFrom-JsonToGroupIdConstructureSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GroupIdConstructureSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GroupIdConstructureSettings
        $AllProperties = $("RuleType", "EnableAutoSequenceNumber", "AutoSequenceNumber", "Enabled", "AssignBy", "Prefixs", "Suffixs")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RuleType"))) { #optional property not found
            $RuleType = $null
        } else {
            $RuleType = $JsonParameters.PSobject.Properties["RuleType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAutoSequenceNumber"))) { #optional property not found
            $EnableAutoSequenceNumber = $null
        } else {
            $EnableAutoSequenceNumber = $JsonParameters.PSobject.Properties["EnableAutoSequenceNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoSequenceNumber"))) { #optional property not found
            $AutoSequenceNumber = $null
        } else {
            $AutoSequenceNumber = $JsonParameters.PSobject.Properties["AutoSequenceNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignBy"))) { #optional property not found
            $AssignBy = $null
        } else {
            $AssignBy = $JsonParameters.PSobject.Properties["AssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Prefixs"))) { #optional property not found
            $Prefixs = $null
        } else {
            $Prefixs = $JsonParameters.PSobject.Properties["Prefixs"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Suffixs"))) { #optional property not found
            $Suffixs = $null
        } else {
            $Suffixs = $JsonParameters.PSobject.Properties["Suffixs"].value
        }

        $PSO = [PSCustomObject]@{
            "RuleType" = ${RuleType}
            "EnableAutoSequenceNumber" = ${EnableAutoSequenceNumber}
            "AutoSequenceNumber" = ${AutoSequenceNumber}
            "Enabled" = ${Enabled}
            "AssignBy" = ${AssignBy}
            "Prefixs" = ${Prefixs}
            "Suffixs" = ${Suffixs}
        }

        return $PSO
    }

}

