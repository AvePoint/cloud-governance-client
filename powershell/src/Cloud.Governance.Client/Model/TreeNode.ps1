#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TreeNode<PSCustomObject>
#>

function New-TreeNode {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebApplicationId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebApplicationUri},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteCollectionId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteCollectionUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NodeId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${StartIndex} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${PageSize} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${PageIndex} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${FullCount} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ManagedPath},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AgentID},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FullPath},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FarmName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HasNextPage} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FarmID},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentID},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Extension},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Parent},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "Root",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SpObjectID},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NetworkId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentSPObjectID},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LoadManagedPath} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LoadChildrenFromDB} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LoadedPageCount} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Children},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedChildren},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FilterUrls},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${FilterType} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${CheckNumber} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SelectedWebAppIdSubSiteProvServ},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SelectedSiteCollIdsSubSiteProvServ},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ChildrenType} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ListId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServerRelativeUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserName}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TreeNode' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "WebApplicationId" = ${WebApplicationId}
            "WebApplicationUri" = ${WebApplicationUri}
            "SiteCollectionId" = ${SiteCollectionId}
            "SiteCollectionUrl" = ${SiteCollectionUrl}
            "SiteId" = ${SiteId}
            "NodeId" = ${NodeId}
            "StartIndex" = ${StartIndex}
            "PageSize" = ${PageSize}
            "PageIndex" = ${PageIndex}
            "FullCount" = ${FullCount}
            "Name" = ${Name}
            "Title" = ${Title}
            "Description" = ${Description}
            "DisplayName" = ${DisplayName}
            "ManagedPath" = ${ManagedPath}
            "AgentID" = ${AgentID}
            "FullPath" = ${FullPath}
            "FarmName" = ${FarmName}
            "HasNextPage" = ${HasNextPage}
            "FarmID" = ${FarmID}
            "ParentID" = ${ParentID}
            "Extension" = ${Extension}
            "Parent" = ${Parent}
            "Type" = ${Type}
            "SpObjectID" = ${SpObjectID}
            "NetworkId" = ${NetworkId}
            "ParentSPObjectID" = ${ParentSPObjectID}
            "Id" = ${Id}
            "LoadManagedPath" = ${LoadManagedPath}
            "LoadChildrenFromDB" = ${LoadChildrenFromDB}
            "LoadedPageCount" = ${LoadedPageCount}
            "Children" = ${Children}
            "SelectedChildren" = ${SelectedChildren}
            "FilterUrls" = ${FilterUrls}
            "FilterType" = ${FilterType}
            "CheckNumber" = ${CheckNumber}
            "SelectedWebAppIdSubSiteProvServ" = ${SelectedWebAppIdSubSiteProvServ}
            "SelectedSiteCollIdsSubSiteProvServ" = ${SelectedSiteCollIdsSubSiteProvServ}
            "ChildrenType" = ${ChildrenType}
            "ListId" = ${ListId}
            "ServerRelativeUrl" = ${ServerRelativeUrl}
            "UserName" = ${UserName}
        }

        return $PSO
    }
}

