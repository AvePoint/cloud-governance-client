#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeMetadataActionSetting<PSCustomObject>
#>

function New-ChangeMetadataActionSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddOrDelete},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeMetadataActionSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "EnableAddOrDelete" = ${EnableAddOrDelete}
            "Metadatas" = ${Metadatas}
        }

        return $PSO
    }
}

<#
ChangeMetadataActionSetting<PSCustomObject>
#>
function ConvertFrom-JsonToChangeMetadataActionSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeMetadataActionSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeMetadataActionSetting
        $AllProperties = $("IsEnabled", "EnableAddOrDelete", "Metadatas")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnabled"))) { #optional property not found
            $IsEnabled = $null
        } else {
            $IsEnabled = $JsonParameters.PSobject.Properties["IsEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAddOrDelete"))) { #optional property not found
            $EnableAddOrDelete = $null
        } else {
            $EnableAddOrDelete = $JsonParameters.PSobject.Properties["EnableAddOrDelete"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "EnableAddOrDelete" = ${EnableAddOrDelete}
            "Metadatas" = ${Metadatas}
        }

        return $PSO
    }

}

