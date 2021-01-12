#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
YammerGroupRequestSettings<PSCustomObject>
#>

function New-YammerGroupRequestSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NameOrId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${JoinType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsListInDirectory},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGroupAlreadyExisted}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => YammerGroupRequestSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "NameOrId" = ${NameOrId}
            "Description" = ${Description}
            "Type" = ${Type}
            "JoinType" = ${JoinType}
            "IsListInDirectory" = ${IsListInDirectory}
            "IsGroupAlreadyExisted" = ${IsGroupAlreadyExisted}
        }

        return $PSO
    }
}

<#
YammerGroupRequestSettings<PSCustomObject>
#>
function ConvertFrom-JsonToYammerGroupRequestSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => YammerGroupRequestSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in YammerGroupRequestSettings
        $AllProperties = $("NameOrId", "Description", "Type", "JoinType", "IsListInDirectory", "IsGroupAlreadyExisted")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NameOrId"))) { #optional property not found
            $NameOrId = $null
        } else {
            $NameOrId = $JsonParameters.PSobject.Properties["NameOrId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JoinType"))) { #optional property not found
            $JoinType = $null
        } else {
            $JoinType = $JsonParameters.PSobject.Properties["JoinType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsListInDirectory"))) { #optional property not found
            $IsListInDirectory = $null
        } else {
            $IsListInDirectory = $JsonParameters.PSobject.Properties["IsListInDirectory"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsGroupAlreadyExisted"))) { #optional property not found
            $IsGroupAlreadyExisted = $null
        } else {
            $IsGroupAlreadyExisted = $JsonParameters.PSobject.Properties["IsGroupAlreadyExisted"].value
        }

        $PSO = [PSCustomObject]@{
            "NameOrId" = ${NameOrId}
            "Description" = ${Description}
            "Type" = ${Type}
            "JoinType" = ${JoinType}
            "IsListInDirectory" = ${IsListInDirectory}
            "IsGroupAlreadyExisted" = ${IsGroupAlreadyExisted}
        }

        return $PSO
    }

}

