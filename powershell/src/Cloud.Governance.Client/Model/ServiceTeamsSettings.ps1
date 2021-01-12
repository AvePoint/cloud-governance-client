#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ServiceTeamsSettings<PSCustomObject>
#>

function New-ServiceTeamsSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MemberPermissionsAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GuestPermissionsAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MentionsAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${FunStuffAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMembersCreateUpdateChannels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMembersCreatePrivateChannels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMemberDeleteRestoreChannels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMembersAddRemoveApps},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMembersCreateUpdateRemoveTabs},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMembersCreateUpdateRemoveConnections},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMembersDeleteMessages},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMembersEditMessages},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowGuestsCreateUpdateChannels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowGuestsDeleteChannels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMentionsTeam},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMentionsChannel},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableGiphy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableStickersAndMemes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableCustomMemes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GiphyRatingType}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ServiceTeamsSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "MemberPermissionsAssignBy" = ${MemberPermissionsAssignBy}
            "GuestPermissionsAssignBy" = ${GuestPermissionsAssignBy}
            "MentionsAssignBy" = ${MentionsAssignBy}
            "FunStuffAssignBy" = ${FunStuffAssignBy}
            "AllowMembersCreateUpdateChannels" = ${AllowMembersCreateUpdateChannels}
            "AllowMembersCreatePrivateChannels" = ${AllowMembersCreatePrivateChannels}
            "AllowMemberDeleteRestoreChannels" = ${AllowMemberDeleteRestoreChannels}
            "AllowMembersAddRemoveApps" = ${AllowMembersAddRemoveApps}
            "AllowMembersCreateUpdateRemoveTabs" = ${AllowMembersCreateUpdateRemoveTabs}
            "AllowMembersCreateUpdateRemoveConnections" = ${AllowMembersCreateUpdateRemoveConnections}
            "AllowMembersDeleteMessages" = ${AllowMembersDeleteMessages}
            "AllowMembersEditMessages" = ${AllowMembersEditMessages}
            "AllowGuestsCreateUpdateChannels" = ${AllowGuestsCreateUpdateChannels}
            "AllowGuestsDeleteChannels" = ${AllowGuestsDeleteChannels}
            "AllowMentionsTeam" = ${AllowMentionsTeam}
            "AllowMentionsChannel" = ${AllowMentionsChannel}
            "EnableGiphy" = ${EnableGiphy}
            "EnableStickersAndMemes" = ${EnableStickersAndMemes}
            "EnableCustomMemes" = ${EnableCustomMemes}
            "GiphyRatingType" = ${GiphyRatingType}
        }

        return $PSO
    }
}

