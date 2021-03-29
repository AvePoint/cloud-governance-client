#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ExtendGroupResult<PSCustomObject>
#>

function New-ExtendGroupResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtendType} = "WithConstantValue",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Duration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DurationType} = "Day"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ExtendGroupResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ExtendType" = ${ExtendType}
            "Duration" = ${Duration}
            "DurationType" = ${DurationType}
        }

        return $PSO
    }
}

<#
ExtendGroupResult<PSCustomObject>
#>
function ConvertFrom-JsonToExtendGroupResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ExtendGroupResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ExtendGroupResult
        $AllProperties = $("ExtendType", "Duration", "DurationType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExtendType"))) { #optional property not found
            $ExtendType = $null
        } else {
            $ExtendType = $JsonParameters.PSobject.Properties["ExtendType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Duration"))) { #optional property not found
            $Duration = $null
        } else {
            $Duration = $JsonParameters.PSobject.Properties["Duration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DurationType"))) { #optional property not found
            $DurationType = $null
        } else {
            $DurationType = $JsonParameters.PSobject.Properties["DurationType"].value
        }

        $PSO = [PSCustomObject]@{
            "ExtendType" = ${ExtendType}
            "Duration" = ${Duration}
            "DurationType" = ${DurationType}
        }

        return $PSO
    }

}

