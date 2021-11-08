#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
AutoCompleteRenewalTaskParameter<PSCustomObject>
#>

function New-AutoCompleteRenewalTaskParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsMarkAsCanceled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSendCancelEmail} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CancelEmailTemplateId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Workspace}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => AutoCompleteRenewalTaskParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsMarkAsCanceled" = ${IsMarkAsCanceled}
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "Workspace" = ${Workspace}
        }

        return $PSO
    }
}

<#
AutoCompleteRenewalTaskParameter<PSCustomObject>
#>
function ConvertFrom-JsonToAutoCompleteRenewalTaskParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => AutoCompleteRenewalTaskParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in AutoCompleteRenewalTaskParameter
        $AllProperties = $("IsMarkAsCanceled", "IsSendCancelEmail", "CancelEmailTemplateId", "Workspace")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsMarkAsCanceled"))) { #optional property not found
            $IsMarkAsCanceled = $null
        } else {
            $IsMarkAsCanceled = $JsonParameters.PSobject.Properties["IsMarkAsCanceled"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Workspace"))) { #optional property not found
            $Workspace = $null
        } else {
            $Workspace = $JsonParameters.PSobject.Properties["Workspace"].value
        }

        $PSO = [PSCustomObject]@{
            "IsMarkAsCanceled" = ${IsMarkAsCanceled}
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "Workspace" = ${Workspace}
        }

        return $PSO
    }

}

