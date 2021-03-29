#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
MetadataGridModel<PSCustomObject>
#>

function New-MetadataGridModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CreatedBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CreatedByDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${FieldType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ShowInReportType} = "DoNotDisplayInReport",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ShowInReportTypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastModifiedTime}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => MetadataGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "CreatedBy" = ${CreatedBy}
            "CreatedByDisplayName" = ${CreatedByDisplayName}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "FieldType" = ${FieldType}
            "MetadataValue" = ${MetadataValue}
            "ShowInReportType" = ${ShowInReportType}
            "ShowInReportTypeDescription" = ${ShowInReportTypeDescription}
            "LastModifiedTime" = ${LastModifiedTime}
        }

        return $PSO
    }
}

<#
MetadataGridModel<PSCustomObject>
#>
function ConvertFrom-JsonToMetadataGridModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => MetadataGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in MetadataGridModel
        $AllProperties = $("CreatedBy", "CreatedByDisplayName", "Id", "Name", "Description", "FieldType", "MetadataValue", "ShowInReportType", "ShowInReportTypeDescription", "LastModifiedTime")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedBy"))) { #optional property not found
            $CreatedBy = $null
        } else {
            $CreatedBy = $JsonParameters.PSobject.Properties["CreatedBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedByDisplayName"))) { #optional property not found
            $CreatedByDisplayName = $null
        } else {
            $CreatedByDisplayName = $JsonParameters.PSobject.Properties["CreatedByDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FieldType"))) { #optional property not found
            $FieldType = $null
        } else {
            $FieldType = $JsonParameters.PSobject.Properties["FieldType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataValue"))) { #optional property not found
            $MetadataValue = $null
        } else {
            $MetadataValue = $JsonParameters.PSobject.Properties["MetadataValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowInReportType"))) { #optional property not found
            $ShowInReportType = $null
        } else {
            $ShowInReportType = $JsonParameters.PSobject.Properties["ShowInReportType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowInReportTypeDescription"))) { #optional property not found
            $ShowInReportTypeDescription = $null
        } else {
            $ShowInReportTypeDescription = $JsonParameters.PSobject.Properties["ShowInReportTypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastModifiedTime"))) { #optional property not found
            $LastModifiedTime = $null
        } else {
            $LastModifiedTime = $JsonParameters.PSobject.Properties["LastModifiedTime"].value
        }

        $PSO = [PSCustomObject]@{
            "CreatedBy" = ${CreatedBy}
            "CreatedByDisplayName" = ${CreatedByDisplayName}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "FieldType" = ${FieldType}
            "MetadataValue" = ${MetadataValue}
            "ShowInReportType" = ${ShowInReportType}
            "ShowInReportTypeDescription" = ${ShowInReportTypeDescription}
            "LastModifiedTime" = ${LastModifiedTime}
        }

        return $PSO
    }

}

