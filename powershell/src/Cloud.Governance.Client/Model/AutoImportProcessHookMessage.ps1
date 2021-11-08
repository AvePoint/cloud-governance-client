#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
AutoImportProcessHookMessage<PSCustomObject>
#>

function New-AutoImportProcessHookMessage {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AutoImportProfileName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TaskLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ObjectTypeEnum} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TriggerType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${TriggerTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Summary}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => AutoImportProcessHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AutoImportProfileName" = ${AutoImportProfileName}
            "TaskLink" = ${TaskLink}
            "ObjectTitle" = ${ObjectTitle}
            "ObjectType" = ${ObjectType}
            "ObjectTypeEnum" = ${ObjectTypeEnum}
            "GroupEmail" = ${GroupEmail}
            "TriggerType" = ${TriggerType}
            "TriggerTime" = ${TriggerTime}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectId" = ${ObjectId}
            "Summary" = ${Summary}
        }

        return $PSO
    }
}

<#
AutoImportProcessHookMessage<PSCustomObject>
#>
function ConvertFrom-JsonToAutoImportProcessHookMessage {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => AutoImportProcessHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in AutoImportProcessHookMessage
        $AllProperties = $("AutoImportProfileName", "TaskLink", "ObjectTitle", "ObjectType", "ObjectTypeEnum", "GroupEmail", "TriggerType", "TriggerTime", "ObjectUrl", "ObjectId", "Summary")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoImportProfileName"))) { #optional property not found
            $AutoImportProfileName = $null
        } else {
            $AutoImportProfileName = $JsonParameters.PSobject.Properties["AutoImportProfileName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskLink"))) { #optional property not found
            $TaskLink = $null
        } else {
            $TaskLink = $JsonParameters.PSobject.Properties["TaskLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectTitle"))) { #optional property not found
            $ObjectTitle = $null
        } else {
            $ObjectTitle = $JsonParameters.PSobject.Properties["ObjectTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) { #optional property not found
            $ObjectType = $null
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectTypeEnum"))) { #optional property not found
            $ObjectTypeEnum = $null
        } else {
            $ObjectTypeEnum = $JsonParameters.PSobject.Properties["ObjectTypeEnum"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupEmail"))) { #optional property not found
            $GroupEmail = $null
        } else {
            $GroupEmail = $JsonParameters.PSobject.Properties["GroupEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TriggerType"))) { #optional property not found
            $TriggerType = $null
        } else {
            $TriggerType = $JsonParameters.PSobject.Properties["TriggerType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TriggerTime"))) { #optional property not found
            $TriggerTime = $null
        } else {
            $TriggerTime = $JsonParameters.PSobject.Properties["TriggerTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectUrl"))) { #optional property not found
            $ObjectUrl = $null
        } else {
            $ObjectUrl = $JsonParameters.PSobject.Properties["ObjectUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectId"))) { #optional property not found
            $ObjectId = $null
        } else {
            $ObjectId = $JsonParameters.PSobject.Properties["ObjectId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Summary"))) { #optional property not found
            $Summary = $null
        } else {
            $Summary = $JsonParameters.PSobject.Properties["Summary"].value
        }

        $PSO = [PSCustomObject]@{
            "AutoImportProfileName" = ${AutoImportProfileName}
            "TaskLink" = ${TaskLink}
            "ObjectTitle" = ${ObjectTitle}
            "ObjectType" = ${ObjectType}
            "ObjectTypeEnum" = ${ObjectTypeEnum}
            "GroupEmail" = ${GroupEmail}
            "TriggerType" = ${TriggerType}
            "TriggerTime" = ${TriggerTime}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectId" = ${ObjectId}
            "Summary" = ${Summary}
        }

        return $PSO
    }

}

