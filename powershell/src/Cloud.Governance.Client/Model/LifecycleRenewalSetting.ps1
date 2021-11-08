#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LifecycleRenewalSetting<PSCustomObject>
#>

function New-LifecycleRenewalSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseDateType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${StartDateType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${SpecifyStartDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HandleOngoingType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSendCancelEmail} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CancelEmailTemplateId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CancelEmailTemplateName}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => LifecycleRenewalSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "LeaseDateType" = ${LeaseDateType}
            "StartDateType" = ${StartDateType}
            "SpecifyStartDate" = ${SpecifyStartDate}
            "HandleOngoingType" = ${HandleOngoingType}
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "CancelEmailTemplateName" = ${CancelEmailTemplateName}
        }

        return $PSO
    }
}

<#
LifecycleRenewalSetting<PSCustomObject>
#>
function ConvertFrom-JsonToLifecycleRenewalSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LifecycleRenewalSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LifecycleRenewalSetting
        $AllProperties = $("LeaseDateType", "StartDateType", "SpecifyStartDate", "HandleOngoingType", "IsSendCancelEmail", "CancelEmailTemplateId", "CancelEmailTemplateName")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseDateType"))) { #optional property not found
            $LeaseDateType = $null
        } else {
            $LeaseDateType = $JsonParameters.PSobject.Properties["LeaseDateType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StartDateType"))) { #optional property not found
            $StartDateType = $null
        } else {
            $StartDateType = $JsonParameters.PSobject.Properties["StartDateType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SpecifyStartDate"))) { #optional property not found
            $SpecifyStartDate = $null
        } else {
            $SpecifyStartDate = $JsonParameters.PSobject.Properties["SpecifyStartDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HandleOngoingType"))) { #optional property not found
            $HandleOngoingType = $null
        } else {
            $HandleOngoingType = $JsonParameters.PSobject.Properties["HandleOngoingType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsSendCancelEmail"))) { #optional property not found
            $IsSendCancelEmail = $null
        } else {
            $IsSendCancelEmail = $JsonParameters.PSobject.Properties["IsSendCancelEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CancelEmailTemplateId"))) { #optional property not found
            $CancelEmailTemplateId = $null
        } else {
            $CancelEmailTemplateId = $JsonParameters.PSobject.Properties["CancelEmailTemplateId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CancelEmailTemplateName"))) { #optional property not found
            $CancelEmailTemplateName = $null
        } else {
            $CancelEmailTemplateName = $JsonParameters.PSobject.Properties["CancelEmailTemplateName"].value
        }

        $PSO = [PSCustomObject]@{
            "LeaseDateType" = ${LeaseDateType}
            "StartDateType" = ${StartDateType}
            "SpecifyStartDate" = ${SpecifyStartDate}
            "HandleOngoingType" = ${HandleOngoingType}
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "CancelEmailTemplateName" = ${CancelEmailTemplateName}
        }

        return $PSO
    }

}

