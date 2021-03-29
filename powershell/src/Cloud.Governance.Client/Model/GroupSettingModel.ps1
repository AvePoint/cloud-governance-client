#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GroupSettingModel<PSCustomObject>
#>

function New-GroupSettingModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmailAddress},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Owners},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Members},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${GroupDuration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${EmailSubject},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${EmailBody}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GroupSettingModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "GroupName" = ${GroupName}
            "GroupDescription" = ${GroupDescription}
            "GroupEmailAddress" = ${GroupEmailAddress}
            "Owners" = ${Owners}
            "Members" = ${Members}
            "GroupDuration" = ${GroupDuration}
            "EmailSubject" = ${EmailSubject}
            "EmailBody" = ${EmailBody}
        }

        return $PSO
    }
}

<#
GroupSettingModel<PSCustomObject>
#>
function ConvertFrom-JsonToGroupSettingModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GroupSettingModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GroupSettingModel
        $AllProperties = $("GroupName", "GroupDescription", "GroupEmailAddress", "Owners", "Members", "GroupDuration", "EmailSubject", "EmailBody")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupName"))) { #optional property not found
            $GroupName = $null
        } else {
            $GroupName = $JsonParameters.PSobject.Properties["GroupName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupDescription"))) { #optional property not found
            $GroupDescription = $null
        } else {
            $GroupDescription = $JsonParameters.PSobject.Properties["GroupDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupEmailAddress"))) { #optional property not found
            $GroupEmailAddress = $null
        } else {
            $GroupEmailAddress = $JsonParameters.PSobject.Properties["GroupEmailAddress"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Owners"))) { #optional property not found
            $Owners = $null
        } else {
            $Owners = $JsonParameters.PSobject.Properties["Owners"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Members"))) { #optional property not found
            $Members = $null
        } else {
            $Members = $JsonParameters.PSobject.Properties["Members"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupDuration"))) { #optional property not found
            $GroupDuration = $null
        } else {
            $GroupDuration = $JsonParameters.PSobject.Properties["GroupDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EmailSubject"))) { #optional property not found
            $EmailSubject = $null
        } else {
            $EmailSubject = $JsonParameters.PSobject.Properties["EmailSubject"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EmailBody"))) { #optional property not found
            $EmailBody = $null
        } else {
            $EmailBody = $JsonParameters.PSobject.Properties["EmailBody"].value
        }

        $PSO = [PSCustomObject]@{
            "GroupName" = ${GroupName}
            "GroupDescription" = ${GroupDescription}
            "GroupEmailAddress" = ${GroupEmailAddress}
            "Owners" = ${Owners}
            "Members" = ${Members}
            "GroupDuration" = ${GroupDuration}
            "EmailSubject" = ${EmailSubject}
            "EmailBody" = ${EmailBody}
        }

        return $PSO
    }

}

