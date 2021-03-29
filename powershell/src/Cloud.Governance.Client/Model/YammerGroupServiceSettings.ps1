#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
YammerGroupServiceSettings<PSCustomObject>
#>

function New-YammerGroupServiceSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NetworkId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowCreate} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowReuseExisting} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CreateNewGroupAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NameOrId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "Public",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${JoinType} = "Anyone",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsListInDirectory} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGroupAlreadyExisted} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => YammerGroupServiceSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "NetworkId" = ${NetworkId}
            "AllowCreate" = ${AllowCreate}
            "AllowReuseExisting" = ${AllowReuseExisting}
            "Enabled" = ${Enabled}
            "CreateNewGroupAssignBy" = ${CreateNewGroupAssignBy}
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
YammerGroupServiceSettings<PSCustomObject>
#>
function ConvertFrom-JsonToYammerGroupServiceSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => YammerGroupServiceSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in YammerGroupServiceSettings
        $AllProperties = $("NetworkId", "AllowCreate", "AllowReuseExisting", "Enabled", "CreateNewGroupAssignBy", "NameOrId", "Description", "Type", "JoinType", "IsListInDirectory", "IsGroupAlreadyExisted")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkId"))) { #optional property not found
            $NetworkId = $null
        } else {
            $NetworkId = $JsonParameters.PSobject.Properties["NetworkId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowCreate"))) { #optional property not found
            $AllowCreate = $null
        } else {
            $AllowCreate = $JsonParameters.PSobject.Properties["AllowCreate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowReuseExisting"))) { #optional property not found
            $AllowReuseExisting = $null
        } else {
            $AllowReuseExisting = $JsonParameters.PSobject.Properties["AllowReuseExisting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreateNewGroupAssignBy"))) { #optional property not found
            $CreateNewGroupAssignBy = $null
        } else {
            $CreateNewGroupAssignBy = $JsonParameters.PSobject.Properties["CreateNewGroupAssignBy"].value
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
            "NetworkId" = ${NetworkId}
            "AllowCreate" = ${AllowCreate}
            "AllowReuseExisting" = ${AllowReuseExisting}
            "Enabled" = ${Enabled}
            "CreateNewGroupAssignBy" = ${CreateNewGroupAssignBy}
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

