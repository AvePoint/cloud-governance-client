#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UserCustomAction<PSCustomObject>
#>

function New-UserCustomAction {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebFullUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Sequence} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ScriptSrc},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ScriptBlock},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Url},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Location},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Group},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ImageUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UserCustomAction' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$WebFullUrl) {
            throw "invalid value for 'WebFullUrl', 'WebFullUrl' cannot be null."
        }

        if (!$Name) {
            throw "invalid value for 'Name', 'Name' cannot be null."
        }

        if (!$Location) {
            throw "invalid value for 'Location', 'Location' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "WebFullUrl" = ${WebFullUrl}
            "Title" = ${Title}
            "Sequence" = ${Sequence}
            "ScriptSrc" = ${ScriptSrc}
            "ScriptBlock" = ${ScriptBlock}
            "Name" = ${Name}
            "Url" = ${Url}
            "Location" = ${Location}
            "Group" = ${Group}
            "ImageUrl" = ${ImageUrl}
            "Description" = ${Description}
        }

        return $PSO
    }
}

<#
UserCustomAction<PSCustomObject>
#>
function ConvertFrom-JsonToUserCustomAction {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UserCustomAction' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UserCustomAction
        $AllProperties = $("WebFullUrl", "Title", "Sequence", "ScriptSrc", "ScriptBlock", "Name", "Url", "Location", "Group", "ImageUrl", "Description")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property `WebFullUrl` missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebFullUrl"))) {
            throw "Error! JSON cannot be serialized due to the required property `WebFullUrl` missing."
        } else {
            $WebFullUrl = $JsonParameters.PSobject.Properties["WebFullUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) {
            throw "Error! JSON cannot be serialized due to the required property `Name` missing."
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Location"))) {
            throw "Error! JSON cannot be serialized due to the required property `Location` missing."
        } else {
            $Location = $JsonParameters.PSobject.Properties["Location"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sequence"))) { #optional property not found
            $Sequence = $null
        } else {
            $Sequence = $JsonParameters.PSobject.Properties["Sequence"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScriptSrc"))) { #optional property not found
            $ScriptSrc = $null
        } else {
            $ScriptSrc = $JsonParameters.PSobject.Properties["ScriptSrc"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScriptBlock"))) { #optional property not found
            $ScriptBlock = $null
        } else {
            $ScriptBlock = $JsonParameters.PSobject.Properties["ScriptBlock"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Url"))) { #optional property not found
            $Url = $null
        } else {
            $Url = $JsonParameters.PSobject.Properties["Url"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Group"))) { #optional property not found
            $Group = $null
        } else {
            $Group = $JsonParameters.PSobject.Properties["Group"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ImageUrl"))) { #optional property not found
            $ImageUrl = $null
        } else {
            $ImageUrl = $JsonParameters.PSobject.Properties["ImageUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        $PSO = [PSCustomObject]@{
            "WebFullUrl" = ${WebFullUrl}
            "Title" = ${Title}
            "Sequence" = ${Sequence}
            "ScriptSrc" = ${ScriptSrc}
            "ScriptBlock" = ${ScriptBlock}
            "Name" = ${Name}
            "Url" = ${Url}
            "Location" = ${Location}
            "Group" = ${Group}
            "ImageUrl" = ${ImageUrl}
            "Description" = ${Description}
        }

        return $PSO
    }

}

