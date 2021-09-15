#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
RequestHookMessage<PSCustomObject>
#>

function New-RequestHookMessage {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${RequestId} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequestGuid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequesterIdentityName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Requester},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceTypeEnum} = "None",
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
        'Creating PSCustomObject: Cloud.Governance.Client => RequestHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ServiceName" = ${ServiceName}
            "ServiceId" = ${ServiceId}
            "RequestId" = ${RequestId}
            "RequestGuid" = ${RequestGuid}
            "RequesterIdentityName" = ${RequesterIdentityName}
            "Requester" = ${Requester}
            "ServiceType" = ${ServiceType}
            "ServiceTypeEnum" = ${ServiceTypeEnum}
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
RequestHookMessage<PSCustomObject>
#>
function ConvertFrom-JsonToRequestHookMessage {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => RequestHookMessage' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in RequestHookMessage
        $AllProperties = $("ServiceName", "ServiceId", "RequestId", "RequestGuid", "RequesterIdentityName", "Requester", "ServiceType", "ServiceTypeEnum", "TriggerType", "TriggerTime", "ObjectUrl", "ObjectId", "Summary")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceName"))) { #optional property not found
            $ServiceName = $null
        } else {
            $ServiceName = $JsonParameters.PSobject.Properties["ServiceName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceId"))) { #optional property not found
            $ServiceId = $null
        } else {
            $ServiceId = $JsonParameters.PSobject.Properties["ServiceId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestId"))) { #optional property not found
            $RequestId = $null
        } else {
            $RequestId = $JsonParameters.PSobject.Properties["RequestId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestGuid"))) { #optional property not found
            $RequestGuid = $null
        } else {
            $RequestGuid = $JsonParameters.PSobject.Properties["RequestGuid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterIdentityName"))) { #optional property not found
            $RequesterIdentityName = $null
        } else {
            $RequesterIdentityName = $JsonParameters.PSobject.Properties["RequesterIdentityName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Requester"))) { #optional property not found
            $Requester = $null
        } else {
            $Requester = $JsonParameters.PSobject.Properties["Requester"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceType"))) { #optional property not found
            $ServiceType = $null
        } else {
            $ServiceType = $JsonParameters.PSobject.Properties["ServiceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceTypeEnum"))) { #optional property not found
            $ServiceTypeEnum = $null
        } else {
            $ServiceTypeEnum = $JsonParameters.PSobject.Properties["ServiceTypeEnum"].value
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
            "ServiceName" = ${ServiceName}
            "ServiceId" = ${ServiceId}
            "RequestId" = ${RequestId}
            "RequestGuid" = ${RequestGuid}
            "RequesterIdentityName" = ${RequesterIdentityName}
            "Requester" = ${Requester}
            "ServiceType" = ${ServiceType}
            "ServiceTypeEnum" = ${ServiceTypeEnum}
            "TriggerType" = ${TriggerType}
            "TriggerTime" = ${TriggerTime}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectId" = ${ObjectId}
            "Summary" = ${Summary}
        }

        return $PSO
    }

}

