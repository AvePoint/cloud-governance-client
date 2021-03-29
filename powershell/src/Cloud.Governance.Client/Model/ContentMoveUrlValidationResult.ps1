#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ContentMoveUrlValidationResult<PSCustomObject>
#>

function New-ContentMoveUrlValidationResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Object},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ListBaseType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MessageCode} = "None"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ContentMoveUrlValidationResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Object" = ${Object}
            "ListBaseType" = ${ListBaseType}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
ContentMoveUrlValidationResult<PSCustomObject>
#>
function ConvertFrom-JsonToContentMoveUrlValidationResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ContentMoveUrlValidationResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ContentMoveUrlValidationResult
        $AllProperties = $("Object", "ListBaseType", "IsValid", "ErrorMessage", "MessageCode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Object"))) { #optional property not found
            $Object = $null
        } else {
            $Object = $JsonParameters.PSobject.Properties["Object"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListBaseType"))) { #optional property not found
            $ListBaseType = $null
        } else {
            $ListBaseType = $JsonParameters.PSobject.Properties["ListBaseType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsValid"))) { #optional property not found
            $IsValid = $null
        } else {
            $IsValid = $JsonParameters.PSobject.Properties["IsValid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMessage"))) { #optional property not found
            $ErrorMessage = $null
        } else {
            $ErrorMessage = $JsonParameters.PSobject.Properties["ErrorMessage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MessageCode"))) { #optional property not found
            $MessageCode = $null
        } else {
            $MessageCode = $JsonParameters.PSobject.Properties["MessageCode"].value
        }

        $PSO = [PSCustomObject]@{
            "Object" = ${Object}
            "ListBaseType" = ${ListBaseType}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

