#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeWebUrlValidateResult<PSCustomObject>
#>

function New-ChangeWebUrlValidateResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Url},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MessageCode}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeWebUrlValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Url" = ${Url}
            "WebTitle" = ${WebTitle}
            "WebDescription" = ${WebDescription}
            "Metadatas" = ${Metadatas}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
ChangeWebUrlValidateResult<PSCustomObject>
#>
function ConvertFrom-JsonToChangeWebUrlValidateResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeWebUrlValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeWebUrlValidateResult
        $AllProperties = $("Url", "WebTitle", "WebDescription", "Metadatas", "IsValid", "ErrorMessage", "MessageCode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Url"))) { #optional property not found
            $Url = $null
        } else {
            $Url = $JsonParameters.PSobject.Properties["Url"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebTitle"))) { #optional property not found
            $WebTitle = $null
        } else {
            $WebTitle = $JsonParameters.PSobject.Properties["WebTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebDescription"))) { #optional property not found
            $WebDescription = $null
        } else {
            $WebDescription = $JsonParameters.PSobject.Properties["WebDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
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
            "Url" = ${Url}
            "WebTitle" = ${WebTitle}
            "WebDescription" = ${WebDescription}
            "Metadatas" = ${Metadatas}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

