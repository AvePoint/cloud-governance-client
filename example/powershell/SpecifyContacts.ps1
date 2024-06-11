$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "7.6.0")){
    Install-Module -Name $ModuleName -Force -MinimumVersion "7.6.0"
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


$site =  New-WorkspaceIdTypeModel -ObjectId "19904a41-924f-47db-9d2e-3dbfb4889921" -WorkspaceType "Site"
$teams =  New-WorkspaceIdTypeModel -ObjectId "19904a41-924f-47db-9d2e-3dbfb4889922" -WorkspaceType "Teams"
$group = New-WorkspaceIdTypeModel -ObjectId "19904a41-924f-47db-9d2e-3dbfb4889923" -WorkspaceType "Group"
$primaryContact = "user1@example.com"
$secondaryContact = "user2@example.com"
$workspaces = [System.Collections.Arraylist]@($site,$teams,$group)

try {
    
    $primaryContactUser =  Resolve-ACGUsers -Keyword $primaryContact -UserType "User" -UserSource "Azure" -SharingOptions "0"
    $secondaryContactUser = Resolve-ACGUsers -Keyword $secondaryContact -UserType "User" -UserSource "Azure" -SharingOptions "0"

    $parameter = New-SpecifyContactParameter -PrimaryContact $primaryContactUser -SecondaryContact $secondaryContactUser -Workspace $workspaces -PrimaryContactNotifiedEmail "00000000-0000-0000-0000-000000000000" -SecondaryContactNotifiedEmail "00000000-0000-0000-0000-000000000000"
    Invoke-SpecifyContacts -SpecifyContactParameter $parameter
}
catch {
    Write-Host ($_.Exception)
    Write-Host ($_.ErrorDetails.Message)
}