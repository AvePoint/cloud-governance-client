#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ContentMoveUrlValidationParameter<PSCustomObject>
#>

function New-ContentMoveUrlValidationParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsCheckSourceUrl} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Uri},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IgnoreLock} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEditTask} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsFromQuestionnaire} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ContentMoveUrlValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsCheckSourceUrl" = ${IsCheckSourceUrl}
            "Uri" = ${Uri}
            "IgnoreLock" = ${IgnoreLock}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }
}

<#
ContentMoveUrlValidationParameter<PSCustomObject>
#>
function ConvertFrom-JsonToContentMoveUrlValidationParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ContentMoveUrlValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ContentMoveUrlValidationParameter
        $AllProperties = $("IsCheckSourceUrl", "Uri", "IgnoreLock", "IsEditTask", "IsFromQuestionnaire")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsCheckSourceUrl"))) { #optional property not found
            $IsCheckSourceUrl = $null
        } else {
            $IsCheckSourceUrl = $JsonParameters.PSobject.Properties["IsCheckSourceUrl"].value
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
            "IsCheckSourceUrl" = ${IsCheckSourceUrl}
            "Uri" = ${Uri}
            "IgnoreLock" = ${IgnoreLock}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }

}

