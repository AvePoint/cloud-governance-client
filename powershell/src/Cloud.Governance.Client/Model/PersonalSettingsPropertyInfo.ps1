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
        [Int32[]]
        ${SelectedLanguages},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsUsingBrowserLanguage} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ThemeCode},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabledInTeamsApp} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => PersonalSettingsPropertyInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SelectedLanguages" = ${SelectedLanguages}
            "IsUsingBrowserLanguage" = ${IsUsingBrowserLanguage}
            "ThemeCode" = ${ThemeCode}
            "IsEnabledInTeamsApp" = ${IsEnabledInTeamsApp}
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
        $AllProperties = $("SelectedLanguages", "IsUsingBrowserLanguage", "ThemeCode", "ThemeType", "IsEnabledInTeamsApp")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ThemeCode"))) { #optional property not found
            $ThemeCode = $null
        } else {
            $ThemeCode = $JsonParameters.PSobject.Properties["ThemeCode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ThemeType"))) { #optional property not found
            $ThemeType = $null
        } else {
            $ThemeType = $JsonParameters.PSobject.Properties["ThemeType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnabledInTeamsApp"))) { #optional property not found
            $IsEnabledInTeamsApp = $null
        } else {
            $IsEnabledInTeamsApp = $JsonParameters.PSobject.Properties["IsEnabledInTeamsApp"].value
        }

        $PSO = [PSCustomObject]@{
            "SelectedLanguages" = ${SelectedLanguages}
            "IsUsingBrowserLanguage" = ${IsUsingBrowserLanguage}
            "ThemeCode" = ${ThemeCode}
            "ThemeType" = ${ThemeType}
            "IsEnabledInTeamsApp" = ${IsEnabledInTeamsApp}
        }

        return $PSO
    }

}

