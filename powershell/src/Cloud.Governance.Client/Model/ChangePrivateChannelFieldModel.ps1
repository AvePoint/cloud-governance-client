#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangePrivateChannelFieldModel<PSCustomObject>
#>

function New-ChangePrivateChannelFieldModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangePrivateChannelFieldName} = "Name",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangePrivateChannelFieldModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ChangePrivateChannelFieldName" = ${ChangePrivateChannelFieldName}
            "IsEnabled" = ${IsEnabled}
        }

        return $PSO
    }
}

<#
ChangePrivateChannelFieldModel<PSCustomObject>
#>
function ConvertFrom-JsonToChangePrivateChannelFieldModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangePrivateChannelFieldModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangePrivateChannelFieldModel
        $AllProperties = $("ChangePrivateChannelFieldName", "IsEnabled")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangePrivateChannelFieldName"))) { #optional property not found
            $ChangePrivateChannelFieldName = $null
        } else {
            $ChangePrivateChannelFieldName = $JsonParameters.PSobject.Properties["ChangePrivateChannelFieldName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnabled"))) { #optional property not found
            $IsEnabled = $null
        } else {
            $IsEnabled = $JsonParameters.PSobject.Properties["IsEnabled"].value
        }

        $PSO = [PSCustomObject]@{
            "ChangePrivateChannelFieldName" = ${ChangePrivateChannelFieldName}
            "IsEnabled" = ${IsEnabled}
        }

        return $PSO
    }

}

