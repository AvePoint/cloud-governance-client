#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ManagePermissionSPObject<PSCustomObject>
#>

function New-ManagePermissionSPObject {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ParentNodeType} = "Container",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryAdministrator},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TemporaryGroupTitle},
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
        'Creating PSCustomObject: Cloud.Governance.Client => ManagePermissionSPObject' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ParentUrl" = ${ParentUrl}
            "ParentNodeType" = ${ParentNodeType}
            "SiteUrl" = ${SiteUrl}
            "WebUrl" = ${WebUrl}
            "PrimaryAdministrator" = ${PrimaryAdministrator}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "TemporaryGroupTitle" = ${TemporaryGroupTitle}
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
ManagePermissionSPObject<PSCustomObject>
#>
function ConvertFrom-JsonToManagePermissionSPObject {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ManagePermissionSPObject' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ManagePermissionSPObject
        $AllProperties = $("ParentUrl", "ParentNodeType", "SiteUrl", "WebUrl", "PrimaryAdministrator", "PrimaryContact", "SecondaryContact", "TemporaryGroupTitle", "WebId", "SiteId", "WebServerRelativeUrl", "ListTitle", "TopInheritUrl", "InheritNodeType", "IsInheritedPermission", "Id", "Title", "FullUrl", "Type")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentUrl"))) { #optional property not found
            $ParentUrl = $null
        } else {
            $ParentUrl = $JsonParameters.PSobject.Properties["ParentUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentNodeType"))) { #optional property not found
            $ParentNodeType = $null
        } else {
            $ParentNodeType = $JsonParameters.PSobject.Properties["ParentNodeType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrl"))) { #optional property not found
            $SiteUrl = $null
        } else {
            $SiteUrl = $JsonParameters.PSobject.Properties["SiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebUrl"))) { #optional property not found
            $WebUrl = $null
        } else {
            $WebUrl = $JsonParameters.PSobject.Properties["WebUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdministrator"))) { #optional property not found
            $PrimaryAdministrator = $null
        } else {
            $PrimaryAdministrator = $JsonParameters.PSobject.Properties["PrimaryAdministrator"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemporaryGroupTitle"))) { #optional property not found
            $TemporaryGroupTitle = $null
        } else {
            $TemporaryGroupTitle = $JsonParameters.PSobject.Properties["TemporaryGroupTitle"].value
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
            "ParentUrl" = ${ParentUrl}
            "ParentNodeType" = ${ParentNodeType}
            "SiteUrl" = ${SiteUrl}
            "WebUrl" = ${WebUrl}
            "PrimaryAdministrator" = ${PrimaryAdministrator}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "TemporaryGroupTitle" = ${TemporaryGroupTitle}
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

