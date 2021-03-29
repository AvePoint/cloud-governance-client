#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GrantPermissionSPObject<PSCustomObject>
#>

function New-GrantPermissionSPObject {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebServerRelativeUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ListTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TopInheritUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InheritNodeType} = "Container",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsInheritedPermission} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FullUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "Container"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GrantPermissionSPObject' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "WebId" = ${WebId}
            "SiteId" = ${SiteId}
            "WebServerRelativeUrl" = ${WebServerRelativeUrl}
            "ListTitle" = ${ListTitle}
            "TopInheritUrl" = ${TopInheritUrl}
            "InheritNodeType" = ${InheritNodeType}
            "IsInheritedPermission" = ${IsInheritedPermission}
            "Id" = ${Id}
            "Title" = ${Title}
            "FullUrl" = ${FullUrl}
            "Type" = ${Type}
        }

        return $PSO
    }
}

<#
GrantPermissionSPObject<PSCustomObject>
#>
function ConvertFrom-JsonToGrantPermissionSPObject {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GrantPermissionSPObject' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GrantPermissionSPObject
        $AllProperties = $("WebId", "SiteId", "WebServerRelativeUrl", "ListTitle", "TopInheritUrl", "InheritNodeType", "IsInheritedPermission", "Id", "Title", "FullUrl", "Type")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebId"))) { #optional property not found
            $WebId = $null
        } else {
            $WebId = $JsonParameters.PSobject.Properties["WebId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteId"))) { #optional property not found
            $SiteId = $null
        } else {
            $SiteId = $JsonParameters.PSobject.Properties["SiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebServerRelativeUrl"))) { #optional property not found
            $WebServerRelativeUrl = $null
        } else {
            $WebServerRelativeUrl = $JsonParameters.PSobject.Properties["WebServerRelativeUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListTitle"))) { #optional property not found
            $ListTitle = $null
        } else {
            $ListTitle = $JsonParameters.PSobject.Properties["ListTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TopInheritUrl"))) { #optional property not found
            $TopInheritUrl = $null
        } else {
            $TopInheritUrl = $JsonParameters.PSobject.Properties["TopInheritUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InheritNodeType"))) { #optional property not found
            $InheritNodeType = $null
        } else {
            $InheritNodeType = $JsonParameters.PSobject.Properties["InheritNodeType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsInheritedPermission"))) { #optional property not found
            $IsInheritedPermission = $null
        } else {
            $IsInheritedPermission = $JsonParameters.PSobject.Properties["IsInheritedPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FullUrl"))) { #optional property not found
            $FullUrl = $null
        } else {
            $FullUrl = $JsonParameters.PSobject.Properties["FullUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        $PSO = [PSCustomObject]@{
            "WebId" = ${WebId}
            "SiteId" = ${SiteId}
            "WebServerRelativeUrl" = ${WebServerRelativeUrl}
            "ListTitle" = ${ListTitle}
            "TopInheritUrl" = ${TopInheritUrl}
            "InheritNodeType" = ${InheritNodeType}
            "IsInheritedPermission" = ${IsInheritedPermission}
            "Id" = ${Id}
            "Title" = ${Title}
            "FullUrl" = ${FullUrl}
            "Type" = ${Type}
        }

        return $PSO
    }

}

