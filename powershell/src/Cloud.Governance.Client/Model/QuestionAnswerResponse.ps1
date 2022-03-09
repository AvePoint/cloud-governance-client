#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
QuestionAnswerResponse<PSCustomObject>
#>

function New-QuestionAnswerResponse {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Question},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Value}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => QuestionAnswerResponse' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Question" = ${Question}
            "Value" = ${Value}
        }

        return $PSO
    }
}

<#
QuestionAnswerResponse<PSCustomObject>
#>
function ConvertFrom-JsonToQuestionAnswerResponse {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => QuestionAnswerResponse' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in QuestionAnswerResponse
        $AllProperties = $("Question", "Value")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Question"))) { #optional property not found
            $Question = $null
        } else {
            $Question = $JsonParameters.PSobject.Properties["Question"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        $PSO = [PSCustomObject]@{
            "Question" = ${Question}
            "Value" = ${Value}
        }

        return $PSO
    }

}

