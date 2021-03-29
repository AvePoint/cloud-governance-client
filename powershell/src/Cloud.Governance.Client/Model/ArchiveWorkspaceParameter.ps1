#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ArchiveWorkspaceParameter<PSCustomObject>
#>

function New-ArchiveWorkspaceParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ArchiveProfile},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${ObjectIds},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WorkspaceType} = "Site"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ArchiveWorkspaceParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ArchiveProfile" = ${ArchiveProfile}
            "ObjectIds" = ${ObjectIds}
            "WorkspaceType" = ${WorkspaceType}
        }

        return $PSO
    }
}

<#
ArchiveWorkspaceParameter<PSCustomObject>
#>
function ConvertFrom-JsonToArchiveWorkspaceParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ArchiveWorkspaceParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ArchiveWorkspaceParameter
        $AllProperties = $("ArchiveProfile", "ObjectIds", "WorkspaceType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ArchiveProfile"))) { #optional property not found
            $ArchiveProfile = $null
        } else {
            $ArchiveProfile = $JsonParameters.PSobject.Properties["ArchiveProfile"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectIds"))) { #optional property not found
            $ObjectIds = $null
        } else {
            $ObjectIds = $JsonParameters.PSobject.Properties["ObjectIds"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WorkspaceType"))) { #optional property not found
            $WorkspaceType = $null
        } else {
            $WorkspaceType = $JsonParameters.PSobject.Properties["WorkspaceType"].value
        }

        $PSO = [PSCustomObject]@{
            "ArchiveProfile" = ${ArchiveProfile}
            "ObjectIds" = ${ObjectIds}
            "WorkspaceType" = ${WorkspaceType}
        }

        return $PSO
    }

}

