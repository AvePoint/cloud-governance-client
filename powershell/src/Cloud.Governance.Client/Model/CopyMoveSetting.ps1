#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CopyMoveSetting<PSCustomObject>
#>

function New-CopyMoveSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsMigrateConfiguration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsKeepLookAndFeel},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ColumnsAndContentConflictResolution},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsMigrateSecurity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsMigrateColumnsAndContentTypes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsMigrateContent},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsMigrateContentIncludeListAttachment}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CopyMoveSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsMigrateConfiguration" = ${IsMigrateConfiguration}
            "IsKeepLookAndFeel" = ${IsKeepLookAndFeel}
            "ColumnsAndContentConflictResolution" = ${ColumnsAndContentConflictResolution}
            "IsMigrateSecurity" = ${IsMigrateSecurity}
            "IsMigrateColumnsAndContentTypes" = ${IsMigrateColumnsAndContentTypes}
            "IsMigrateContent" = ${IsMigrateContent}
            "IsMigrateContentIncludeListAttachment" = ${IsMigrateContentIncludeListAttachment}
        }

        return $PSO
    }
}

<#
CopyMoveSetting<PSCustomObject>
#>
function ConvertFrom-JsonToCopyMoveSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CopyMoveSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CopyMoveSetting
        $AllProperties = $("IsMigrateConfiguration", "IsKeepLookAndFeel", "ColumnsAndContentConflictResolution", "IsMigrateSecurity", "IsMigrateColumnsAndContentTypes", "IsMigrateContent", "IsMigrateContentIncludeListAttachment")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsMigrateConfiguration"))) { #optional property not found
            $IsMigrateConfiguration = $null
        } else {
            $IsMigrateConfiguration = $JsonParameters.PSobject.Properties["IsMigrateConfiguration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsKeepLookAndFeel"))) { #optional property not found
            $IsKeepLookAndFeel = $null
        } else {
            $IsKeepLookAndFeel = $JsonParameters.PSobject.Properties["IsKeepLookAndFeel"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ColumnsAndContentConflictResolution"))) { #optional property not found
            $ColumnsAndContentConflictResolution = $null
        } else {
            $ColumnsAndContentConflictResolution = $JsonParameters.PSobject.Properties["ColumnsAndContentConflictResolution"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsMigrateSecurity"))) { #optional property not found
            $IsMigrateSecurity = $null
        } else {
            $IsMigrateSecurity = $JsonParameters.PSobject.Properties["IsMigrateSecurity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsMigrateColumnsAndContentTypes"))) { #optional property not found
            $IsMigrateColumnsAndContentTypes = $null
        } else {
            $IsMigrateColumnsAndContentTypes = $JsonParameters.PSobject.Properties["IsMigrateColumnsAndContentTypes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsMigrateContent"))) { #optional property not found
            $IsMigrateContent = $null
        } else {
            $IsMigrateContent = $JsonParameters.PSobject.Properties["IsMigrateContent"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsMigrateContentIncludeListAttachment"))) { #optional property not found
            $IsMigrateContentIncludeListAttachment = $null
        } else {
            $IsMigrateContentIncludeListAttachment = $JsonParameters.PSobject.Properties["IsMigrateContentIncludeListAttachment"].value
        }

        $PSO = [PSCustomObject]@{
            "IsMigrateConfiguration" = ${IsMigrateConfiguration}
            "IsKeepLookAndFeel" = ${IsKeepLookAndFeel}
            "ColumnsAndContentConflictResolution" = ${ColumnsAndContentConflictResolution}
            "IsMigrateSecurity" = ${IsMigrateSecurity}
            "IsMigrateColumnsAndContentTypes" = ${IsMigrateColumnsAndContentTypes}
            "IsMigrateContent" = ${IsMigrateContent}
            "IsMigrateContentIncludeListAttachment" = ${IsMigrateContentIncludeListAttachment}
        }

        return $PSO
    }

}

