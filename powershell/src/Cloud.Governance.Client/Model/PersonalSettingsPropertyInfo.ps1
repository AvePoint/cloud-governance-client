#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
PersonalSettingsPropertyInfo<PSCustomObject>
#>

function New-PersonalSettingsPropertyInfo {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Theme} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [Int32[]]
        ${SelectedLanguages},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsUsingBrowserLanguage} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => PersonalSettingsPropertyInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Theme" = ${Theme}
            "SelectedLanguages" = ${SelectedLanguages}
            "IsUsingBrowserLanguage" = ${IsUsingBrowserLanguage}
        }

        return $PSO
    }
}

<#
PersonalSettingsPropertyInfo<PSCustomObject>
#>
function ConvertFrom-JsonToPersonalSettingsPropertyInfo {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => PersonalSettingsPropertyInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in PersonalSettingsPropertyInfo
        $AllProperties = $("Theme", "SelectedLanguages", "IsUsingBrowserLanguage")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Theme"))) { #optional property not found
            $Theme = $null
        } else {
            $Theme = $JsonParameters.PSobject.Properties["Theme"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedLanguages"))) { #optional property not found
            $SelectedLanguages = $null
        } else {
            $SelectedLanguages = $JsonParameters.PSobject.Properties["SelectedLanguages"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsUsingBrowserLanguage"))) { #optional property not found
            $IsUsingBrowserLanguage = $null
        } else {
            $IsUsingBrowserLanguage = $JsonParameters.PSobject.Properties["IsUsingBrowserLanguage"].value
        }

        $PSO = [PSCustomObject]@{
            "Theme" = ${Theme}
            "SelectedLanguages" = ${SelectedLanguages}
            "IsUsingBrowserLanguage" = ${IsUsingBrowserLanguage}
        }

        return $PSO
    }

}

