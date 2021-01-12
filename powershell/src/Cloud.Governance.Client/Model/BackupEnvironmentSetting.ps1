#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
BackupEnvironmentSetting<PSCustomObject>
#>

function New-BackupEnvironmentSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsBackupSource},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsBackupDestination},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${StoragePolicy}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => BackupEnvironmentSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsBackupSource" = ${IsBackupSource}
            "IsBackupDestination" = ${IsBackupDestination}
            "StoragePolicy" = ${StoragePolicy}
        }

        return $PSO
    }
}

<#
BackupEnvironmentSetting<PSCustomObject>
#>
function ConvertFrom-JsonToBackupEnvironmentSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => BackupEnvironmentSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in BackupEnvironmentSetting
        $AllProperties = $("IsBackupSource", "IsBackupDestination", "StoragePolicy")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsBackupSource"))) { #optional property not found
            $IsBackupSource = $null
        } else {
            $IsBackupSource = $JsonParameters.PSobject.Properties["IsBackupSource"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsBackupDestination"))) { #optional property not found
            $IsBackupDestination = $null
        } else {
            $IsBackupDestination = $JsonParameters.PSobject.Properties["IsBackupDestination"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StoragePolicy"))) { #optional property not found
            $StoragePolicy = $null
        } else {
            $StoragePolicy = $JsonParameters.PSobject.Properties["StoragePolicy"].value
        }

        $PSO = [PSCustomObject]@{
            "IsBackupSource" = ${IsBackupSource}
            "IsBackupDestination" = ${IsBackupDestination}
            "StoragePolicy" = ${StoragePolicy}
        }

        return $PSO
    }

}

