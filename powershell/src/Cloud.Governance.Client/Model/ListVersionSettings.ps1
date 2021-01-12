#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ListVersionSettings<PSCustomObject>
#>

function New-ListVersionSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ListType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableMajorVersions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableMajorAndMinorVersions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableMajorVersionLimit},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MajorVersionLimit},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableMinorVersionLimit},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MinorVersionsLimit},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${RequireContentApproval}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ListVersionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ListType" = ${ListType}
            "EnableMajorVersions" = ${EnableMajorVersions}
            "EnableMajorAndMinorVersions" = ${EnableMajorAndMinorVersions}
            "EnableMajorVersionLimit" = ${EnableMajorVersionLimit}
            "MajorVersionLimit" = ${MajorVersionLimit}
            "EnableMinorVersionLimit" = ${EnableMinorVersionLimit}
            "MinorVersionsLimit" = ${MinorVersionsLimit}
            "RequireContentApproval" = ${RequireContentApproval}
        }

        return $PSO
    }
}

<#
ListVersionSettings<PSCustomObject>
#>
function ConvertFrom-JsonToListVersionSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ListVersionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ListVersionSettings
        $AllProperties = $("ListType", "EnableMajorVersions", "EnableMajorAndMinorVersions", "EnableMajorVersionLimit", "MajorVersionLimit", "EnableMinorVersionLimit", "MinorVersionsLimit", "RequireContentApproval")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListType"))) { #optional property not found
            $ListType = $null
        } else {
            $ListType = $JsonParameters.PSobject.Properties["ListType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableMajorVersions"))) { #optional property not found
            $EnableMajorVersions = $null
        } else {
            $EnableMajorVersions = $JsonParameters.PSobject.Properties["EnableMajorVersions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableMajorAndMinorVersions"))) { #optional property not found
            $EnableMajorAndMinorVersions = $null
        } else {
            $EnableMajorAndMinorVersions = $JsonParameters.PSobject.Properties["EnableMajorAndMinorVersions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableMajorVersionLimit"))) { #optional property not found
            $EnableMajorVersionLimit = $null
        } else {
            $EnableMajorVersionLimit = $JsonParameters.PSobject.Properties["EnableMajorVersionLimit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MajorVersionLimit"))) { #optional property not found
            $MajorVersionLimit = $null
        } else {
            $MajorVersionLimit = $JsonParameters.PSobject.Properties["MajorVersionLimit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableMinorVersionLimit"))) { #optional property not found
            $EnableMinorVersionLimit = $null
        } else {
            $EnableMinorVersionLimit = $JsonParameters.PSobject.Properties["EnableMinorVersionLimit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MinorVersionsLimit"))) { #optional property not found
            $MinorVersionsLimit = $null
        } else {
            $MinorVersionsLimit = $JsonParameters.PSobject.Properties["MinorVersionsLimit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequireContentApproval"))) { #optional property not found
            $RequireContentApproval = $null
        } else {
            $RequireContentApproval = $JsonParameters.PSobject.Properties["RequireContentApproval"].value
        }

        $PSO = [PSCustomObject]@{
            "ListType" = ${ListType}
            "EnableMajorVersions" = ${EnableMajorVersions}
            "EnableMajorAndMinorVersions" = ${EnableMajorAndMinorVersions}
            "EnableMajorVersionLimit" = ${EnableMajorVersionLimit}
            "MajorVersionLimit" = ${MajorVersionLimit}
            "EnableMinorVersionLimit" = ${EnableMinorVersionLimit}
            "MinorVersionsLimit" = ${MinorVersionsLimit}
            "RequireContentApproval" = ${RequireContentApproval}
        }

        return $PSO
    }

}

