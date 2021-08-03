$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "4.7.5")){
    Install-Module -Name $ModuleName -Force -MinimumVersion "4.7.5"
}


Import-Module -Name $ModuleName


$Configuration = Get-Configuration
$Configuration["BaseUrl"] = "{Cloud Governance Modern API Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."
# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"


$siteObjectIds = [System.Collections.Arraylist]@("19904a41-924f-47db-9d2e-3dbfb4889922","19904a41-924f-47db-9d2e-3dbfb4889921")
$workspaces = [System.Collections.Arraylist]@()
$primaryContact = New-ApiUser -LoginName "user1@example.com"
$secondaryContact = New-ApiUser -LoginName "user2@example.com"

try {

    for ($i = 0; $i -lt $siteObjectIds.Count; $i++) {
        $workspaceIdType = (New-WorkspaceIdTypeModel -ObjectId $siteObjectIds[$i] -WorkspaceType "Site")  #WorkspaceType "Site" "Group" "Teams" "Yammer"
        $workspaces.Add($workspaceIdType)
    }

    $parameter = New-SpecifyContactParameter -PrimaryContact $primaryContact -SecondaryContact $secondaryContact -Workspace $workspaces -PrimaryContactNotifiedEmail "00000000-0000-0000-0000-000000000000" -SecondaryContactNotifiedEmail "00000000-0000-0000-0000-000000000000"
    Invoke-SpecifyContacts -SpecifyContactParameter $parameter
}
catch {
    Write-Host ($_.Exception)
    Write-Host ($_.ErrorDetails.Message)
}