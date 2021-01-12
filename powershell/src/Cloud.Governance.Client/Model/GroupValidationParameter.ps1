#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GroupValidationParameter<PSCustomObject>
#>

function New-GroupValidationParameter {
    [CmdletBinding()]
    Param (
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
        'Creating PSCustomObject: Cloud.Governance.Client => GroupValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "GroupId" = ${GroupId}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }
}

<#
GroupValidationParameter<PSCustomObject>
#>
function ConvertFrom-JsonToGroupValidationParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GroupValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GroupValidationParameter
        $AllProperties = $("GroupId", "IsEditTask", "IsFromQuestionnaire")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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
            "GroupId" = ${GroupId}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }

}