<#
ServiceTeamsSettings<PSCustomObject>
#>
function ConvertFrom-JsonToServiceTeamsSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ServiceTeamsSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ServiceTeamsSettings
        $AllProperties = $("MemberPermissionsAssignBy", "GuestPermissionsAssignBy", "MentionsAssignBy", "FunStuffAssignBy", "AllowMembersCreateUpdateChannels", "AllowMembersCreatePrivateChannels", "AllowMemberDeleteRestoreChannels", "AllowMembersAddRemoveApps", "AllowMembersCreateUpdateRemoveTabs", "AllowMembersCreateUpdateRemoveConnections", "AllowMembersDeleteMessages", "AllowMembersEditMessages", "AllowGuestsCreateUpdateChannels", "AllowGuestsDeleteChannels", "AllowMentionsTeam", "AllowMentionsChannel", "EnableGiphy", "EnableStickersAndMemes", "EnableCustomMemes", "GiphyRatingType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MemberPermissionsAssignBy"))) { #optional property not found
            $MemberPermissionsAssignBy = $null
        } else {
            $MemberPermissionsAssignBy = $JsonParameters.PSobject.Properties["MemberPermissionsAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GuestPermissionsAssignBy"))) { #optional property not found
            $GuestPermissionsAssignBy = $null
        } else {
            $GuestPermissionsAssignBy = $JsonParameters.PSobject.Properties["GuestPermissionsAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MentionsAssignBy"))) { #optional property not found
            $MentionsAssignBy = $null
        } else {
            $MentionsAssignBy = $JsonParameters.PSobject.Properties["MentionsAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FunStuffAssignBy"))) { #optional property not found
            $FunStuffAssignBy = $null
        } else {
            $FunStuffAssignBy = $JsonParameters.PSobject.Properties["FunStuffAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMembersCreateUpdateChannels"))) { #optional property not found
            $AllowMembersCreateUpdateChannels = $null
        } else {
            $AllowMembersCreateUpdateChannels = $JsonParameters.PSobject.Properties["AllowMembersCreateUpdateChannels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMembersCreatePrivateChannels"))) { #optional property not found
            $AllowMembersCreatePrivateChannels = $null
        } else {
            $AllowMembersCreatePrivateChannels = $JsonParameters.PSobject.Properties["AllowMembersCreatePrivateChannels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMemberDeleteRestoreChannels"))) { #optional property not found
            $AllowMemberDeleteRestoreChannels = $null
        } else {
            $AllowMemberDeleteRestoreChannels = $JsonParameters.PSobject.Properties["AllowMemberDeleteRestoreChannels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMembersAddRemoveApps"))) { #optional property not found
            $AllowMembersAddRemoveApps = $null
        } else {
            $AllowMembersAddRemoveApps = $JsonParameters.PSobject.Properties["AllowMembersAddRemoveApps"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMembersCreateUpdateRemoveTabs"))) { #optional property not found
            $AllowMembersCreateUpdateRemoveTabs = $null
        } else {
            $AllowMembersCreateUpdateRemoveTabs = $JsonParameters.PSobject.Properties["AllowMembersCreateUpdateRemoveTabs"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMembersCreateUpdateRemoveConnections"))) { #optional property not found
            $AllowMembersCreateUpdateRemoveConnections = $null
        } else {
            $AllowMembersCreateUpdateRemoveConnections = $JsonParameters.PSobject.Properties["AllowMembersCreateUpdateRemoveConnections"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMembersDeleteMessages"))) { #optional property not found
            $AllowMembersDeleteMessages = $null
        } else {
            $AllowMembersDeleteMessages = $JsonParameters.PSobject.Properties["AllowMembersDeleteMessages"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMembersEditMessages"))) { #optional property not found
            $AllowMembersEditMessages = $null
        } else {
            $AllowMembersEditMessages = $JsonParameters.PSobject.Properties["AllowMembersEditMessages"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowGuestsCreateUpdateChannels"))) { #optional property not found
            $AllowGuestsCreateUpdateChannels = $null
        } else {
            $AllowGuestsCreateUpdateChannels = $JsonParameters.PSobject.Properties["AllowGuestsCreateUpdateChannels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowGuestsDeleteChannels"))) { #optional property not found
            $AllowGuestsDeleteChannels = $null
        } else {
            $AllowGuestsDeleteChannels = $JsonParameters.PSobject.Properties["AllowGuestsDeleteChannels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMentionsTeam"))) { #optional property not found
            $AllowMentionsTeam = $null
        } else {
            $AllowMentionsTeam = $JsonParameters.PSobject.Properties["AllowMentionsTeam"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMentionsChannel"))) { #optional property not found
            $AllowMentionsChannel = $null
        } else {
            $AllowMentionsChannel = $JsonParameters.PSobject.Properties["AllowMentionsChannel"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableGiphy"))) { #optional property not found
            $EnableGiphy = $null
        } else {
            $EnableGiphy = $JsonParameters.PSobject.Properties["EnableGiphy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableStickersAndMemes"))) { #optional property not found
            $EnableStickersAndMemes = $null
        } else {
            $EnableStickersAndMemes = $JsonParameters.PSobject.Properties["EnableStickersAndMemes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableCustomMemes"))) { #optional property not found
            $EnableCustomMemes = $null
        } else {
            $EnableCustomMemes = $JsonParameters.PSobject.Properties["EnableCustomMemes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GiphyRatingType"))) { #optional property not found
            $GiphyRatingType = $null
        } else {
            $GiphyRatingType = $JsonParameters.PSobject.Properties["GiphyRatingType"].value
        }

        $PSO = [PSCustomObject]@{
            "MemberPermissionsAssignBy" = ${MemberPermissionsAssignBy}
            "GuestPermissionsAssignBy" = ${GuestPermissionsAssignBy}
            "MentionsAssignBy" = ${MentionsAssignBy}
            "FunStuffAssignBy" = ${FunStuffAssignBy}
            "AllowMembersCreateUpdateChannels" = ${AllowMembersCreateUpdateChannels}
            "AllowMembersCreatePrivateChannels" = ${AllowMembersCreatePrivateChannels}
            "AllowMemberDeleteRestoreChannels" = ${AllowMemberDeleteRestoreChannels}
            "AllowMembersAddRemoveApps" = ${AllowMembersAddRemoveApps}
            "AllowMembersCreateUpdateRemoveTabs" = ${AllowMembersCreateUpdateRemoveTabs}
            "AllowMembersCreateUpdateRemoveConnections" = ${AllowMembersCreateUpdateRemoveConnections}
            "AllowMembersDeleteMessages" = ${AllowMembersDeleteMessages}
            "AllowMembersEditMessages" = ${AllowMembersEditMessages}
            "AllowGuestsCreateUpdateChannels" = ${AllowGuestsCreateUpdateChannels}
            "AllowGuestsDeleteChannels" = ${AllowGuestsDeleteChannels}
            "AllowMentionsTeam" = ${AllowMentionsTeam}
            "AllowMentionsChannel" = ${AllowMentionsChannel}
            "EnableGiphy" = ${EnableGiphy}
            "EnableStickersAndMemes" = ${EnableStickersAndMemes}
            "EnableCustomMemes" = ${EnableCustomMemes}
            "GiphyRatingType" = ${GiphyRatingType}
        }

        return $PSO
    }

}

