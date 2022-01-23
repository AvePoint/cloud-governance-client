#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateSiteService<PSCustomObject>
#>

function New-CreateSiteService {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ScopeSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdminCenterUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SiteLanguages},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${RootSiteAndManagedPaths},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteUrlSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MultiGeoSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteTitleSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Policies},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DeploymentManagerPlanSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PolicyIdsAndTemplates},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TemplateIdsAndPermissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PermissionSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeasePeriodSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TimeZones},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SiteDesigns},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteDesign},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultTeamSiteDesignId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteDesignAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${YammerGroupSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Classifications},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Sensitivities},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AllSensitivities},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubSiteSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledCustomTemplate} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CustomSiteTemplateListURL},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultPrimaryAdmin},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultAdditionalAdmins},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultPrimaryAdminReal},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultAdditionalAdminsReal},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultPrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultSecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${DefaultSiteLanguage} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultRootSite},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultManagedPath},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultPolicy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${DefaultTimeZone} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultClassification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultSensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultDesignType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteLanguageAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TemplateAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PolicyAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PermissionAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RootSiteAndManagedPathAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TimeZoneAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryAdminAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AdditionalAdminAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContactAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContactAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DesignTypeAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ClassificationAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SensitivityAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubSiteAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RequestTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HideRequestSummary} = $false,
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
        ${Type} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceAdminContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ApproversContainManagerRole} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Inactive",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowServiceInCatalog} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CustomActions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ApprovalProcessId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageId} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CreateSiteService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ScopeSettings" = ${ScopeSettings}
            "AdminCenterUrl" = ${AdminCenterUrl}
            "SiteLanguages" = ${SiteLanguages}
            "RootSiteAndManagedPaths" = ${RootSiteAndManagedPaths}
            "SiteUrlSetting" = ${SiteUrlSetting}
            "MultiGeoSetting" = ${MultiGeoSetting}
            "SiteTitleSetting" = ${SiteTitleSetting}
            "Policies" = ${Policies}
            "DeploymentManagerPlanSettings" = ${DeploymentManagerPlanSettings}
            "PolicyIdsAndTemplates" = ${PolicyIdsAndTemplates}
            "TemplateIdsAndPermissions" = ${TemplateIdsAndPermissions}
            "PermissionSettings" = ${PermissionSettings}
            "LeasePeriodSettings" = ${LeasePeriodSettings}
            "TimeZones" = ${TimeZones}
            "SiteDesigns" = ${SiteDesigns}
            "SiteDesign" = ${SiteDesign}
            "DefaultTeamSiteDesignId" = ${DefaultTeamSiteDesignId}
            "SiteDesignAssignBy" = ${SiteDesignAssignBy}
            "YammerGroupSettings" = ${YammerGroupSettings}
            "Classifications" = ${Classifications}
            "Sensitivities" = ${Sensitivities}
            "AllSensitivities" = ${AllSensitivities}
            "HubSiteSettings" = ${HubSiteSettings}
            "EnabledCustomTemplate" = ${EnabledCustomTemplate}
            "CustomSiteTemplateListURL" = ${CustomSiteTemplateListURL}
            "DefaultPrimaryAdmin" = ${DefaultPrimaryAdmin}
            "DefaultAdditionalAdmins" = ${DefaultAdditionalAdmins}
            "DefaultPrimaryAdminReal" = ${DefaultPrimaryAdminReal}
            "DefaultAdditionalAdminsReal" = ${DefaultAdditionalAdminsReal}
            "DefaultPrimaryContact" = ${DefaultPrimaryContact}
            "DefaultSecondaryContact" = ${DefaultSecondaryContact}
            "DefaultSiteLanguage" = ${DefaultSiteLanguage}
            "DefaultRootSite" = ${DefaultRootSite}
            "DefaultManagedPath" = ${DefaultManagedPath}
            "DefaultPolicy" = ${DefaultPolicy}
            "DefaultTemplate" = ${DefaultTemplate}
            "DefaultTimeZone" = ${DefaultTimeZone}
            "DefaultClassification" = ${DefaultClassification}
            "DefaultSensitivity" = ${DefaultSensitivity}
            "DefaultDesignType" = ${DefaultDesignType}
            "SiteLanguageAssignBy" = ${SiteLanguageAssignBy}
            "TemplateAssignBy" = ${TemplateAssignBy}
            "PolicyAssignBy" = ${PolicyAssignBy}
            "PermissionAssignBy" = ${PermissionAssignBy}
            "RootSiteAndManagedPathAssignBy" = ${RootSiteAndManagedPathAssignBy}
            "TimeZoneAssignBy" = ${TimeZoneAssignBy}
            "PrimaryAdminAssignBy" = ${PrimaryAdminAssignBy}
            "AdditionalAdminAssignBy" = ${AdditionalAdminAssignBy}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "DesignTypeAssignBy" = ${DesignTypeAssignBy}
            "ClassificationAssignBy" = ${ClassificationAssignBy}
            "SensitivityAssignBy" = ${SensitivityAssignBy}
            "HubSiteAssignBy" = ${HubSiteAssignBy}
            "RequestTemplate" = ${RequestTemplate}
            "Metadatas" = ${Metadatas}
            "HideRequestSummary" = ${HideRequestSummary}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "ServiceContact" = ${ServiceContact}
            "ServiceAdminContact" = ${ServiceAdminContact}
            "ApproversContainManagerRole" = ${ApproversContainManagerRole}
            "Status" = ${Status}
            "ShowServiceInCatalog" = ${ShowServiceInCatalog}
            "CustomActions" = ${CustomActions}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LanguageId" = ${LanguageId}
            "CategoryId" = ${CategoryId}
        }

        return $PSO
    }
}

