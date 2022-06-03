$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "5.5.3.0")){
    Install-Module -Name $ModuleName -Force -MinimumVersion "5.5.3.0"
}


Import-Module -Name $ModuleName

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud Governance Modern API Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."
# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"

try {
#$Id = "6ab493d7-b588-4338-a233-929******8ce" 

$CommentsParam =  New-CommentsParam -Comments "test"

#$AutoTaskExtendRequest = (New-AutoTaskExtendRequest -Action 1 -ExtendDuration 11 -TaskId "6469647d-4e05-46a2-bf30-ef0fceb12daa"  -Comments $CommentsParam)
 
#Submit-ExtendGroupAutoTask -AutoTaskExtendRequest $AutoTaskExtendRequest

#Submit-ExtendSiteAutoTask -AutoTaskExtendRequest $AutoTaskExtendRequest

#Submit-ContinueAccessGroupAutoTask -Id $id -CommentsParam $CommentsParam

#Submit-ContinueAccessSiteAutoTask -Id $id -CommentsParam $CommentsParam
}
catch {
    Write-Host ($_.Exception)
    Write-Host ($_.ErrorDetails.Message)
}