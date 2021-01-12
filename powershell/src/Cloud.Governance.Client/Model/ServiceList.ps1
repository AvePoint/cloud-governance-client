#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ServiceList<PSCustomObject>
#>

function New-ServiceList {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Category},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Contact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsQuestionnaire},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${QuestionnaireId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ServiceList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Category" = ${Category}
            "Contact" = ${Contact}
            "LanguageId" = ${LanguageId}
            "Type" = ${Type}
            "TypeDescription" = ${TypeDescription}
            "IsQuestionnaire" = ${IsQuestionnaire}
            "QuestionnaireId" = ${QuestionnaireId}
        }

        return $PSO
    }
}

<#
ServiceList<PSCustomObject>
#>
function ConvertFrom-JsonToServiceList {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ServiceList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ServiceList
        $AllProperties = $("Id", "Name", "Description", "Category", "Contact", "LanguageId", "Type", "TypeDescription", "IsQuestionnaire", "QuestionnaireId")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Category"))) { #optional property not found
            $Category = $null
        } else {
            $Category = $JsonParameters.PSobject.Properties["Category"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Contact"))) { #optional property not found
            $Contact = $null
        } else {
            $Contact = $JsonParameters.PSobject.Properties["Contact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageId"))) { #optional property not found
            $LanguageId = $null
        } else {
            $LanguageId = $JsonParameters.PSobject.Properties["LanguageId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TypeDescription"))) { #optional property not found
            $TypeDescription = $null
        } else {
            $TypeDescription = $JsonParameters.PSobject.Properties["TypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsQuestionnaire"))) { #optional property not found
            $IsQuestionnaire = $null
        } else {
            $IsQuestionnaire = $JsonParameters.PSobject.Properties["IsQuestionnaire"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "QuestionnaireId"))) { #optional property not found
            $QuestionnaireId = $null
        } else {
            $QuestionnaireId = $JsonParameters.PSobject.Properties["QuestionnaireId"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Category" = ${Category}
            "Contact" = ${Contact}
            "LanguageId" = ${LanguageId}
            "Type" = ${Type}
            "TypeDescription" = ${TypeDescription}
            "IsQuestionnaire" = ${IsQuestionnaire}
            "QuestionnaireId" = ${QuestionnaireId}
        }

        return $PSO
    }

}

