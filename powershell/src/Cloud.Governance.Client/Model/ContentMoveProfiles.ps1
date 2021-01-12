#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ContentMoveProfiles<PSCustomObject>
#>

function New-ContentMoveProfiles {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${BackupEnvironmentStoragePolices},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ColumnMappings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ContentTypeMappings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${UserMappings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${LanguageMappings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${FilterPolices}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ContentMoveProfiles' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "BackupEnvironmentStoragePolices" = ${BackupEnvironmentStoragePolices}
            "ColumnMappings" = ${ColumnMappings}
            "ContentTypeMappings" = ${ContentTypeMappings}
            "UserMappings" = ${UserMappings}
            "LanguageMappings" = ${LanguageMappings}
            "FilterPolices" = ${FilterPolices}
        }

        return $PSO
    }
}

<#
ContentMoveProfiles<PSCustomObject>
#>
function ConvertFrom-JsonToContentMoveProfiles {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ContentMoveProfiles' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ContentMoveProfiles
        $AllProperties = $("BackupEnvironmentStoragePolices", "ColumnMappings", "ContentTypeMappings", "UserMappings", "LanguageMappings", "FilterPolices")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BackupEnvironmentStoragePolices"))) { #optional property not found
            $BackupEnvironmentStoragePolices = $null
        } else {
            $BackupEnvironmentStoragePolices = $JsonParameters.PSobject.Properties["BackupEnvironmentStoragePolices"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ColumnMappings"))) { #optional property not found
            $ColumnMappings = $null
        } else {
            $ColumnMappings = $JsonParameters.PSobject.Properties["ColumnMappings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ContentTypeMappings"))) { #optional property not found
            $ContentTypeMappings = $null
        } else {
            $ContentTypeMappings = $JsonParameters.PSobject.Properties["ContentTypeMappings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserMappings"))) { #optional property not found
            $UserMappings = $null
        } else {
            $UserMappings = $JsonParameters.PSobject.Properties["UserMappings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageMappings"))) { #optional property not found
            $LanguageMappings = $null
        } else {
            $LanguageMappings = $JsonParameters.PSobject.Properties["LanguageMappings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FilterPolices"))) { #optional property not found
            $FilterPolices = $null
        } else {
            $FilterPolices = $JsonParameters.PSobject.Properties["FilterPolices"].value
        }

        $PSO = [PSCustomObject]@{
            "BackupEnvironmentStoragePolices" = ${BackupEnvironmentStoragePolices}
            "ColumnMappings" = ${ColumnMappings}
            "ContentTypeMappings" = ${ContentTypeMappings}
            "UserMappings" = ${UserMappings}
            "LanguageMappings" = ${LanguageMappings}
            "FilterPolices" = ${FilterPolices}
        }

        return $PSO
    }

}