<#
CreateSiteService<PSCustomObject>
#>
function ConvertFrom-JsonToCreateSiteService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateSiteService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateSiteService
        $AllProperties = $("ScopeSettings", "AdminCenterUrl", "SiteLanguages", "RootSiteAndManagedPaths", "SiteUrlSetting", "MultiGeoSetting", "SiteTitleSetting", "Policies", "DeploymentManagerPlanSettings", "PolicyIdsAndTemplates", "TemplateIdsAndPermissions", "PermissionSettings", "LeasePeriodSettings", "TimeZones", "SiteDesigns", "SiteDesign", "DefaultTeamSiteDesignId", "SiteDesignAssignBy", "YammerGroupSettings", "Classifications", "Sensitivities", "AllSensitivities", "HubSiteSettings", "EnabledCustomTemplate", "CustomSiteTemplateListURL", "DefaultPrimaryAdmin", "DefaultAdditionalAdmins", "DefaultPrimaryAdminReal", "DefaultAdditionalAdminsReal", "DefaultPrimaryContact", "DefaultSecondaryContact", "DefaultSiteLanguage", "DefaultRootSite", "DefaultManagedPath", "DefaultPolicy", "DefaultTemplate", "DefaultTimeZone", "DefaultClassification", "DefaultSensitivity", "DefaultDesignType", "SiteLanguageAssignBy", "TemplateAssignBy", "PolicyAssignBy", "PermissionAssignBy", "RootSiteAndManagedPathAssignBy", "TimeZoneAssignBy", "PrimaryAdminAssignBy", "AdditionalAdminAssignBy", "PrimaryContactAssignBy", "SecondaryContactAssignBy", "DesignTypeAssignBy", "ClassificationAssignBy", "SensitivityAssignBy", "HubSiteAssignBy", "RequestTemplate", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScopeSettings"))) { #optional property not found
            $ScopeSettings = $null
        } else {
            $ScopeSettings = $JsonParameters.PSobject.Properties["ScopeSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminCenterUrl"))) { #optional property not found
            $AdminCenterUrl = $null
        } else {
            $AdminCenterUrl = $JsonParameters.PSobject.Properties["AdminCenterUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteLanguages"))) { #optional property not found
            $SiteLanguages = $null
        } else {
            $SiteLanguages = $JsonParameters.PSobject.Properties["SiteLanguages"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RootSiteAndManagedPaths"))) { #optional property not found
            $RootSiteAndManagedPaths = $null
        } else {
            $RootSiteAndManagedPaths = $JsonParameters.PSobject.Properties["RootSiteAndManagedPaths"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrlSetting"))) { #optional property not found
            $SiteUrlSetting = $null
        } else {
            $SiteUrlSetting = $JsonParameters.PSobject.Properties["SiteUrlSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MultiGeoSetting"))) { #optional property not found
            $MultiGeoSetting = $null
        } else {
            $MultiGeoSetting = $JsonParameters.PSobject.Properties["MultiGeoSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteTitleSetting"))) { #optional property not found
            $SiteTitleSetting = $null
        } else {
            $SiteTitleSetting = $JsonParameters.PSobject.Properties["SiteTitleSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Policies"))) { #optional property not found
            $Policies = $null
        } else {
            $Policies = $JsonParameters.PSobject.Properties["Policies"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeploymentManagerPlanSettings"))) { #optional property not found
            $DeploymentManagerPlanSettings = $null
        } else {
            $DeploymentManagerPlanSettings = $JsonParameters.PSobject.Properties["DeploymentManagerPlanSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyIdsAndTemplates"))) { #optional property not found
            $PolicyIdsAndTemplates = $null
        } else {
            $PolicyIdsAndTemplates = $JsonParameters.PSobject.Properties["PolicyIdsAndTemplates"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateIdsAndPermissions"))) { #optional property not found
            $TemplateIdsAndPermissions = $null
        } else {
            $TemplateIdsAndPermissions = $JsonParameters.PSobject.Properties["TemplateIdsAndPermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionSettings"))) { #optional property not found
            $PermissionSettings = $null
        } else {
            $PermissionSettings = $JsonParameters.PSobject.Properties["PermissionSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeasePeriodSettings"))) { #optional property not found
            $LeasePeriodSettings = $null
        } else {
            $LeasePeriodSettings = $JsonParameters.PSobject.Properties["LeasePeriodSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TimeZones"))) { #optional property not found
            $TimeZones = $null
        } else {
            $TimeZones = $JsonParameters.PSobject.Properties["TimeZones"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteDesigns"))) { #optional property not found
            $SiteDesigns = $null
        } else {
            $SiteDesigns = $JsonParameters.PSobject.Properties["SiteDesigns"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteDesign"))) { #optional property not found
            $SiteDesign = $null
        } else {
            $SiteDesign = $JsonParameters.PSobject.Properties["SiteDesign"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultTeamSiteDesignId"))) { #optional property not found
            $DefaultTeamSiteDesignId = $null
        } else {
            $DefaultTeamSiteDesignId = $JsonParameters.PSobject.Properties["DefaultTeamSiteDesignId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteDesignAssignBy"))) { #optional property not found
            $SiteDesignAssignBy = $null
        } else {
            $SiteDesignAssignBy = $JsonParameters.PSobject.Properties["SiteDesignAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "YammerGroupSettings"))) { #optional property not found
            $YammerGroupSettings = $null
        } else {
            $YammerGroupSettings = $JsonParameters.PSobject.Properties["YammerGroupSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Classifications"))) { #optional property not found
            $Classifications = $null
        } else {
            $Classifications = $JsonParameters.PSobject.Properties["Classifications"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sensitivities"))) { #optional property not found
            $Sensitivities = $null
        } else {
            $Sensitivities = $JsonParameters.PSobject.Properties["Sensitivities"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllSensitivities"))) { #optional property not found
            $AllSensitivities = $null
        } else {
            $AllSensitivities = $JsonParameters.PSobject.Properties["AllSensitivities"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HubSiteSettings"))) { #optional property not found
            $HubSiteSettings = $null
        } else {
            $HubSiteSettings = $JsonParameters.PSobject.Properties["HubSiteSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledCustomTemplate"))) { #optional property not found
            $EnabledCustomTemplate = $null
        } else {
            $EnabledCustomTemplate = $JsonParameters.PSobject.Properties["EnabledCustomTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CustomSiteTemplateListURL"))) { #optional property not found
            $CustomSiteTemplateListURL = $null
        } else {
            $CustomSiteTemplateListURL = $JsonParameters.PSobject.Properties["CustomSiteTemplateListURL"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultPrimaryAdmin"))) { #optional property not found
            $DefaultPrimaryAdmin = $null
        } else {
            $DefaultPrimaryAdmin = $JsonParameters.PSobject.Properties["DefaultPrimaryAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultAdditionalAdmins"))) { #optional property not found
            $DefaultAdditionalAdmins = $null
        } else {
            $DefaultAdditionalAdmins = $JsonParameters.PSobject.Properties["DefaultAdditionalAdmins"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultPrimaryAdminReal"))) { #optional property not found
            $DefaultPrimaryAdminReal = $null
        } else {
            $DefaultPrimaryAdminReal = $JsonParameters.PSobject.Properties["DefaultPrimaryAdminReal"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultAdditionalAdminsReal"))) { #optional property not found
            $DefaultAdditionalAdminsReal = $null
        } else {
            $DefaultAdditionalAdminsReal = $JsonParameters.PSobject.Properties["DefaultAdditionalAdminsReal"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultPrimaryContact"))) { #optional property not found
            $DefaultPrimaryContact = $null
        } else {
            $DefaultPrimaryContact = $JsonParameters.PSobject.Properties["DefaultPrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultSecondaryContact"))) { #optional property not found
            $DefaultSecondaryContact = $null
        } else {
            $DefaultSecondaryContact = $JsonParameters.PSobject.Properties["DefaultSecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultSiteLanguage"))) { #optional property not found
            $DefaultSiteLanguage = $null
        } else {
            $DefaultSiteLanguage = $JsonParameters.PSobject.Properties["DefaultSiteLanguage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultRootSite"))) { #optional property not found
            $DefaultRootSite = $null
        } else {
            $DefaultRootSite = $JsonParameters.PSobject.Properties["DefaultRootSite"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultManagedPath"))) { #optional property not found
            $DefaultManagedPath = $null
        } else {
            $DefaultManagedPath = $JsonParameters.PSobject.Properties["DefaultManagedPath"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultPolicy"))) { #optional property not found
            $DefaultPolicy = $null
        } else {
            $DefaultPolicy = $JsonParameters.PSobject.Properties["DefaultPolicy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultTemplate"))) { #optional property not found
            $DefaultTemplate = $null
        } else {
            $DefaultTemplate = $JsonParameters.PSobject.Properties["DefaultTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultTimeZone"))) { #optional property not found
            $DefaultTimeZone = $null
        } else {
            $DefaultTimeZone = $JsonParameters.PSobject.Properties["DefaultTimeZone"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultClassification"))) { #optional property not found
            $DefaultClassification = $null
        } else {
            $DefaultClassification = $JsonParameters.PSobject.Properties["DefaultClassification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultSensitivity"))) { #optional property not found
            $DefaultSensitivity = $null
        } else {
            $DefaultSensitivity = $JsonParameters.PSobject.Properties["DefaultSensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultDesignType"))) { #optional property not found
            $DefaultDesignType = $null
        } else {
            $DefaultDesignType = $JsonParameters.PSobject.Properties["DefaultDesignType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteLanguageAssignBy"))) { #optional property not found
            $SiteLanguageAssignBy = $null
        } else {
            $SiteLanguageAssignBy = $JsonParameters.PSobject.Properties["SiteLanguageAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateAssignBy"))) { #optional property not found
            $TemplateAssignBy = $null
        } else {
            $TemplateAssignBy = $JsonParameters.PSobject.Properties["TemplateAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyAssignBy"))) { #optional property not found
            $PolicyAssignBy = $null
        } else {
            $PolicyAssignBy = $JsonParameters.PSobject.Properties["PolicyAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionAssignBy"))) { #optional property not found
            $PermissionAssignBy = $null
        } else {
            $PermissionAssignBy = $JsonParameters.PSobject.Properties["PermissionAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RootSiteAndManagedPathAssignBy"))) { #optional property not found
            $RootSiteAndManagedPathAssignBy = $null
        } else {
            $RootSiteAndManagedPathAssignBy = $JsonParameters.PSobject.Properties["RootSiteAndManagedPathAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TimeZoneAssignBy"))) { #optional property not found
            $TimeZoneAssignBy = $null
        } else {
            $TimeZoneAssignBy = $JsonParameters.PSobject.Properties["TimeZoneAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdminAssignBy"))) { #optional property not found
            $PrimaryAdminAssignBy = $null
        } else {
            $PrimaryAdminAssignBy = $JsonParameters.PSobject.Properties["PrimaryAdminAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalAdminAssignBy"))) { #optional property not found
            $AdditionalAdminAssignBy = $null
        } else {
            $AdditionalAdminAssignBy = $JsonParameters.PSobject.Properties["AdditionalAdminAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContactAssignBy"))) { #optional property not found
            $PrimaryContactAssignBy = $null
        } else {
            $PrimaryContactAssignBy = $JsonParameters.PSobject.Properties["PrimaryContactAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactAssignBy"))) { #optional property not found
            $SecondaryContactAssignBy = $null
        } else {
            $SecondaryContactAssignBy = $JsonParameters.PSobject.Properties["SecondaryContactAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DesignTypeAssignBy"))) { #optional property not found
            $DesignTypeAssignBy = $null
        } else {
            $DesignTypeAssignBy = $JsonParameters.PSobject.Properties["DesignTypeAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassificationAssignBy"))) { #optional property not found
            $ClassificationAssignBy = $null
        } else {
            $ClassificationAssignBy = $JsonParameters.PSobject.Properties["ClassificationAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SensitivityAssignBy"))) { #optional property not found
            $SensitivityAssignBy = $null
        } else {
            $SensitivityAssignBy = $JsonParameters.PSobject.Properties["SensitivityAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HubSiteAssignBy"))) { #optional property not found
            $HubSiteAssignBy = $null
        } else {
            $HubSiteAssignBy = $JsonParameters.PSobject.Properties["HubSiteAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestTemplate"))) { #optional property not found
            $RequestTemplate = $null
        } else {
            $RequestTemplate = $JsonParameters.PSobject.Properties["RequestTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HideRequestSummary"))) { #optional property not found
            $HideRequestSummary = $null
        } else {
            $HideRequestSummary = $JsonParameters.PSobject.Properties["HideRequestSummary"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceContact"))) { #optional property not found
            $ServiceContact = $null
        } else {
            $ServiceContact = $JsonParameters.PSobject.Properties["ServiceContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceAdminContact"))) { #optional property not found
            $ServiceAdminContact = $null
        } else {
            $ServiceAdminContact = $JsonParameters.PSobject.Properties["ServiceAdminContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApproversContainManagerRole"))) { #optional property not found
            $ApproversContainManagerRole = $null
        } else {
            $ApproversContainManagerRole = $JsonParameters.PSobject.Properties["ApproversContainManagerRole"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowServiceInCatalog"))) { #optional property not found
            $ShowServiceInCatalog = $null
        } else {
            $ShowServiceInCatalog = $JsonParameters.PSobject.Properties["ShowServiceInCatalog"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CustomActions"))) { #optional property not found
            $CustomActions = $null
        } else {
            $CustomActions = $JsonParameters.PSobject.Properties["CustomActions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApprovalProcessId"))) { #optional property not found
            $ApprovalProcessId = $null
        } else {
            $ApprovalProcessId = $JsonParameters.PSobject.Properties["ApprovalProcessId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageId"))) { #optional property not found
            $LanguageId = $null
        } else {
            $LanguageId = $JsonParameters.PSobject.Properties["LanguageId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CategoryId"))) { #optional property not found
            $CategoryId = $null
        } else {
            $CategoryId = $JsonParameters.PSobject.Properties["CategoryId"].value
        }

        $PSO = [PSCustomObject]@{
            "ScopeSettings" = ${ScopeSettings}
            "AdminCenterUrl" = ${AdminCenterUrl}
            "SiteLanguages" = ${SiteLanguages}
            "RootSiteAndManagedPaths" = ${RootSiteAndManagedPaths}
            "SiteUrlSetting" = ${SiteUrlSetting}
            "MultiGeoSetting" = ${MultiGeoSetting}
            "SiteTitleSetting" = ${SiteTitleSetting}
            "Policies" = ${Policies}
            "DeploymentManagerPlanSettings" = ${DeploymentManagerPlanSettings}
            "PolicyIdsAndTemplates" = ${PolicyIdsAndTemplates}
            "TemplateIdsAndPermissions" = ${TemplateIdsAndPermissions}
            "PermissionSettings" = ${PermissionSettings}
            "LeasePeriodSettings" = ${LeasePeriodSettings}
            "TimeZones" = ${TimeZones}
            "SiteDesigns" = ${SiteDesigns}
            "SiteDesign" = ${SiteDesign}
            "DefaultTeamSiteDesignId" = ${DefaultTeamSiteDesignId}
            "SiteDesignAssignBy" = ${SiteDesignAssignBy}
            "YammerGroupSettings" = ${YammerGroupSettings}
            "Classifications" = ${Classifications}
            "Sensitivities" = ${Sensitivities}
            "AllSensitivities" = ${AllSensitivities}
            "HubSiteSettings" = ${HubSiteSettings}
            "EnabledCustomTemplate" = ${EnabledCustomTemplate}
            "CustomSiteTemplateListURL" = ${CustomSiteTemplateListURL}
            "DefaultPrimaryAdmin" = ${DefaultPrimaryAdmin}
            "DefaultAdditionalAdmins" = ${DefaultAdditionalAdmins}
            "DefaultPrimaryAdminReal" = ${DefaultPrimaryAdminReal}
            "DefaultAdditionalAdminsReal" = ${DefaultAdditionalAdminsReal}
            "DefaultPrimaryContact" = ${DefaultPrimaryContact}
            "DefaultSecondaryContact" = ${DefaultSecondaryContact}
            "DefaultSiteLanguage" = ${DefaultSiteLanguage}
            "DefaultRootSite" = ${DefaultRootSite}
            "DefaultManagedPath" = ${DefaultManagedPath}
            "DefaultPolicy" = ${DefaultPolicy}
            "DefaultTemplate" = ${DefaultTemplate}
            "DefaultTimeZone" = ${DefaultTimeZone}
            "DefaultClassification" = ${DefaultClassification}
            "DefaultSensitivity" = ${DefaultSensitivity}
            "DefaultDesignType" = ${DefaultDesignType}
            "SiteLanguageAssignBy" = ${SiteLanguageAssignBy}
            "TemplateAssignBy" = ${TemplateAssignBy}
            "PolicyAssignBy" = ${PolicyAssignBy}
            "PermissionAssignBy" = ${PermissionAssignBy}
            "RootSiteAndManagedPathAssignBy" = ${RootSiteAndManagedPathAssignBy}
            "TimeZoneAssignBy" = ${TimeZoneAssignBy}
            "PrimaryAdminAssignBy" = ${PrimaryAdminAssignBy}
            "AdditionalAdminAssignBy" = ${AdditionalAdminAssignBy}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "DesignTypeAssignBy" = ${DesignTypeAssignBy}
            "ClassificationAssignBy" = ${ClassificationAssignBy}
            "SensitivityAssignBy" = ${SensitivityAssignBy}
            "HubSiteAssignBy" = ${HubSiteAssignBy}
            "RequestTemplate" = ${RequestTemplate}
            "Metadatas" = ${Metadatas}
            "HideRequestSummary" = ${HideRequestSummary}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "ServiceContact" = ${ServiceContact}
            "ServiceAdminContact" = ${ServiceAdminContact}
            "ApproversContainManagerRole" = ${ApproversContainManagerRole}
            "Status" = ${Status}
            "ShowServiceInCatalog" = ${ShowServiceInCatalog}
            "CustomActions" = ${CustomActions}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LanguageId" = ${LanguageId}
            "CategoryId" = ${CategoryId}
        }

        return $PSO
    }

}

