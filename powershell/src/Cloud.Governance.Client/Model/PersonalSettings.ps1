#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
PersonalSettings<PSCustomObject>
#>

function New-PersonalSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${UserID} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageID} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TimeZoneID} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAdjustDaylight} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Properties}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => PersonalSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "UserID" = ${UserID}
            "LanguageID" = ${LanguageID}
            "TimeZoneID" = ${TimeZoneID}
            "IsAdjustDaylight" = ${IsAdjustDaylight}
            "Properties" = ${Properties}
        }

        return $PSO
    }
}

<#
PersonalSettings<PSCustomObject>
#>
function ConvertFrom-JsonToPersonalSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => PersonalSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in PersonalSettings
        $AllProperties = $("Id", "UserID", "LanguageID", "TimeZoneID", "IsAdjustDaylight", "Properties")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserID"))) { #optional property not found
            $UserID = $null
        } else {
            $UserID = $JsonParameters.PSobject.Properties["UserID"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageID"))) { #optional property not found
            $LanguageID = $null
        } else {
            $LanguageID = $JsonParameters.PSobject.Properties["LanguageID"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TimeZoneID"))) { #optional property not found
            $TimeZoneID = $null
        } else {
            $TimeZoneID = $JsonParameters.PSobject.Properties["TimeZoneID"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsAdjustDaylight"))) { #optional property not found
            $IsAdjustDaylight = $null
        } else {
            $IsAdjustDaylight = $JsonParameters.PSobject.Properties["IsAdjustDaylight"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Properties"))) { #optional property not found
            $Properties = $null
        } else {
            $Properties = $JsonParameters.PSobject.Properties["Properties"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "UserID" = ${UserID}
            "LanguageID" = ${LanguageID}
            "TimeZoneID" = ${TimeZoneID}
            "IsAdjustDaylight" = ${IsAdjustDaylight}
            "Properties" = ${Properties}
        }

        return $PSO
    }

}

