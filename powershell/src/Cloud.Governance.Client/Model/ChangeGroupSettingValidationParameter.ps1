#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeGroupSettingValidationParameter<PSCustomObject>
#>

function New-ChangeGroupSettingValidationParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEditTask},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsFromQuestionnaire}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeGroupSettingValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "GroupEmail" = ${GroupEmail}
            "GroupId" = ${GroupId}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }
}

<#
ChangeGroupSettingValidationParameter<PSCustomObject>
#>
function ConvertFrom-JsonToChangeGroupSettingValidationParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeGroupSettingValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeGroupSettingValidationParameter
        $AllProperties = $("GroupEmail", "GroupId", "IsEditTask", "IsFromQuestionnaire")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupEmail"))) { #optional property not found
            $GroupEmail = $null
        } else {
            $GroupEmail = $JsonParameters.PSobject.Properties["GroupEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupId"))) { #optional property not found
            $GroupId = $null
        } else {
            $GroupId = $JsonParameters.PSobject.Properties["GroupId"].value
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
            "GroupEmail" = ${GroupEmail}
            "GroupId" = ${GroupId}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }

}

