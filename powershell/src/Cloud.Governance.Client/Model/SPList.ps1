#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SPList<PSCustomObject>
#>

function New-SPList {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Url},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsLibrary} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOnQuickLaunch} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableModeration} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableVersioning} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableMinorVersion} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MajorVersionLimit} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MajorWithMinorVersionsLimit} = 0
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SPList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Url" = ${Url}
            "Description" = ${Description}
            "IsLibrary" = ${IsLibrary}
            "IsOnQuickLaunch" = ${IsOnQuickLaunch}
            "IsEnableModeration" = ${IsEnableModeration}
            "IsEnableVersioning" = ${IsEnableVersioning}
            "IsEnableMinorVersion" = ${IsEnableMinorVersion}
            "MajorVersionLimit" = ${MajorVersionLimit}
            "MajorWithMinorVersionsLimit" = ${MajorWithMinorVersionsLimit}
        }

        return $PSO
    }
}

<#
SPList<PSCustomObject>
#>
function ConvertFrom-JsonToSPList {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SPList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SPList
        $AllProperties = $("Id", "Title", "Url", "Description", "IsLibrary", "IsOnQuickLaunch", "IsEnableModeration", "IsEnableVersioning", "IsEnableMinorVersion", "MajorVersionLimit", "MajorWithMinorVersionsLimit")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Url"))) { #optional property not found
            $Url = $null
        } else {
            $Url = $JsonParameters.PSobject.Properties["Url"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsLibrary"))) { #optional property not found
            $IsLibrary = $null
        } else {
            $IsLibrary = $JsonParameters.PSobject.Properties["IsLibrary"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsOnQuickLaunch"))) { #optional property not found
            $IsOnQuickLaunch = $null
        } else {
            $IsOnQuickLaunch = $JsonParameters.PSobject.Properties["IsOnQuickLaunch"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableModeration"))) { #optional property not found
            $IsEnableModeration = $null
        } else {
            $IsEnableModeration = $JsonParameters.PSobject.Properties["IsEnableModeration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableVersioning"))) { #optional property not found
            $IsEnableVersioning = $null
        } else {
            $IsEnableVersioning = $JsonParameters.PSobject.Properties["IsEnableVersioning"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableMinorVersion"))) { #optional property not found
            $IsEnableMinorVersion = $null
        } else {
            $IsEnableMinorVersion = $JsonParameters.PSobject.Properties["IsEnableMinorVersion"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MajorVersionLimit"))) { #optional property not found
            $MajorVersionLimit = $null
        } else {
            $MajorVersionLimit = $JsonParameters.PSobject.Properties["MajorVersionLimit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MajorWithMinorVersionsLimit"))) { #optional property not found
            $MajorWithMinorVersionsLimit = $null
        } else {
            $MajorWithMinorVersionsLimit = $JsonParameters.PSobject.Properties["MajorWithMinorVersionsLimit"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Url" = ${Url}
            "Description" = ${Description}
            "IsLibrary" = ${IsLibrary}
            "IsOnQuickLaunch" = ${IsOnQuickLaunch}
            "IsEnableModeration" = ${IsEnableModeration}
            "IsEnableVersioning" = ${IsEnableVersioning}
            "IsEnableMinorVersion" = ${IsEnableMinorVersion}
            "MajorVersionLimit" = ${MajorVersionLimit}
            "MajorWithMinorVersionsLimit" = ${MajorWithMinorVersionsLimit}
        }

        return $PSO
    }

}

