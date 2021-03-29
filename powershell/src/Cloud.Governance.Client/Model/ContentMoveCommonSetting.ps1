#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ContentMoveCommonSetting<PSCustomObject>
#>

function New-ContentMoveCommonSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsIncludeVersions} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsIncludeWorkflowDefinition} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDisableInformationRightsManagement} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsPreserveNullColumnValues} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsKeepModifiedByAndModifiedTime} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ProfileMappings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${BackupSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ConflictResolutionSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${FilterPolicy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DeleteType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDeleteCheckedFiles} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ContentMoveCommonSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsIncludeVersions" = ${IsIncludeVersions}
            "IsIncludeWorkflowDefinition" = ${IsIncludeWorkflowDefinition}
            "IsDisableInformationRightsManagement" = ${IsDisableInformationRightsManagement}
            "IsPreserveNullColumnValues" = ${IsPreserveNullColumnValues}
            "IsKeepModifiedByAndModifiedTime" = ${IsKeepModifiedByAndModifiedTime}
            "ProfileMappings" = ${ProfileMappings}
            "BackupSettings" = ${BackupSettings}
            "ConflictResolutionSettings" = ${ConflictResolutionSettings}
            "FilterPolicy" = ${FilterPolicy}
            "DeleteType" = ${DeleteType}
            "IsDeleteCheckedFiles" = ${IsDeleteCheckedFiles}
        }

        return $PSO
    }
}

<#
ContentMoveCommonSetting<PSCustomObject>
#>
function ConvertFrom-JsonToContentMoveCommonSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ContentMoveCommonSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ContentMoveCommonSetting
        $AllProperties = $("IsIncludeVersions", "IsIncludeWorkflowDefinition", "IsDisableInformationRightsManagement", "IsPreserveNullColumnValues", "IsKeepModifiedByAndModifiedTime", "ProfileMappings", "BackupSettings", "ConflictResolutionSettings", "FilterPolicy", "DeleteType", "IsDeleteCheckedFiles")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsIncludeVersions"))) { #optional property not found
            $IsIncludeVersions = $null
        } else {
            $IsIncludeVersions = $JsonParameters.PSobject.Properties["IsIncludeVersions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsIncludeWorkflowDefinition"))) { #optional property not found
            $IsIncludeWorkflowDefinition = $null
        } else {
            $IsIncludeWorkflowDefinition = $JsonParameters.PSobject.Properties["IsIncludeWorkflowDefinition"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsDisableInformationRightsManagement"))) { #optional property not found
            $IsDisableInformationRightsManagement = $null
        } else {
            $IsDisableInformationRightsManagement = $JsonParameters.PSobject.Properties["IsDisableInformationRightsManagement"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsPreserveNullColumnValues"))) { #optional property not found
            $IsPreserveNullColumnValues = $null
        } else {
            $IsPreserveNullColumnValues = $JsonParameters.PSobject.Properties["IsPreserveNullColumnValues"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsKeepModifiedByAndModifiedTime"))) { #optional property not found
            $IsKeepModifiedByAndModifiedTime = $null
        } else {
            $IsKeepModifiedByAndModifiedTime = $JsonParameters.PSobject.Properties["IsKeepModifiedByAndModifiedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProfileMappings"))) { #optional property not found
            $ProfileMappings = $null
        } else {
            $ProfileMappings = $JsonParameters.PSobject.Properties["ProfileMappings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BackupSettings"))) { #optional property not found
            $BackupSettings = $null
        } else {
            $BackupSettings = $JsonParameters.PSobject.Properties["BackupSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConflictResolutionSettings"))) { #optional property not found
            $ConflictResolutionSettings = $null
        } else {
            $ConflictResolutionSettings = $JsonParameters.PSobject.Properties["ConflictResolutionSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FilterPolicy"))) { #optional property not found
            $FilterPolicy = $null
        } else {
            $FilterPolicy = $JsonParameters.PSobject.Properties["FilterPolicy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeleteType"))) { #optional property not found
            $DeleteType = $null
        } else {
            $DeleteType = $JsonParameters.PSobject.Properties["DeleteType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsDeleteCheckedFiles"))) { #optional property not found
            $IsDeleteCheckedFiles = $null
        } else {
            $IsDeleteCheckedFiles = $JsonParameters.PSobject.Properties["IsDeleteCheckedFiles"].value
        }

        $PSO = [PSCustomObject]@{
            "IsIncludeVersions" = ${IsIncludeVersions}
            "IsIncludeWorkflowDefinition" = ${IsIncludeWorkflowDefinition}
            "IsDisableInformationRightsManagement" = ${IsDisableInformationRightsManagement}
            "IsPreserveNullColumnValues" = ${IsPreserveNullColumnValues}
            "IsKeepModifiedByAndModifiedTime" = ${IsKeepModifiedByAndModifiedTime}
            "ProfileMappings" = ${ProfileMappings}
            "BackupSettings" = ${BackupSettings}
            "ConflictResolutionSettings" = ${ConflictResolutionSettings}
            "FilterPolicy" = ${FilterPolicy}
            "DeleteType" = ${DeleteType}
            "IsDeleteCheckedFiles" = ${IsDeleteCheckedFiles}
        }

        return $PSO
    }

}

