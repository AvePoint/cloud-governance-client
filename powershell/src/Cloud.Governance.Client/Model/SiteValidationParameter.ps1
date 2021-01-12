#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SiteValidationParameter<PSCustomObject>
#>

function New-SiteValidationParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Uri},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IgnoreLock},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEditTask},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsFromQuestionnaire}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SiteValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Uri" = ${Uri}
            "IgnoreLock" = ${IgnoreLock}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }
}

<#
SiteValidationParameter<PSCustomObject>
#>
function ConvertFrom-JsonToSiteValidationParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SiteValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SiteValidationParameter
        $AllProperties = $("Uri", "IgnoreLock", "IsEditTask", "IsFromQuestionnaire")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Uri"))) { #optional property not found
            $Uri = $null
        } else {
            $Uri = $JsonParameters.PSobject.Properties["Uri"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IgnoreLock"))) { #optional property not found
            $IgnoreLock = $null
        } else {
            $IgnoreLock = $JsonParameters.PSobject.Properties["IgnoreLock"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEditTask"))) { #optional property not found
            $IsEditTask = $null
        } else {
            $IsEditTask = $JsonParameters.PSobject.Properties["IsEditTask"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsFromQuestionnaire"))) { #optional property not found
            $IsFromQuestionnaire = $null
        } else {
            $IsFromQuestionnaire = $JsonParameters.PSobject.Properties["IsFromQuestionnaire"].value
        }

        $PSO = [PSCustomObject]@{
            "Uri" = ${Uri}
            "IgnoreLock" = ${IgnoreLock}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }

}

