#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateWebValidationParameter<PSCustomObject>
#>

function New-CreateWebValidationParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentUrl},
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
        'Creating PSCustomObject: Cloud.Governance.Client => CreateWebValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ParentUrl" = ${ParentUrl}
            "Uri" = ${Uri}
            "IgnoreLock" = ${IgnoreLock}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }
}

<#
CreateWebValidationParameter<PSCustomObject>
#>
function ConvertFrom-JsonToCreateWebValidationParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateWebValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateWebValidationParameter
        $AllProperties = $("ParentUrl", "Uri", "IgnoreLock", "IsEditTask", "IsFromQuestionnaire")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentUrl"))) { #optional property not found
            $ParentUrl = $null
        } else {
            $ParentUrl = $JsonParameters.PSobject.Properties["ParentUrl"].value
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
            "ParentUrl" = ${ParentUrl}
            "Uri" = ${Uri}
            "IgnoreLock" = ${IgnoreLock}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }

}

