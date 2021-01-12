#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ListValidationParameter<PSCustomObject>
#>

function New-ListValidationParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ListUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ListTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDocumentLibrary},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEditTask},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsFromQuestionnaire}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ListValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ListUrl" = ${ListUrl}
            "ParentUrl" = ${ParentUrl}
            "ListTitle" = ${ListTitle}
            "IsDocumentLibrary" = ${IsDocumentLibrary}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }
}

<#
ListValidationParameter<PSCustomObject>
#>
function ConvertFrom-JsonToListValidationParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ListValidationParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ListValidationParameter
        $AllProperties = $("ListUrl", "ParentUrl", "ListTitle", "IsDocumentLibrary", "IsEditTask", "IsFromQuestionnaire")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListUrl"))) { #optional property not found
            $ListUrl = $null
        } else {
            $ListUrl = $JsonParameters.PSobject.Properties["ListUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentUrl"))) { #optional property not found
            $ParentUrl = $null
        } else {
            $ParentUrl = $JsonParameters.PSobject.Properties["ParentUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListTitle"))) { #optional property not found
            $ListTitle = $null
        } else {
            $ListTitle = $JsonParameters.PSobject.Properties["ListTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsDocumentLibrary"))) { #optional property not found
            $IsDocumentLibrary = $null
        } else {
            $IsDocumentLibrary = $JsonParameters.PSobject.Properties["IsDocumentLibrary"].value
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
            "ListUrl" = ${ListUrl}
            "ParentUrl" = ${ParentUrl}
            "ListTitle" = ${ListTitle}
            "IsDocumentLibrary" = ${IsDocumentLibrary}
            "IsEditTask" = ${IsEditTask}
            "IsFromQuestionnaire" = ${IsFromQuestionnaire}
        }

        return $PSO
    }

}

