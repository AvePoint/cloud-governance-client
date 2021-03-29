#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ExecutionModel<PSCustomObject>
#>

function New-ExecutionModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebServiceAddress},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WebServiceAuthenticationType} = "Anonymous",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebServiceAppClientId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MethodName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Arguments}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ExecutionModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "WebServiceAddress" = ${WebServiceAddress}
            "WebServiceAuthenticationType" = ${WebServiceAuthenticationType}
            "WebServiceAppClientId" = ${WebServiceAppClientId}
            "MethodName" = ${MethodName}
            "Arguments" = ${Arguments}
        }

        return $PSO
    }
}

<#
ExecutionModel<PSCustomObject>
#>
function ConvertFrom-JsonToExecutionModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ExecutionModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ExecutionModel
        $AllProperties = $("Enabled", "WebServiceAddress", "WebServiceAuthenticationType", "WebServiceAppClientId", "MethodName", "Arguments")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebServiceAddress"))) { #optional property not found
            $WebServiceAddress = $null
        } else {
            $WebServiceAddress = $JsonParameters.PSobject.Properties["WebServiceAddress"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebServiceAuthenticationType"))) { #optional property not found
            $WebServiceAuthenticationType = $null
        } else {
            $WebServiceAuthenticationType = $JsonParameters.PSobject.Properties["WebServiceAuthenticationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebServiceAppClientId"))) { #optional property not found
            $WebServiceAppClientId = $null
        } else {
            $WebServiceAppClientId = $JsonParameters.PSobject.Properties["WebServiceAppClientId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MethodName"))) { #optional property not found
            $MethodName = $null
        } else {
            $MethodName = $JsonParameters.PSobject.Properties["MethodName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Arguments"))) { #optional property not found
            $Arguments = $null
        } else {
            $Arguments = $JsonParameters.PSobject.Properties["Arguments"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "WebServiceAddress" = ${WebServiceAddress}
            "WebServiceAuthenticationType" = ${WebServiceAuthenticationType}
            "WebServiceAppClientId" = ${WebServiceAppClientId}
            "MethodName" = ${MethodName}
            "Arguments" = ${Arguments}
        }

        return $PSO
    }

}

