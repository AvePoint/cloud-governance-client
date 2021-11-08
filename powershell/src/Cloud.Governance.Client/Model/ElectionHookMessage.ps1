#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ElectionHookMessage<PSCustomObject>
#>

function New-ElectionHookMessage {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsPrimaryContactDeactived} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalPrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsPrimaryContactChanged} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NewPrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSecondaryContactDeactived} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalSecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSecondaryContactChanged} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NewSecondaryContact},
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
        'Creating PSCustomObject: Cloud.Governance.Client => ElectionHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ServiceType" = ${ServiceType}
            "IsPrimaryContactDeactived" = ${IsPrimaryContactDeactived}
            "OriginalPrimaryContact" = ${OriginalPrimaryContact}
            "IsPrimaryContactChanged" = ${IsPrimaryContactChanged}
            "NewPrimaryContact" = ${NewPrimaryContact}
            "IsSecondaryContactDeactived" = ${IsSecondaryContactDeactived}
            "OriginalSecondaryContact" = ${OriginalSecondaryContact}
            "IsSecondaryContactChanged" = ${IsSecondaryContactChanged}
            "NewSecondaryContact" = ${NewSecondaryContact}
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
ElectionHookMessage<PSCustomObject>
#>
function ConvertFrom-JsonToElectionHookMessage {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ElectionHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ElectionHookMessage
        $AllProperties = $("ServiceType", "IsPrimaryContactDeactived", "OriginalPrimaryContact", "IsPrimaryContactChanged", "NewPrimaryContact", "IsSecondaryContactDeactived", "OriginalSecondaryContact", "IsSecondaryContactChanged", "NewSecondaryContact", "TaskLink", "ObjectTitle", "ObjectType", "ObjectTypeEnum", "GroupEmail", "TriggerType", "TriggerTime", "ObjectUrl", "ObjectId", "Summary")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceType"))) { #optional property not found
            $ServiceType = $null
        } else {
            $ServiceType = $JsonParameters.PSobject.Properties["ServiceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsPrimaryContactDeactived"))) { #optional property not found
            $IsPrimaryContactDeactived = $null
        } else {
            $IsPrimaryContactDeactived = $JsonParameters.PSobject.Properties["IsPrimaryContactDeactived"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalPrimaryContact"))) { #optional property not found
            $OriginalPrimaryContact = $null
        } else {
            $OriginalPrimaryContact = $JsonParameters.PSobject.Properties["OriginalPrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsPrimaryContactChanged"))) { #optional property not found
            $IsPrimaryContactChanged = $null
        } else {
            $IsPrimaryContactChanged = $JsonParameters.PSobject.Properties["IsPrimaryContactChanged"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NewPrimaryContact"))) { #optional property not found
            $NewPrimaryContact = $null
        } else {
            $NewPrimaryContact = $JsonParameters.PSobject.Properties["NewPrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsSecondaryContactDeactived"))) { #optional property not found
            $IsSecondaryContactDeactived = $null
        } else {
            $IsSecondaryContactDeactived = $JsonParameters.PSobject.Properties["IsSecondaryContactDeactived"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalSecondaryContact"))) { #optional property not found
            $OriginalSecondaryContact = $null
        } else {
            $OriginalSecondaryContact = $JsonParameters.PSobject.Properties["OriginalSecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsSecondaryContactChanged"))) { #optional property not found
            $IsSecondaryContactChanged = $null
        } else {
            $IsSecondaryContactChanged = $JsonParameters.PSobject.Properties["IsSecondaryContactChanged"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NewSecondaryContact"))) { #optional property not found
            $NewSecondaryContact = $null
        } else {
            $NewSecondaryContact = $JsonParameters.PSobject.Properties["NewSecondaryContact"].value
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
            "ServiceType" = ${ServiceType}
            "IsPrimaryContactDeactived" = ${IsPrimaryContactDeactived}
            "OriginalPrimaryContact" = ${OriginalPrimaryContact}
            "IsPrimaryContactChanged" = ${IsPrimaryContactChanged}
            "NewPrimaryContact" = ${NewPrimaryContact}
            "IsSecondaryContactDeactived" = ${IsSecondaryContactDeactived}
            "OriginalSecondaryContact" = ${OriginalSecondaryContact}
            "IsSecondaryContactChanged" = ${IsSecondaryContactChanged}
            "NewSecondaryContact" = ${NewSecondaryContact}
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