<#
TreeNode<PSCustomObject>
#>
function ConvertFrom-JsonToTreeNode {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TreeNode' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TreeNode
        $AllProperties = $("WebApplicationId", "WebApplicationUri", "SiteCollectionId", "SiteCollectionUrl", "SiteId", "NodeId", "StartIndex", "PageSize", "PageIndex", "FullCount", "Name", "Title", "Description", "DisplayName", "ManagedPath", "AgentID", "FullPath", "FarmName", "HasNextPage", "FarmID", "ParentID", "Extension", "Parent", "Type", "SpObjectID", "NetworkId", "ParentSPObjectID", "Id", "LoadManagedPath", "LoadChildrenFromDB", "LoadedPageCount", "Children", "SelectedChildren", "FilterUrls", "FilterType", "CheckNumber", "SelectedWebAppIdSubSiteProvServ", "SelectedSiteCollIdsSubSiteProvServ", "ChildrenType", "ListId", "ServerRelativeUrl", "UserName")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebApplicationId"))) { #optional property not found
            $WebApplicationId = $null
        } else {
            $WebApplicationId = $JsonParameters.PSobject.Properties["WebApplicationId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebApplicationUri"))) { #optional property not found
            $WebApplicationUri = $null
        } else {
            $WebApplicationUri = $JsonParameters.PSobject.Properties["WebApplicationUri"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteCollectionId"))) { #optional property not found
            $SiteCollectionId = $null
        } else {
            $SiteCollectionId = $JsonParameters.PSobject.Properties["SiteCollectionId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteCollectionUrl"))) { #optional property not found
            $SiteCollectionUrl = $null
        } else {
            $SiteCollectionUrl = $JsonParameters.PSobject.Properties["SiteCollectionUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteId"))) { #optional property not found
            $SiteId = $null
        } else {
            $SiteId = $JsonParameters.PSobject.Properties["SiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NodeId"))) { #optional property not found
            $NodeId = $null
        } else {
            $NodeId = $JsonParameters.PSobject.Properties["NodeId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StartIndex"))) { #optional property not found
            $StartIndex = $null
        } else {
            $StartIndex = $JsonParameters.PSobject.Properties["StartIndex"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PageSize"))) { #optional property not found
            $PageSize = $null
        } else {
            $PageSize = $JsonParameters.PSobject.Properties["PageSize"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PageIndex"))) { #optional property not found
            $PageIndex = $null
        } else {
            $PageIndex = $JsonParameters.PSobject.Properties["PageIndex"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FullCount"))) { #optional property not found
            $FullCount = $null
        } else {
            $FullCount = $JsonParameters.PSobject.Properties["FullCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ManagedPath"))) { #optional property not found
            $ManagedPath = $null
        } else {
            $ManagedPath = $JsonParameters.PSobject.Properties["ManagedPath"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AgentID"))) { #optional property not found
            $AgentID = $null
        } else {
            $AgentID = $JsonParameters.PSobject.Properties["AgentID"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FullPath"))) { #optional property not found
            $FullPath = $null
        } else {
            $FullPath = $JsonParameters.PSobject.Properties["FullPath"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FarmName"))) { #optional property not found
            $FarmName = $null
        } else {
            $FarmName = $JsonParameters.PSobject.Properties["FarmName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HasNextPage"))) { #optional property not found
            $HasNextPage = $null
        } else {
            $HasNextPage = $JsonParameters.PSobject.Properties["HasNextPage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FarmID"))) { #optional property not found
            $FarmID = $null
        } else {
            $FarmID = $JsonParameters.PSobject.Properties["FarmID"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentID"))) { #optional property not found
            $ParentID = $null
        } else {
            $ParentID = $JsonParameters.PSobject.Properties["ParentID"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Extension"))) { #optional property not found
            $Extension = $null
        } else {
            $Extension = $JsonParameters.PSobject.Properties["Extension"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Parent"))) { #optional property not found
            $Parent = $null
        } else {
            $Parent = $JsonParameters.PSobject.Properties["Parent"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SpObjectID"))) { #optional property not found
            $SpObjectID = $null
        } else {
            $SpObjectID = $JsonParameters.PSobject.Properties["SpObjectID"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkId"))) { #optional property not found
            $NetworkId = $null
        } else {
            $NetworkId = $JsonParameters.PSobject.Properties["NetworkId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentSPObjectID"))) { #optional property not found
            $ParentSPObjectID = $null
        } else {
            $ParentSPObjectID = $JsonParameters.PSobject.Properties["ParentSPObjectID"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LoadManagedPath"))) { #optional property not found
            $LoadManagedPath = $null
        } else {
            $LoadManagedPath = $JsonParameters.PSobject.Properties["LoadManagedPath"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LoadChildrenFromDB"))) { #optional property not found
            $LoadChildrenFromDB = $null
        } else {
            $LoadChildrenFromDB = $JsonParameters.PSobject.Properties["LoadChildrenFromDB"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LoadedPageCount"))) { #optional property not found
            $LoadedPageCount = $null
        } else {
            $LoadedPageCount = $JsonParameters.PSobject.Properties["LoadedPageCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Children"))) { #optional property not found
            $Children = $null
        } else {
            $Children = $JsonParameters.PSobject.Properties["Children"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedChildren"))) { #optional property not found
            $SelectedChildren = $null
        } else {
            $SelectedChildren = $JsonParameters.PSobject.Properties["SelectedChildren"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FilterUrls"))) { #optional property not found
            $FilterUrls = $null
        } else {
            $FilterUrls = $JsonParameters.PSobject.Properties["FilterUrls"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FilterType"))) { #optional property not found
            $FilterType = $null
        } else {
            $FilterType = $JsonParameters.PSobject.Properties["FilterType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CheckNumber"))) { #optional property not found
            $CheckNumber = $null
        } else {
            $CheckNumber = $JsonParameters.PSobject.Properties["CheckNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedWebAppIdSubSiteProvServ"))) { #optional property not found
            $SelectedWebAppIdSubSiteProvServ = $null
        } else {
            $SelectedWebAppIdSubSiteProvServ = $JsonParameters.PSobject.Properties["SelectedWebAppIdSubSiteProvServ"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedSiteCollIdsSubSiteProvServ"))) { #optional property not found
            $SelectedSiteCollIdsSubSiteProvServ = $null
        } else {
            $SelectedSiteCollIdsSubSiteProvServ = $JsonParameters.PSobject.Properties["SelectedSiteCollIdsSubSiteProvServ"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChildrenType"))) { #optional property not found
            $ChildrenType = $null
        } else {
            $ChildrenType = $JsonParameters.PSobject.Properties["ChildrenType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListId"))) { #optional property not found
            $ListId = $null
        } else {
            $ListId = $JsonParameters.PSobject.Properties["ListId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServerRelativeUrl"))) { #optional property not found
            $ServerRelativeUrl = $null
        } else {
            $ServerRelativeUrl = $JsonParameters.PSobject.Properties["ServerRelativeUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserName"))) { #optional property not found
            $UserName = $null
        } else {
            $UserName = $JsonParameters.PSobject.Properties["UserName"].value
        }

        $PSO = [PSCustomObject]@{
            "WebApplicationId" = ${WebApplicationId}
            "WebApplicationUri" = ${WebApplicationUri}
            "SiteCollectionId" = ${SiteCollectionId}
            "SiteCollectionUrl" = ${SiteCollectionUrl}
            "SiteId" = ${SiteId}
            "NodeId" = ${NodeId}
            "StartIndex" = ${StartIndex}
            "PageSize" = ${PageSize}
            "PageIndex" = ${PageIndex}
            "FullCount" = ${FullCount}
            "Name" = ${Name}
            "Title" = ${Title}
            "Description" = ${Description}
            "DisplayName" = ${DisplayName}
            "ManagedPath" = ${ManagedPath}
            "AgentID" = ${AgentID}
            "FullPath" = ${FullPath}
            "FarmName" = ${FarmName}
            "HasNextPage" = ${HasNextPage}
            "FarmID" = ${FarmID}
            "ParentID" = ${ParentID}
            "Extension" = ${Extension}
            "Parent" = ${Parent}
            "Type" = ${Type}
            "SpObjectID" = ${SpObjectID}
            "NetworkId" = ${NetworkId}
            "ParentSPObjectID" = ${ParentSPObjectID}
            "Id" = ${Id}
            "LoadManagedPath" = ${LoadManagedPath}
            "LoadChildrenFromDB" = ${LoadChildrenFromDB}
            "LoadedPageCount" = ${LoadedPageCount}
            "Children" = ${Children}
            "SelectedChildren" = ${SelectedChildren}
            "FilterUrls" = ${FilterUrls}
            "FilterType" = ${FilterType}
            "CheckNumber" = ${CheckNumber}
            "SelectedWebAppIdSubSiteProvServ" = ${SelectedWebAppIdSubSiteProvServ}
            "SelectedSiteCollIdsSubSiteProvServ" = ${SelectedSiteCollIdsSubSiteProvServ}
            "ChildrenType" = ${ChildrenType}
            "ListId" = ${ListId}
            "ServerRelativeUrl" = ${ServerRelativeUrl}
            "UserName" = ${UserName}
        }

        return $PSO
    }

}

