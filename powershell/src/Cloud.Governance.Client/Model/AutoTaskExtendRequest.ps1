#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
AutoTaskExtendRequest<PSCustomObject>
#>

function New-AutoTaskExtendRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ExtendDuration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtendDurationType} = "Day",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TaskId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Comments}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => AutoTaskExtendRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Action" = ${Action}
            "ExtendDuration" = ${ExtendDuration}
            "ExtendDurationType" = ${ExtendDurationType}
            "TaskId" = ${TaskId}
            "Metadatas" = ${Metadatas}
            "Comments" = ${Comments}
        }

        return $PSO
    }
}

<#
AutoTaskExtendRequest<PSCustomObject>
#>
function ConvertFrom-JsonToAutoTaskExtendRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => AutoTaskExtendRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in AutoTaskExtendRequest
        $AllProperties = $("Action", "ExtendDuration", "ExtendDurationType", "TaskId", "Metadatas", "Comments")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExtendDuration"))) { #optional property not found
            $ExtendDuration = $null
        } else {
            $ExtendDuration = $JsonParameters.PSobject.Properties["ExtendDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExtendDurationType"))) { #optional property not found
            $ExtendDurationType = $null
        } else {
            $ExtendDurationType = $JsonParameters.PSobject.Properties["ExtendDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskId"))) { #optional property not found
            $TaskId = $null
        } else {
            $TaskId = $JsonParameters.PSobject.Properties["TaskId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Comments"))) { #optional property not found
            $Comments = $null
        } else {
            $Comments = $JsonParameters.PSobject.Properties["Comments"].value
        }

        $PSO = [PSCustomObject]@{
            "Action" = ${Action}
            "ExtendDuration" = ${ExtendDuration}
            "ExtendDurationType" = ${ExtendDurationType}
            "TaskId" = ${TaskId}
            "Metadatas" = ${Metadatas}
            "Comments" = ${Comments}
        }

        return $PSO
    }

}

