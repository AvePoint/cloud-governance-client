#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorkspaceIdTypeModel<PSCustomObject>
#>

function New-WorkspaceIdTypeModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WorkspaceType}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WorkspaceIdTypeModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ObjectId" = ${ObjectId}
            "WorkspaceType" = ${WorkspaceType}
        }

        return $PSO
    }
}

<#
WorkspaceIdTypeModel<PSCustomObject>
#>
function ConvertFrom-JsonToWorkspaceIdTypeModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorkspaceIdTypeModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorkspaceIdTypeModel
        $AllProperties = $("ObjectId", "WorkspaceType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectId"))) { #optional property not found
            $ObjectId = $null
        } else {
            $ObjectId = $JsonParameters.PSobject.Properties["ObjectId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WorkspaceType"))) { #optional property not found
            $WorkspaceType = $null
        } else {
            $WorkspaceType = $JsonParameters.PSobject.Properties["WorkspaceType"].value
        }

        $PSO = [PSCustomObject]@{
            "ObjectId" = ${ObjectId}
            "WorkspaceType" = ${WorkspaceType}
        }

        return $PSO
    }

}

